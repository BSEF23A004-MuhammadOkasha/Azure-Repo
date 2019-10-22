﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Azure.Core.Tests
{
    public class ClientDiagnosticListener : IObserver<KeyValuePair<string, object>>, IObserver<DiagnosticListener>, IDisposable
    {
        private readonly string _diagnosticSourceName;

        private List<IDisposable> _subscriptions = new List<IDisposable>();

        public List<ProducedDiagnosticScope> Scopes { get; } = new List<ProducedDiagnosticScope>();

        public ClientDiagnosticListener(string name)
        {
            _diagnosticSourceName = name;
            DiagnosticListener.AllListeners.Subscribe(this);
        }

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(KeyValuePair<string, object> value)
        {
            lock (Scopes)
            {
                var startSuffix = ".Start";
                var stopSuffix = ".Stop";
                var exceptionSuffix = ".Exception";

                if (value.Key.EndsWith(startSuffix))
                {
                    var name = value.Key.Substring(0, value.Key.Length - startSuffix.Length);
                    PropertyInfo propertyInfo = value.Value.GetType().GetProperty("Links");
                    var links = propertyInfo?.GetValue(value.Value) as IEnumerable<Activity> ?? Array.Empty<Activity>();

                    var scope = new ProducedDiagnosticScope()
                    {
                        Name = name,
                        Activity = Activity.Current,
                        Links = links.Select(a => a.ParentId).ToList()
                    };
                    Scopes.Add(scope);
                }
                else if (value.Key.EndsWith(stopSuffix))
                {
                    var name = value.Key.Substring(0, value.Key.Length - stopSuffix.Length);
                    foreach (ProducedDiagnosticScope producedDiagnosticScope in Scopes)
                    {
                        if (producedDiagnosticScope.Name == name)
                        {
                            producedDiagnosticScope.IsCompleted = true;
                            return;
                        }
                    }
                    throw new InvalidOperationException($"Event '{name}' was not started");
                }
                else if (value.Key.EndsWith(exceptionSuffix))
                {
                    var name = value.Key.Substring(0, value.Key.Length - exceptionSuffix.Length);
                    foreach (ProducedDiagnosticScope producedDiagnosticScope in Scopes)
                    {
                        if (producedDiagnosticScope.IsCompleted)
                        {
                            throw new InvalidOperationException("Scope should not be stopped when calling Failed");
                        }

                        if (producedDiagnosticScope.Name == name)
                        {
                            producedDiagnosticScope.Exception = (Exception)value.Value;
                        }
                    }
                }
            }
        }

        public void OnNext(DiagnosticListener value)
        {
            List<IDisposable> subscriptions = _subscriptions;
            if (value.Name == _diagnosticSourceName && subscriptions != null)
            {
                lock (subscriptions)
                {
                    subscriptions.Add(value.Subscribe(this));
                }
            }
        }

        public void Dispose()
        {
            List<IDisposable> subscriptions;
            lock (_subscriptions)
            {
                subscriptions = _subscriptions;
                _subscriptions = null;
            }

            foreach (IDisposable subscription in subscriptions)
            {
                subscription.Dispose();
            }

            foreach (ProducedDiagnosticScope producedDiagnosticScope in Scopes)
            {
                if (!producedDiagnosticScope.IsCompleted)
                {
                    throw new InvalidOperationException($"'{producedDiagnosticScope.Name}' is not completed");
                }
            }
        }

        public ProducedDiagnosticScope AssertScopeStarted(string name, params KeyValuePair<string, string>[] expectedAttributes)
        {
            lock (Scopes)
            {
                foreach (ProducedDiagnosticScope producedDiagnosticScope in Scopes)
                {
                    if (producedDiagnosticScope.Name == name)
                    {
                        foreach (KeyValuePair<string, string> expectedAttribute in expectedAttributes)
                        {
                            if (!producedDiagnosticScope.Activity.Tags.Contains(expectedAttribute))
                            {
                                throw new InvalidOperationException($"Attribute {expectedAttribute} not found, existing attributes: {string.Join(",", producedDiagnosticScope.Activity.Tags)}");
                            }
                        }

                        return producedDiagnosticScope;
                    }
                }
                throw new InvalidOperationException($"Event '{name}' was not started");
            }
        }

        public ProducedDiagnosticScope AssertScope(string name, params KeyValuePair<string, string>[] expectedAttributes)
        {
            ProducedDiagnosticScope scope = AssertScopeStarted(name, expectedAttributes);
            if (!scope.IsCompleted)
            {
                throw new InvalidOperationException($"'{name}' is not completed");
            }

            return scope;
        }

        public ProducedDiagnosticScope AssertScopeException(string name, Action<Exception> action = null)
        {
            ProducedDiagnosticScope scope = AssertScopeStarted(name);

            if (scope.Exception == null)
            {
                throw new InvalidOperationException($"Scope '{name}' is not marked as failed");
            }

            action?.Invoke(scope.Exception);

            return scope;
        }

        public class ProducedDiagnosticScope
        {
            public string Name { get; set; }
            public Activity Activity { get; set; }
            public bool IsCompleted { get; set; }
            public Exception Exception { get; set; }
            public List<string> Links { get; set; } = new List<string>();
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Rest.ClientRuntime.Azure.Properties {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Rest.ClientRuntime.Azure.Properties.Resources", typeof(Resources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value cannot be empty.
        ///Parameter name: {0}.
        /// </summary>
        internal static string ArgumentCannotBeEmpty {
            get {
                return ResourceManager.GetString("ArgumentCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified argument {0} cannot be greater than its ceiling value of {1}..
        /// </summary>
        internal static string ArgumentCannotBeGreaterThanBaseline {
            get {
                return ResourceManager.GetString("ArgumentCannotBeGreaterThanBaseline", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified argument {0} cannot be initialized with a negative value..
        /// </summary>
        internal static string ArgumentCannotBeNegative {
            get {
                return ResourceManager.GetString("ArgumentCannotBeNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authentication with Azure Active Directory Failed using clientId: {0}.
        /// </summary>
        internal static string AuthenticationValidationFailed {
            get {
                return ResourceManager.GetString("AuthenticationValidationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to deserilize body &apos;{0}&apos;.
        /// </summary>
        internal static string BodyDeserializationError {
            get {
                return ResourceManager.GetString("BodyDeserializationError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} requires a {1} in its HTTP pipeline to work with client certificates..
        /// </summary>
        internal static string CertificateCloudCredentials_InitializeServiceClient_NoWebRequestHandler {
            get {
                return ResourceManager.GetString("CertificateCloudCredentials_InitializeServiceClient_NoWebRequestHandler", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to convert parameter {0} value &apos;{1}&apos; to type {2}..
        /// </summary>
        internal static string ConfigurationHelper_CreateCouldNotConvertException {
            get {
                return ResourceManager.GetString("ConfigurationHelper_CreateCouldNotConvertException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {3}  Failed to create {0} from connection settings {1} = &quot;{2}&quot;..
        /// </summary>
        internal static string ConfigurationHelper_CreateFromSettings_CreateSettingsFailedException {
            get {
                return ResourceManager.GetString("ConfigurationHelper_CreateFromSettings_CreateSettingsFailedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No connection settings found for type {0}.  Enable tracing for more information..
        /// </summary>
        internal static string ConfigurationHelper_CreateFromSettings_NoConnectionSettingsFound {
            get {
                return ResourceManager.GetString("ConfigurationHelper_CreateFromSettings_NoConnectionSettingsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No credentials of type &apos;{0}&apos; could be initialized from the provided settings..
        /// </summary>
        internal static string ConfigurationHelper_GetCredentials_NotFound {
            get {
                return ResourceManager.GetString("ConfigurationHelper_GetCredentials_NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter {0} is required..
        /// </summary>
        internal static string ConfigurationHelper_GetParameter_NotFound {
            get {
                return ResourceManager.GetString("ConfigurationHelper_GetParameter_NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to convert parameter {0} value &apos;{1}&apos; to type {2}..
        /// </summary>
        internal static string CouldNotConvertToCertificateType {
            get {
                return ResourceManager.GetString("CouldNotConvertToCertificateType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default retry strategy for technology {0}, named &apos;{1}&apos;, is not defined..
        /// </summary>
        internal static string DefaultRetryStrategyMappingNotFound {
            get {
                return ResourceManager.GetString("DefaultRetryStrategyMappingNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default retry strategy for technology {0} was not not defined, and there is no overall default strategy..
        /// </summary>
        internal static string DefaultRetryStrategyNotFound {
            get {
                return ResourceManager.GetString("DefaultRetryStrategyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Authentication error while configuring active directory: &apos;{0}&apos;..
        /// </summary>
        internal static string ErrorCreatingAuthenticationContext {
            get {
                return ResourceManager.GetString("ErrorCreatingAuthenticationContext", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retry handler is not present in the HttpClient handler stack..
        /// </summary>
        internal static string ExceptionRetryHandlerMissing {
            get {
                return ResourceManager.GetString("ExceptionRetryHandlerMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The RetryManager is already set..
        /// </summary>
        internal static string ExceptionRetryManagerAlreadySet {
            get {
                return ResourceManager.GetString("ExceptionRetryManagerAlreadySet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The default RetryManager has not been set. Set it by invoking the RetryManager.SetDefault static method, or if you are using declarative configuration, you can invoke the RetryPolicyFactory.CreateDefault() method to automatically create the retry manager from the configuration file..
        /// </summary>
        internal static string ExceptionRetryManagerNotSet {
            get {
                return ResourceManager.GetString("ExceptionRetryManagerNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to In long running operation &apos;{0}&apos; header requires initial response status code to be &apos;{1}&apos;.
        /// </summary>
        internal static string HeaderAndStatusCode {
            get {
                return ResourceManager.GetString("HeaderAndStatusCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provided URI &apos;{0}&apos; is not a valid URI..
        /// </summary>
        internal static string InValidUri {
            get {
                return ResourceManager.GetString("InValidUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Long running operation failed with status &apos;{0}&apos;..
        /// </summary>
        internal static string LongRunningOperationFailed {
            get {
                return ResourceManager.GetString("LongRunningOperationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Long running operation failed with status &apos;{0}&apos;. Additional Info:&apos;{1}&apos;.
        /// </summary>
        internal static string LROOperationFailedAdditionalInfo {
            get {
                return ResourceManager.GetString("LROOperationFailedAdditionalInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The response from long running operation does not contain a body..
        /// </summary>
        internal static string NoBody {
            get {
                return ResourceManager.GetString("NoBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Location header is missing from long running operation..
        /// </summary>
        internal static string NoHeader {
            get {
                return ResourceManager.GetString("NoHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Provisioning state is missing from long running operation..
        /// </summary>
        internal static string NoProvisioningState {
            get {
                return ResourceManager.GetString("NoProvisioningState", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Response status code indicates server error: {0} ({1})..
        /// </summary>
        internal static string ResponseStatusCodeError {
            get {
                return ResourceManager.GetString("ResponseStatusCodeError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The action has exceeded its defined retry limit..
        /// </summary>
        internal static string RetryLimitExceeded {
            get {
                return ResourceManager.GetString("RetryLimitExceeded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The retry strategy with name &apos;{0}&apos; cannot be found..
        /// </summary>
        internal static string RetryStrategyNotFound {
            get {
                return ResourceManager.GetString("RetryStrategyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified string argument {0} must not be empty..
        /// </summary>
        internal static string StringCannotBeEmpty {
            get {
                return ResourceManager.GetString("StringCannotBeEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified argument &apos;{0}&apos; cannot return a null task when invoked..
        /// </summary>
        internal static string TaskCannotBeNull {
            get {
                return ResourceManager.GetString("TaskCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified argument &apos;{0}&apos; must return a scheduled task (also known as &quot;hot&quot; task) when invoked..
        /// </summary>
        internal static string TaskMustBeScheduled {
            get {
                return ResourceManager.GetString("TaskMustBeScheduled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unexpected polling status code from long running operation &apos;{0}&apos; for method &apos;{1}&apos;..
        /// </summary>
        internal static string UnexpectedPollingStatus {
            get {
                return ResourceManager.GetString("UnexpectedPollingStatus", resourceCulture);
            }
        }
    }
}

﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Azure.AI.FormRecognizer.Models
{
    public class ExtractedReceipt
    {
        internal ExtractedReceipt(DocumentResult_internal documentResult)
        {
            PageRange = new PageRange(documentResult.PageRange);
            SetReceiptValues(documentResult.Fields);
        }

        public PageRange PageRange { get; internal set; }

        // TODO: I want to make these nullable in case a value isn't present or
        // isn't read by the learner.
        public IReadOnlyList<ExtractedReceiptItem> Items { get; internal set; }
        public string MerchantAddress { get; internal set; }
        public string MerchantName { get; internal set; }
        public string MerchantPhoneNumber { get; internal set; }
        //public RawReceiptExtraction RawFields { get; internal set; }
        public ReceiptType ReceiptType { get; internal set; }
        public float Subtotal { get; internal set; }
        public float Tax { get; internal set; }
        public float Tip { get; internal set; }
        public float Total { get; internal set; }
        public DateTimeOffset TransactionDate { get; internal set; }
        public DateTimeOffset TransactionTime { get; internal set; }

        private void SetReceiptValues(IDictionary<string, FieldValue_internal> fields)
        {
            ReceiptType = SetReceiptType(fields);

            MerchantAddress = SetStringValue("MerchantAddress", fields);
            MerchantName = SetStringValue("MerchantName", fields);
            MerchantPhoneNumber = SetStringValue("MerchantPhoneNumber", fields);

            Subtotal = SetFloatValue("Subtotal", fields);
            Tax = SetFloatValue("Tax", fields);
            Tip = SetFloatValue("Tip", fields);
            Total = SetFloatValue("Total", fields);

            TransactionDate = SetDateTimeOffsetValue("TransactionDate", fields);
            TransactionTime = SetDateTimeOffsetValue("TransactionTime", fields);

            Items = SetReceiptItems(fields);
        }

        private static ReceiptType SetReceiptType(IDictionary<string, FieldValue_internal> fields)
        {
            ReceiptType receiptType = ReceiptType.Unrecognized;

            FieldValue_internal value;
            if (fields.TryGetValue("ReceiptType", out value))
            {
                receiptType = value.ValueString switch
                {
                    "Itemized" => ReceiptType.Itemized,
                    _ => ReceiptType.Unrecognized,
                };
            }

            return receiptType;
        }

        private static string SetStringValue(string fieldName, IDictionary<string, FieldValue_internal> fields)
        {
            string stringValue = default;

            FieldValue_internal value;
            if (fields.TryGetValue(fieldName, out value))
            {
                // TODO: How should we handle Phone Numbers?
                Debug.Assert(value.Type == FieldValueType.String || value.Type == FieldValueType.PhoneNumber);

                // TODO: When should we use text and when should we use string?
                // For now, use text if the value is null.
                stringValue = value.ValueString ?? value.Text;
            }

            return stringValue;
        }

        private static float SetFloatValue(string fieldName, IDictionary<string, FieldValue_internal> fields)
        {
            float floatValue = default;

            FieldValue_internal value;
            if (fields.TryGetValue(fieldName, out value))
            {
                Debug.Assert(value.Type == FieldValueType.Number);

                // TODO: Sometimes ValueNumber isn't populated in ReceiptItems.  The following is a
                // workaround to get the value from Text if ValueNumber isn't there.
                float parsedFloat;
                if (float.TryParse(value.Text.TrimStart('$'), out parsedFloat))
                {
                    floatValue = value.ValueNumber.HasValue ? value.ValueNumber.Value : parsedFloat;
                }
                else
                {
                    // TODO: make this nullable!
                    floatValue = value.ValueNumber.HasValue ? value.ValueNumber.Value : default;
                }
            }

            return floatValue;
        }

        private static int SetIntValue(string fieldName, IDictionary<string, FieldValue_internal> fields)
        {
            int intValue = default;

            FieldValue_internal value;
            if (fields.TryGetValue(fieldName, out value))
            {
                Debug.Assert(value.Type == FieldValueType.Number);

                // TODO: Sometimes ValueInteger isn't populated in ReceiptItems.  The following is a
                // workaround to get the value from Text if ValueNumber isn't there.
                int parsedInt;
                if (int.TryParse(value.Text, out parsedInt))
                {
                    intValue = value.ValueInteger.HasValue ? value.ValueInteger.Value : parsedInt;
                }
                else
                {
                    // TODO: make this nullable!
                    intValue = value.ValueInteger.HasValue ? value.ValueInteger.Value : default;
                }
            }

            return intValue;
        }

        private static DateTimeOffset SetDateTimeOffsetValue(string fieldName, IDictionary<string, FieldValue_internal> fields)
        {
            DateTimeOffset dateTimeOffsetValue = default;

            FieldValue_internal value;
            if (fields.TryGetValue(fieldName, out value))
            {
                // TODO: Make this nullable!
                dateTimeOffsetValue = value.Type switch
                {
                    // TODO: Unsuppress
#pragma warning disable CA1305 // Specify IFormatProvider
                    FieldValueType.Date => DateTimeOffset.Parse(value.ValueDate),
                    FieldValueType.Time => DateTimeOffset.Parse(value.ValueTime),
#pragma warning restore CA1305 // Specify IFormatProvider
                    _ => throw new InvalidOperationException($"The value type {value.Type} was expected to be a Date or Time")
                };
            }

            return dateTimeOffsetValue;
        }

        private static IReadOnlyList<ExtractedReceiptItem> SetReceiptItems(IDictionary<string, FieldValue_internal> fields)
        {
            List<ExtractedReceiptItem> items = new List<ExtractedReceiptItem>();

            FieldValue_internal value;
            if (fields.TryGetValue("Items", out value))
            {
                Debug.Assert(value.Type == FieldValueType.Array);

                ICollection<FieldValue_internal> arrayValue = value.ValueArray;
                foreach (var receiptItemValue in arrayValue)
                {
                    Debug.Assert(receiptItemValue.Type == FieldValueType.Object);

                    IDictionary<string, FieldValue_internal> objectValue = receiptItemValue.ValueObject;

                    string name = SetStringValue("Name", objectValue);
                    int quantity = SetIntValue("Quantity", objectValue);
                    float totalPrice = SetFloatValue("TotalPrice", objectValue);

                    ExtractedReceiptItem item = new ExtractedReceiptItem(name, quantity, totalPrice);
                    items.Add(item);
                }
            }

            return items.AsReadOnly();
        }
    }
}

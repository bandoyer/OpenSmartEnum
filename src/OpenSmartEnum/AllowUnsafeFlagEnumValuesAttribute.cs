using System;

namespace OpenSmartEnum
{
    /// <summary>
    /// Marker attribute to indicate that a <c>SmartEnum</c> should allow unsafe flag enum values.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class AllowUnsafeFlagEnumValuesAttribute : Attribute
    {
    }
}

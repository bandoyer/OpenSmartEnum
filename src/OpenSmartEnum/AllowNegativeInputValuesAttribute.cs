using System;

namespace OpenSmartEnum
{
    /// <summary>
    /// Marker attribute used to indicate that a <c>SmartEnum</c> allows negative values.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class AllowNegativeInputValuesAttribute : Attribute
    {
    }
}

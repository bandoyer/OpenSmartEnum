using System;
using System.Collections.Generic;
using System.Text;
using OpenSmartEnum.UnitTests;
using FluentAssertions;
using Xunit;

namespace OpenSmartFlagEnum.UnitTests
{
    public class SmartFlagEnumImplicitValueConversion
    {
        [Fact]
        public void ReturnsValueOfGivenEnum()
        {
            var smartFlagEnum = SmartFlagTestEnum.One;

            int result = smartFlagEnum;

            result.Should().Be(smartFlagEnum.Value);
        }
    }
}

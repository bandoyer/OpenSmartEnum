using System;
using System.Collections.Generic;
using System.Text;
using OpenSmartEnum.UnitTests;
using FluentAssertions;
using Xunit;

namespace OpenSmartFlagEnum.UnitTests
{
    public class SmartFlagEnumExplicitConversion
    {
        [Fact]
        public void ReturnsFirstEnumResultFromGivenValue()
        {
            int value = 3;

            var result = (SmartFlagTestEnum) value;

            result.Should().BeSameAs(SmartFlagTestEnum.One);
        }

        [Fact]
        public void ReturnsFirstEnumResultFromGivenValueV2()
        {
            int value = 10;

            var result = (SmartFlagTestEnum) value;

            result.Should().BeSameAs(SmartFlagTestEnum.Two);
        }

        [Fact]
        public void ReturnsFirstEnumResultFromGivenNullableValue()
        {
            int? value = 3;

            var result = (SmartFlagTestEnum) value;

            result.Should().BeSameAs(SmartFlagTestEnum.One);
        }

        [Fact]
        public void ReturnsEnumFromGivenNullableValueAsNull()
        {
            int? value = null;

            var result = (SmartFlagTestEnum) value;

            result.Should().BeNull();
        }
    }
}

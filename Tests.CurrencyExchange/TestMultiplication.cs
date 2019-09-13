using System;
using FluentAssertions;
using TDDByExample.CurrencyExchange;
using Xunit;

namespace Tests.CurrencyExchange
{
    public class DollarTests
    {
        [Fact]
        public void TestMultiplication()
        {
            var five = new Dollar(5);
            var product = five.Times(2);
            product.Amount.Should().Be(10);
        }

        [Fact]
        public void TestEquality()
        {
            var dollar1 = new Dollar(5);
            var dollar2 = new Dollar(5);
            dollar1.Equals(dollar2).Should().Be(true);
        }
    }
}

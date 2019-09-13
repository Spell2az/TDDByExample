using FluentAssertions;
using TDDByExample.CurrencyExchange;
using Xunit;

namespace Tests.CurrencyExchange
{
    public class DollarTests
    {

        //$5 + 10CHF = $10 if rate is 2:1
        //Money rounding
        //Make amount private
        //Dollar side effects
        //equals
        //hashcode
        //equal null
        //equal object
        //5chf * 2 = 10chf
        //Franc dollar duplication
        //common equals
        //common times
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

        [Fact]
        public void TestFrancMultiplication()
        {
            var franc = new Franc(5);
            var product = franc.Times(2);
            product.Amount.Should().Be(10);
        }

    }
}

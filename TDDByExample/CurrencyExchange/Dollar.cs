using System;
using System.Collections.Generic;
using System.Text;

namespace TDDByExample.CurrencyExchange
{
    public class Dollar : IEquatable<Dollar>
    {
        public readonly decimal Amount;

        public Dollar(decimal amount)
        {
            this.Amount = amount;
        }

   

        public Dollar Times(int multiplier) => new Dollar(Amount*multiplier);

        public bool Equals(Dollar other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Amount == other.Amount;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Dollar) obj);
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode();
        }
    }
}

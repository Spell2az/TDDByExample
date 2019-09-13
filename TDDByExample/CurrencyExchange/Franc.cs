using System;

namespace TDDByExample.CurrencyExchange
{

    public class Franc : IEquatable<Franc>
    {
        public readonly decimal Amount;

        public Franc(decimal amount)
        {
            this.Amount = amount;
        }

        public Franc Times(int multiplier) => new Franc(Amount * multiplier);

        public bool Equals(Franc other)
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
            return Equals((Franc) obj);
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode();
        }
    }
}
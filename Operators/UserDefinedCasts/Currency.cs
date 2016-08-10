using System;
using System.CodeDom;

namespace UserDefinedCasts
{
    public struct Currency
    {
        public uint Dollars;
        public ushort Cents;

        public Currency(uint dollars, ushort cents)
        {
            this.Dollars = dollars;
            this.Cents = cents;
        }

        public override string ToString()
        {
            return string.Format("${0}.{1,-2:00}", Dollars, Cents);
        }

        public static implicit operator float(Currency val)
        {
            return val.Dollars + (val.Cents/100.0f);
        }

        public static explicit operator Currency(float value)
        {
            checked
            {
                uint dollars = (uint)value;
                ushort cents = Convert.ToUInt16((value - dollars) * 100);
                return new Currency(dollars, cents);
            }
        }
    }
}
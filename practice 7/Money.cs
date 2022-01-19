using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_7
{
    class Money : Pair
    {
        public Money(int rubles, int kopecks) : base(rubles, kopecks)
        {
            Rubles = rubles;
            Kopecks = kopecks;
        }

        public int Rubles { get; set; }
        public int Kopecks { get; set; }

        public Money Sum(Money money)
        {
            return new Money(Rubles + money.Rubles, Kopecks + money.Kopecks);
        }

        public Money Minus(Money money)
        {
            return new Money(Rubles - money.Rubles, Kopecks - money.Kopecks);
        }

        public Money Divide(Money money)
        {
            return new Money(Rubles / money.Rubles, Kopecks / money.Kopecks);
        }
    }
}

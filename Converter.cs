using System;

namespace Laba1
{
    class Converter
    {
        public double USDRate { get; private set; }
        public double EURRate { get; private set; }
        public double PLNRate { get; private set; }

        public Converter(double usd, double eur, double pln)
        {
            USDRate = usd;
            EURRate = eur;
            PLNRate = pln;
        }

        public double ConvertToUSD(double uah)
        {
            return uah / USDRate;
        }

        public double ConvertToEUR(double uah)
        {
            return uah / EURRate;
        }

        public double ConvertToPLN(double uah)
        {
            return uah / PLNRate;
        }

        public double ConvertFromUSD(double usd)
        {
            return usd * USDRate;
        }

        public double ConvertFromEUR(double eur)
        {
            return eur * EURRate;
        }

        public double ConvertFromPLN(double pln)
        {
            return pln * PLNRate;
        }
    }
}
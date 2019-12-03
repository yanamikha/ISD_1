using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter convert = new Converter(0.5, 0.2, 0.00001);
            double money = 25;
            Console.WriteLine($"{money} uah: {convert.ToUSD(money)} usd");
            Console.WriteLine($"{money} uah: {convert.ToEUR(money)} eur");
            Console.WriteLine($"{money} uah: {convert.ToRUB(money)} rub");
            Console.WriteLine($"{money} usd: {convert.FromUSD(money)} uah");
            Console.WriteLine($"{money} eur: {convert.FromEUR(money)} uah");
            Console.WriteLine($"{money} rub: {convert.FromRUB(money)} uah");
        }
    }
    class Converter
    {
        double usd;
        double eur;
        double rub;
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public double ToUSD(double currency)
        {
            return currency /= usd;
        }
        public double ToEUR(double currency)
        {
            return currency /= eur;
        }
        public double ToRUB(double currency)
        {
            return currency /= rub;
        }
        public double FromUSD(double currency)
        {
            return currency *= usd;
        }
        public double FromEUR(double currency)
        {
            return currency *= eur;
        }
        public double FromRUB(double currency)
        {
            return currency *= rub;
        }
    }
}

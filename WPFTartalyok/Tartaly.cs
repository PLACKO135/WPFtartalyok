using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok

{
    public class Tartaly
    {
        string nev;
        int a, b, c;
        double aktLiter;

        

        public Tartaly(string nev, int a, int b, int c)
        {
            this.nev = nev;
            this.a = a;
            this.b = b;
            this.c = c;
            this.aktLiter = 0;
        }

        public Tartaly(String nev)
        {
            this.nev = nev;
            this.a = 10;
            this.b = 10;
            this.c = 10;
            this.aktLiter = 0;
        }



        public double Terfogat
        {
            get { return this.a * this.b * this.c; }
        }


        public void DuplazMeretet()
        {
            this.a *= 2;
        }

        public void TeljesLeengedes()
        {
            this.aktLiter = 0;
        }

        

        public double Toltottseg
        {
            get => (this.aktLiter * 1000 / Terfogat) * 100;
        }
        public string Nev { get => nev; }
        public int aEl { get => a; }
        public int bEl { get => b; }
        public int cEl { get => c; }
        public double AktLiter { get => aktLiter; }

 

        public void Tolt(double mennyit)
        {

            if (Terfogat / 1000 < this.aktLiter + mennyit)
            {
                
                throw new OverflowException();
                
            }
            this.aktLiter += mennyit;
        }


        public string Info()
        {
            return $"{this.Nev}: {this.Terfogat:n1} cm3 = ({this.Terfogat / 1000:n2} liter)," +
                $" töltöttsége: {this.Toltottseg:n2}%, ({this.aktLiter:n2} liter)," +
                $" méretei: {this.a}x{this.b}x{this.c} cm";

           

        }
    }
}
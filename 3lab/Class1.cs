using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3lab
{
    public class Mebli
    {

        protected string nazva = "";

        public Mebli(string nazvaa) { 
        
        this.nazva = nazvaa;

        }

        public virtual double CCost()
        {
            return 0;
        }

        public string GetNazva()
        {
            return nazva;
        }

    }

    public class Shafa : Mebli
    {

        double V = 0;

        public Shafa(double V,string nazvaa) : base(nazvaa) {    
        
        this.V = V;

        }

        public override double CCost()
        {

            return 75.0 * V;

        }

       

    }

    public class Divan : Mebli
    {

        double S = 0;

        public Divan(double S, string nazvaa) : base(nazvaa)
        {

            this.S = S;

        }

        public override double CCost()
        {

            return (Math.Pow(S, 2.0)/3) + 5000;

        }

    }
}

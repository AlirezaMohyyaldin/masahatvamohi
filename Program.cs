using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masahat_va_mohit
{
    internal class cercle
    {
        private double cerc;

        public double Cerc
        { get { return cerc; } set {  cerc = value; } }
        public cercle() { }
        public cercle(double cerc)
        {
            cerc = Cerc;
        }
        public double masahat()
        {
            double m = Math.Pow(cerc, 2) * 3.14;
                return m; 
        }
        public double mohit()
        {
            double n = (cerc * 2) * 3.14;
            return n;
                }
    }
    internal class moraba
    {
        private double mora;

        public double Mora { get {  return mora; } set {  mora = value; } }
        public moraba() { }
        public moraba(double mora) 
        {
            mora = Mora;
        }
        public double masahat()
        {
            double b = Math.Pow(mora, 2);
            return b;
        }
        public double mohit() 
        {
            double n = mora * 4;
            return n;
        }
    }
    internal class mosalas
    {
        private double mora;
        private double mosa;
        private double w;
        private double n;
        private double m;
        public double Mosa
        {
            get { return mosa; }
            set { Mosa = value; }
        }
        public double Mora
        {
            get { return mora; }
            set { mora = value; }
        }
        public double W
        {
            get { return w; }
            set { w = value; }
        }
        public double N
        {
            get { return n; }
            set { n = value; }
        }
        public double M
        {
            get { return m; }
            set { m = value; }
        }
        public mosalas() { }
        public mosalas(double mosa , double mora ,double w ,double n,double m)
        {
            mosa = Mosa;
            mora = Mora;
            w = W;
            n = N;
            m = M;
        }
        public double masahat()
        {
            double m = mosa * mora;
            return m;
        }
       public double mohit()
        {
            double g= m + n + w;
            return g;
        }
    }
                    //baraye harkodomesh bayad class benevesi 
        public class test
        {
            static void Main(string[] args)
            {
                Console.WriteLine("enter your number you choise calculate it");
                Console.WriteLine("1 = masahat va mohit cercle");
                Console.WriteLine("2 = masahat va mohit moraba");
                Console.WriteLine("3 = masahat va mohit mosalas");
                Console.WriteLine("4 = masahat va mohit lozy");
                Console.WriteLine("5 = masahat va mohit zozanaghe");
                int d = Convert.ToInt32(Console.ReadLine());
                if (d == 1)
                {
                Console.WriteLine("enter shoa cercle :");
                double r = Convert.ToDouble(Console.ReadLine());
                    cercle c = new cercle(r);
                    Console.WriteLine(c.masahat());
                Console.WriteLine(c.mohit());
                }
               else if(d == 2)
            {
                Console.WriteLine("enetr zelhe moraba:");
                double w = Convert.ToDouble(Console.ReadLine());
                moraba v = new moraba(w);
                Console.WriteLine(v.masahat());
                Console.WriteLine(v.mohit());
            }
                else if( d == 3)
            {
                Console.WriteLine("enter ghaeede va ertefah mosalas");
                Console.WriteLine(" se zele mosalas vared konid");
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                double z = Convert.ToDouble(Console.ReadLine());
                double w = Convert.ToDouble(Console.ReadLine()); 
                double f  = Convert.ToDouble(Console.ReadLine());
                mosalas s = new mosalas(x, y, z, w, f);
                Console.WriteLine(s.masahat());
                Console.WriteLine(s.mohit());
            }
            }
        }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a,b,c: ");
            double a210 = Int32.Parse(Console.ReadLine());
            double b210 = Int32.Parse(Console.ReadLine());
            double c210 = Int32.Parse(Console.ReadLine());
            ptb2 pt = new ptb2(a210,b210,c210);

            double delta = pt.delta(a210, b210, c210);
            int check210 = pt.nghiem(delta);
            if(check210 < 0)
            {
                Console.WriteLine("Pt vo nghiem");
            } else if (check210 == 0)
            {
                double x = -b210 / (2 * a210);
                Console.WriteLine("pt co nghiem kep: ", x);
            } else
            {
                double x1 = (-b210 - Math.Sqrt(delta)) / (2 * a210);
                double x2 = (-b210 + Math.Sqrt(delta)) / (2 * a210);

                Console.WriteLine("Pt co 2 nghiem x1={0} , x2={1}: ", x1, x2);
            }
        }
    }
     
    class ptb2
    {
        private double a210;
        private double b210;
        private double c210;

        public ptb2()
        {
        }

        public ptb2(double a210, double b210, double c210)
        {
            A = a210;
            B = b210;
            C = c210;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double delta(double a210, double b210, double c210)
        {
            return b210 * b210 - 4 * a210 * c210;
        }

        public int nghiem(double delta210)
        {
            if(delta210 < 0)  {
                return -1;
            } else if (delta210 == 0)
            {
                return 0;
            } else
            {
                return 1;
            }
        }
    }
}

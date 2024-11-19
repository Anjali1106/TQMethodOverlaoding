using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverlaoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculation c = new Calculation();

            //Console.WriteLine("---------- add ---------");
            //Console.WriteLine(c.Add(5, 5));
            //Console.WriteLine(c.Add(2, 4, 6));
            //Console.WriteLine(c.Add(5, 5.4));
            //Console.WriteLine(c.Add(2.5, 5));


            //Console.WriteLine("---------- sub ---------");
            //Console.WriteLine(c.Sub(10, 5));
            //Console.WriteLine(c.Sub(10.5, 5.5));
            //Console.WriteLine(c.Sub(15, 5.2));
            //Console.WriteLine(c.Sub(10.2, 3));


            //Console.WriteLine("---------- Mul ---------");
            //Console.WriteLine(c.Mul(5, 5));
            //Console.WriteLine(c.Mul(2, 4.2));
            //Console.WriteLine(c.Mul(5.3, 5.4));
            //Console.WriteLine(c.Mul(2.5, 5));


            //Console.WriteLine("---------- Div ---------");
            //Console.WriteLine(c.Div(15, 5));
            //Console.WriteLine(c.Div(12.2, 4.2));
            //Console.WriteLine(c.Div(5.4, 5));
            //Console.WriteLine(c.Div(15, 5.5));


            //Employee e1 = new Employee(1, "Nilesh", 30000);
            //Console.WriteLine(e1.Display());
            //Employee e2 = new Employee();
            //Console.WriteLine(e2.Display());


            Payment p = new Payment();
            p.payBill(1222);
            p.payBill(4000, "Onl");



        }
    }
}

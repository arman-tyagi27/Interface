using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProg
{
    class Reactangle
    {
        protected double length;
        protected double width;

        public Reactangle(double l, double w)
        {
            length = 1;
            width = w;
        }
        public double GetArea()
        {
            return length * width;
        }
        
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }


    class Table: Reactangle
    {
        private double cost;
        public Table(double l, double w) : base(l, w) { }

        public double GetCost()
        {
            double cost;
            cost = GetArea() * 70;
            return cost;
        }

        public void dislplay()
        {
            base.Display();
            Console.WriteLine("Cost: {0}", GetCost());
        }

    }
    class ExecuteRectangle
    {
        //static void Main(string[] args)
        //{
        //    Table t = new Table(5.5, 7.8);
        //    t.Display();
        //    Console.ReadLine();
        //}
    }
}

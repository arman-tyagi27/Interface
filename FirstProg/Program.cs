using System;
using System.Collections;

namespace FirstProg
{
    interface IProgrammingLang
    {
        void languages();
    }

    class Languages : IProgrammingLang
    {
        public void languages()
        {
            ArrayList my_list = new ArrayList();

            my_list.Add("C");
            my_list.Add("C++");
            my_list.Add("C#");
            my_list.Add("Python");

            Console.WriteLine("Programming languages provided:- ");
            foreach (var elements in my_list)
            {
                Console.WriteLine(elements);
            }
        }
    }

    interface ICourses
    {
        void courses();
    }

    class Courses : ICourses
    {
        public void courses()
        {
            ArrayList my_list = new ArrayList();

            my_list.Add("System Design");
            my_list.Add("Solid Principles");
            my_list.Add("Unit Design");
            my_list.Add("Web Development");

            Console.WriteLine("\nCourses provided:- ");
            foreach (var elements in my_list)
            {
                Console.WriteLine(elements);
            }
        }
    }

    class GFG : IProgrammingLang
    {
        Languages obj1 = new Languages();
        Courses obj2 = new Courses();

        public void languages()
        {
            obj1.languages();
        }

    }
    class GFG1: ICourses
    {
        Courses obj2 = new Courses();

        public void courses()
        {
            obj2.courses();
        }
    }



    class Program
    {
        static void Main()
        {
            GFG obj1 = new GFG();
            GFG1 obj2 = new GFG1();
            obj1.languages();
            obj2.courses();
        }

    }
}


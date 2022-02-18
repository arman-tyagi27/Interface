using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FirstProg
{
    class Languages
    {
        public void LanguagesNames()
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
}

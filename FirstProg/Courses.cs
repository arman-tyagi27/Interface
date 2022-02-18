using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FirstProg
{
    class Courses
    {
        public void CoursesName()
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
}

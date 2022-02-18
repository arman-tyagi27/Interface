using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProg
{
    class GFG: IProggrammingLanguage, ICourses
    {
        
        Languages obj1 = new Languages();
        Courses obj2 = new Courses();

        public void Languages()
        {
            obj1.LanguagesNames();
        }

        public void CoursesName()
        {
            obj2.CoursesName();
        }
    }
}


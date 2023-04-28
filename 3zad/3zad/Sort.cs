using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3zad
{
    public class StudentComparerByName : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                Student s1 = (Student)x;
                Student s2 = (Student)y;
                return string.Compare(s1.FirstName, s2.FirstName);
            }
            else
            {
                throw new ArgumentException("");
            }
        }
    }
}

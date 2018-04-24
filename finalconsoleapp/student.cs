using System;
using System.Collections.Generic;
using System.Text;

namespace finalconsoleapp
{
    class Student:Person
    {
        public DateTime EnrollDate { get; set; }

        public string Major { get; set; }


        //read only
        public string StudentName
        {
            get
            {
                return FirstName + " " + LastName + "   ";
            }
        }
        //im better than you, like way better


    }
}

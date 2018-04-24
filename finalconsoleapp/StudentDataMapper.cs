using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace finalconsoleapp
{
    class StudentDataMapper : IDataMapper<Student>
    {
        private string path;
        public StudentDataMapper()
        {
            path = AppDomain.CurrentDomain.BaseDirectory + "Students.txt";
        }

        private List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            if (File.Exists(path))
            {
                var sr = new StreamReader(path);
                string line;

                while((line = sr.ReadLine()) != null)
                {
                    var elems = line.Split(',');
                    var student = new Student
                    {
                        ID = Int16.Parse(elems[0]),
                        FirstName = elems[1],
                        LastName = elems[2],
                        Address = elems[3],
                        City = elems[4],
                        Province = elems[5],
                        PostalCode = elems[6],
                        Phone = elems[7],
                        Email = elems[8],
                        EnrollDate = DateTime.Parse(elems[9]),
                        Major = elems[10]
                    };
                    students.Add(student);
                }
            }

            return students;
        }
        public List<Student> Find(string LastName)
        {
            var searchStudents = GetStudents();

            return searchStudents.Where(s => s.LastName.Contains(LastName)).ToList();
        }

        public List<Student> Select()
        {
            return GetStudents();
        }
    }
}

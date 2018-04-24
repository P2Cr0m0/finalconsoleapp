using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace finalconsoleapp
{
    class InstructorDataMapper : IDataMapper<Instructor>
    {
        private string path;
        public InstructorDataMapper()
        {
            path = AppDomain.CurrentDomain.BaseDirectory + "Instructors.txt";
        }

        private List<Instructor> GetInstructors()
        {
            List<Instructor> instructors = new List<Instructor>();

            if (File.Exists(path))
            {
                var sr = new StreamReader(path);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    var elems = line.Split(',');
                    var Instructor = new Instructor
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
                        HireDate = DateTime.Parse(elems[9]),
                    };
                    instructors.Add(Instructor);
                }
            }

            return instructors;
        }
        public List<Instructor> Find(string LastName)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> Select()
        {
            return GetInstructors();
        }
    }
}

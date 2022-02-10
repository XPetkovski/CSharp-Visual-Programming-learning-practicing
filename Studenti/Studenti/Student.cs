using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenti
{
    public class Student
    {
        public string Ime { get; set; }
        public string Index { get; set; }
        public List<Student> studenti { get; set; }

        public Student(string Ime = "", string Index = "")
        {
            this.Ime = Ime;
            this.Index = Index;
            this.studenti = new List<Student>();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Ime, Index);
        }
    }
}

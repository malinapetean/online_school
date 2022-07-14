using Online_school_library.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Online_school_library.Controllers
{
    public class ControllerEnrolment
    {
        private List<Enrolment> enrolments;

        public ControllerEnrolment()
        {
            enrolments = new List<Enrolment>();

            this.load();

        }
        public void load()
        {

            this.enrolments.Clear();
            StreamReader r = new StreamReader(@"D:\mycode\csharp\Mostenirea\Online_school-library\Online_school-library\Resources\enrolments.txt");
            string text = "";
            while ((text = r.ReadLine()) != null)
            {
                this.enrolments.Add(new Enrolment(text));
            }
            r.Close();

        }

        public void display()
        {
            foreach (Enrolment e in enrolments)
                Console.WriteLine(e.description());

        }
        public string toSave()
        {
            string text = "";
            foreach (Enrolment e in enrolments)
            {
                text += e.toSave() + "\n";
            }
            return text;
        }
        public void save()
        {
            StreamWriter write = new StreamWriter(@"D:\mycode\csharp\Mostenirea\Online_school-library\Online_school-library\Resources\enrolments.txt");
            write.Write(this.toSave());
            write.Close();
        }
    }
}

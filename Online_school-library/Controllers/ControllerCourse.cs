using Online_school_library.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Online_school_library.Controllers
{
    public class ControllerCourse
    {
        private List<Course> courses;
        private List<Enrolment> enr;

        public ControllerCourse()
        {
            courses = new List<Course>();
            enr = new List<Enrolment>();
            this.load();
        }
        public void load()
        {
            StreamReader read = new StreamReader(@"D:\mycode\csharp\Mostenirea\Online_school-library\Online_school-library\Resources\courses.txt");
            string txt = "";

            this.courses.Clear();
            while ((txt = read.ReadLine()) != null)
            {
                this.courses.Add(new Course(txt));
            }
            read.Close();
        }
        public void display()
        {
            foreach (Course c in courses)
            {
                Console.WriteLine(c.description());
            }
        }
        public String toSave()
        {
            String text = "";
            foreach (Course c in courses)
            {
                text += c.toSave() + "\n";
            }
            return text;
        }
        public void save()
        {
            StreamWriter write = new StreamWriter(@"D:\mycode\csharp\Mostenirea\Online_school-library\Online_school-library\Resources\courses.txt");
            write.Write(this.toSave());
            write.Close();
        }
        public List<Course> getAll()
        {
            return this.courses;
        }
        public int nextId()
        {
            int nr = courses.Count;
            return courses[nr - 1].Id + 1;
        }

        private bool existence(Course c)
        {
            foreach (Course course in courses)
            {
                if (course.Id.Equals(c.Id))
                    return true;
            }
            return false;
        }
        public bool addCourse(Course c)
        {
            if (existence(c) == false)
            {
                this.courses.Add(c);
                return true;
            }
            return false;
        }
    }
}

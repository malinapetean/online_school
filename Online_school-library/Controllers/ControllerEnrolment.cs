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
            StreamReader r = new StreamReader(@"D:\mycode\csharp\projects\Online_school-library\Online_school-library\Resources\enrolments.txt");
            string text = "";
            while ((text = r.ReadLine()) != null)
            {
                this.enrolments.Add(new Enrolment(text));
            }
            r.Close();

        }

        public void display(List<Enrolment> list)
        {
            foreach (Enrolment e in list)
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
            StreamWriter write = new StreamWriter(@"D:\mycode\csharp\projects\Online_school-library\Online_school-library\Resources\enrolments.txt");
            write.Write(this.toSave());
            write.Close();
        }
        public bool exist(Enrolment e)
        {
            foreach(Enrolment enr in enrolments)
            {
                if(enr.Student_Id.Equals(e.Student_Id)&& enr.Course_Id.Equals(e.Course_Id))
                {
                    return true;
                }
            }
            return false;
        }
        public bool existence(Student s, Course c)
        {
            foreach(Enrolment e in enrolments)
            {
                if(e.Course_Id.Equals(c.Id) && e.Student_Id.Equals(s.Id))
                {
                    return true;
                }
            }
            return false;
        }

        public List<Enrolment> enrolledCourses(Student s)
        {
            List<Enrolment> list = new List<Enrolment>();
            foreach(Enrolment e in enrolments)
            {
                if(e.Student_Id.Equals(s.Id))
                {
                    list.Add(e);
                }

            }
            return list;

        }
        public bool addEnroll(Enrolment e)
        {
            if(exist(e)==false)
            {
                this.enrolments.Add(e);
                return true;
            }
            return false;
        }
        public int getEnrolment(int studentID, int courseID)
        {
            foreach(Enrolment e in enrolments)
            {
                if(e.Student_Id.Equals(studentID) && e.Course_Id.Equals(courseID))
                {
                    return e.Enrolment_Id;

                }
            }
            return 0;
        }

        public void deleteEnroll(Student s, Course c)
        {
            for(int i=0;i<enrolments.Count;i++)
            {
                if(enrolments[i].Enrolment_Id.Equals(getEnrolment(s.Id,c.Id)))
                {
                    enrolments.RemoveAt(i);
                }
            }
            this.save();
        }
        public int nextId()
        {
            int nr = enrolments.Count;
            return enrolments[nr - 1].Enrolment_Id + 1;
        }
    }
}

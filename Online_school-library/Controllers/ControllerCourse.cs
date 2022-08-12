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
            courses.Clear();
            StreamReader read = new StreamReader(@"D:\mycode\csharp\projects\Online_school-library\Online_school-library\Resources\courses.txt");
            string txt = "";

            this.courses.Clear();
            while ((txt = read.ReadLine()) != null)
            {
                this.courses.Add(new Course(txt));
            }
            read.Close();
        }
        public void display(List<Course> list)
        {
            foreach (Course c in list)
            {
                Console.WriteLine(c.description());
            }
        }
        public override string ToString()
        {
            String text = "";
            foreach (Course c in courses)
            {
                text += c.ToString() + "\n";
            }
            return text;
        }
        public void save()
        {
            StreamWriter write = new StreamWriter(@"D:\mycode\csharp\projects\Online_school-library\Online_school-library\Resources\courses.txt");
            write.Write(this);
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
        public Course getCourseByID(int id)
        {
            foreach (Course c in courses)
            {
                if (c.Id.Equals(id))
                {
                    return c;
                }
            }
            return null;
        }
        public void updateCourse(Course course)
        {
            foreach (Course c in courses)
            {
                if (c.Id.Equals(course.Id))
                {
                    c.Name=course.Name;
                    c.Department=course.Department;
                    c.Detalis=course.Detalis;
                    
                }
            }
            this.save();
        }
        public List<Course> subscribedCouses(List<Enrolment> list)
        {
            List<Course> courseList = new List<Course>();
            foreach (Enrolment e in list)
            {
                courseList.Add(getCourseByID(e.Course_Id));
            }
            return courseList;
        }
        public List<Course> myCourses(User u)
        {
            List<Course> courselist = new List<Course>();
            foreach(Course c in courses)
            {
                if(c.TeacherID.Equals(u.Id))
                {
                    courselist.Add(c);
                }
            }
            return courselist;
        }
        public void delete(Course c)
        {

            this.courses.Remove(c);
            this.save();
        }
    }
}

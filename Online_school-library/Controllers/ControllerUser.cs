using Online_school_library.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Online_school_library.Controllers
{
    public class ControllerUser
    {
        private List<User> students;
        public ControllerUser()
        {
            students = new List<User>();
            this.load();
        }
        public void load()
        {
            StreamReader read = new StreamReader(@"D:\mycode\csharp\projects\Online_school-library\Online_school-library\Resources\students.txt");
            string txt = "";
            while ((txt = read.ReadLine()) != null)
            {
                switch(txt.Split(",")[0])
                {
                    case "student":
                        students.Add(new Student(txt));
                        break;
                    case "teacher":
                        students.Add(new Teacher(txt));
                        break;
                }
            }
            read.Close();
        }
        public void display()
        {
            foreach (User s in students)
            {
                Console.WriteLine(s.description());
            }
        }
        public String toSave()
        {
            String text = "";
            foreach (User s in students)
            {
                text += s.toSave() + "\n";
            }
            return text;
        }
        public void save()
        {
            StreamWriter write = new StreamWriter(@"D:\mycode\csharp\projects\Online_school-library\Online_school-library\Resources\students.txt");
            write.Write(this.toSave());
            write.Close();
        }

        public bool exist(User s)
        {
            foreach(User u in students)
            {
                if(u.Id.Equals(s.Id))
                {
                    return true;
                }
            }
            return false;
        }
        public bool Add(User s)
        {
            if(exist(s)==false)
            {
                this.students.Add(s);
                return true;
            }
            return false;
        }

    }
}

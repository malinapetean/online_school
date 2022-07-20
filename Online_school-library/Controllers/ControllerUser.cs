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
            StreamReader read = new StreamReader(@"D:\mycode\csharp\Mostenirea\Online_school-library\Online_school-library\Resources\students.txt");
            string txt = "";
            while ((txt = read.ReadLine()) != null)
            {
                this.students.Add(new User(txt));
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
            StreamWriter write = new StreamWriter(@"D:\mycode\csharp\Mostenirea\Online_school-library\Online_school-library\Resources\students.txt");
            write.Write(this.toSave());
            write.Close();
        }


    }
}

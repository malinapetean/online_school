using System;
using System.Collections.Generic;
using System.Text;

namespace Online_school_library.Models
{
    public class Student:User
    {
        private int age;

        public Student(string txt):base(txt)
        {
            this.age = int.Parse(txt.Split(",")[6]);

        }
        public int Age
        {
            get => this.age;
            set => this.age = value;

        }
        public override string description()
        {
            string txt = "";
            txt += "Type: " + this.Tip + "\n";
            txt += "Id: " + this.Id + "\n";
            txt += "First name: " + this.First_Name + "\n";
            txt += "Last name: " + this.Last_Name + "\n";
            txt += "Email: " + this.Email + "\n";
            txt += "Parola: " + this.Password + "\n";
            txt += "Age: " + this.age + "\n";
            return txt;
        }

        public override string ToString()
        {
            string text = "";
            text += this.Tip + "," + this.Id + "," + this.First_Name + "," + this.Last_Name + "," + this.Email + "," + this.Password + "," + this.age;
            return text;
        }
        public override bool Equals(object obj)
        {
            Student s = obj as Student;

            return this.Id == s.Id;
        }
    }
}

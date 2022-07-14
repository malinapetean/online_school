using System;
using System.Collections.Generic;
using System.Text;

namespace Online_school_library.Models
{
    public class Student
    {

        private int id;
        private string firstName = "";
        private string lastName = "";
        private string email = "";
        private string password = "";
        private int age;

        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public string First_Name
        {
            get => this.firstName;
            set => this.firstName = value;
        }
        public string Last_Name
        {
            get => this.lastName;
            set => this.lastName = value;
        }
        public string Email
        {
            get => this.email;
            set => this.email = value;
        }
        public string Password
        {
            get => this.password;
            set => this.password = value;
        }
        public int Age
        {
            get => this.age;
            set => this.age = value;
        }
        public string description()
        {
            string txt = "";
            txt += "Id: " + this.id + "\n";
            txt += "First name: " + this.firstName + "\n";
            txt += "Last name: " + this.lastName + "\n";
            txt += "Email: " + this.email + "\n";
            txt += "Parola:" + this.password + "\n";
            txt += "Age: " + this.age + "\n";
            return txt;
        }
        public Student(string p)
        {
            this.id = int.Parse(p.Split(",")[0]);
            this.firstName = p.Split(",")[1];
            this.lastName = p.Split(",")[2];
            this.email = p.Split(",")[3];
            this.password = p.Split(",")[4];
            this.age = int.Parse(p.Split(",")[5]);

        }
        public string toSave()
        {
            string text = "";
            text += this.id + "," + this.firstName + "," + this.lastName + "," + this.email + "," + this.password + "," + this.age;
            return text;
        }
    }
}

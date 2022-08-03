using System;
using System.Collections.Generic;
using System.Text;

namespace Online_school_library.Models
{
    public class User
    {

        private int id;
        private string firstName = "";
        private string lastName = "";
        private string email = "";
        private string password = "";
        private string tip = "";

        public string Tip
        {
            get => this.tip;
            set => this.tip = value;
        }
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
       
        public virtual string description()
        {
            string txt = "";
            txt += "Type: " + this.tip + "\n";
            txt += "Id: " + this.id + "\n";
            txt += "First name: " + this.firstName + "\n";
            txt += "Last name: " + this.lastName + "\n";
            txt += "Email: " + this.email + "\n";
            txt += "Parola:" + this.password + "\n";
           
            return txt;
        }
        public User(string p)
        {
            this.tip = p.Split(",")[0];
            this.id = int.Parse(p.Split(",")[1]);
            this.firstName = p.Split(",")[2];
            this.lastName = p.Split(",")[3];
            this.email = p.Split(",")[4];
            this.password = p.Split(",")[5];
        }
        public virtual string toSave()
        {
            string text = "";
            text +=this.tip + "," + this.id + "," + this.firstName + "," + this.lastName + "," + this.email + "," + this.password;
            return text;
        }
    }
}

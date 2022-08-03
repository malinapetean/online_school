using System;
using System.Collections.Generic;
using System.Text;

namespace Online_school_library.Models
{
    class Teacher:User
    {
        private string materia = "";
        public Teacher(string txt):base(txt)
        {
            this.materia = txt.Split(",")[6];
        }

        public string Materia
        {
            get => this.materia;
            set => this.materia = value;
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
            txt += "Materia pe care o preda: " + this.materia + "\n";
            return txt;
        }
        public override string toSave()
        {
            string text = "";
            text += this.Tip + "," + this.Id + "," + this.First_Name + "," + this.Last_Name + "," + this.Email + "," + this.Password+","+this.materia;
            return text;
        }
    }
}

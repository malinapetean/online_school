using System;
using System.Collections.Generic;
using System.Text;

namespace Online_school_library.Models
{
    public class Course
    {
        private int id;
        private string name = "";
        private string department = "";
        private string details = "";

        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public string Name
        {
            get => this.name;
            set => this.name = value;

        }
        public string Department
        {
            get => this.department;
            set => this.department = value;
        }
        public string Detalis
        {
            get => this.details;
            set => this.details = value;
        }
        public string description()
        {
            string d = "";
            d += "Course id: " + this.id + "\n";
            d += "Course name: " + this.name + "\n";
            d += "Department: " + this.department + "\n";
            d += "Details: " + this.details + "\n";
            return d;
        }
        public Course(string c)
        {
            this.id = int.Parse(c.Split(",")[0]);
            this.name = c.Split(",")[1];
            this.department = c.Split(",")[2];
            this.details = c.Split(",")[3];
        }
        public Course(int id, string name, string department, string description)
        {
            this.id = id;
            this.name = name;
            this.department = department;
            this.details = description;
        }
        public string toSave()
        {
            string txt = "";
            txt += this.id + "," + this.name + "," + this.department + "," + this.details;
            return txt;
        }

        public Course()
        {

        }
    }
}

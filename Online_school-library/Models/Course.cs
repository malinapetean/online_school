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
        private int teacherID;

        public int Id
        {
            get => this.id;
            set => this.id = value;
        }
        public int TeacherID
        {
            get => this.teacherID;
            set => this.teacherID = value;
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
            d += "TeacherID: " + this.teacherID + "\n";
            return d;
        }
        public Course(string c)
        {
            this.id = int.Parse(c.Split(",")[0]);
            this.name = c.Split(",")[1];
            this.department = c.Split(",")[2];
            this.details = c.Split(",")[3];
            this.teacherID = int.Parse(c.Split(",")[4]);
        }
        public Course(int id, string name, string department, string description,int teacherID)
        {
            this.id = id;
            this.name = name;
            this.department = department;
            this.details = description;
            this.teacherID = teacherID;
        }
        public override string ToString()
        {
            string txt = "";
            txt += this.id + "," + this.name + "," + this.department + "," + this.details + "," + this.teacherID;

            return txt;
        }
        

        public override bool Equals(object obj)
        {
            Course c = obj as Course;

            return this.id == c.id;
        }
        public Course()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Online_school_library.Models
{
    public class Enrolment
    {
        private int enrolmentId;
        private int studentId;
        private int courseId;

        public int Enrolment_Id
        {
            get => this.enrolmentId;
            set => this.enrolmentId = value;
        }
        public int Student_Id
        {
            get => this.studentId;
            set => this.studentId = value;
        }
        public int Course_Id
        {
            get => this.courseId;
            set => this.courseId = value;
        }
        public string description()
        {
            string d = "";
            d += "Enrolment id: " + this.enrolmentId + "\n";
            d += "Student id: " + this.studentId + "\n";
            d += "Course id: " + this.courseId + "\n";

            return d;
        }
        public Enrolment(string e)
        {
            this.enrolmentId = int.Parse(e.Split(",")[0]);
            this.studentId = int.Parse(e.Split(",")[1]);
            this.courseId = int.Parse(e.Split(",")[2]);
        }
        public Enrolment(int enr_id, int student_id, int course_id)
        {
            this.enrolmentId = enr_id;
            this.studentId = student_id;
            this.courseId = course_id;
        }

        public override string ToString ()
        {
            string txt = "";
            txt += this.enrolmentId + "," + this.studentId + "," + this.courseId;
            return txt;
        }
        public override bool Equals(object obj)
        {
            Enrolment e = obj as Enrolment;

            return this.enrolmentId == e.enrolmentId;
        }
    }
}

using Online_school_library.Controllers;
using Online_school_library.Models;
using System;

namespace Online_school_library
{
    class Program
    {
        static void Main(string[] args)
        {
            //ControllerUser ctrl = new ControllerUser();
            Student s = new Student("student,1352,Luca,Alex,alex@yahoo.com,11234,34");
            //ctrl.Add(s);
            //ctrl.save();
            Course c = new Course(12, "Lectii", "School", "You can find everything here",112);
            ControllerEnrolment ctrlenr = new ControllerEnrolment();
            //Enrolment enr = new Enrolment(ctrlenr.nextId(), 1352, 12);
            ControllerCourse course = new ControllerCourse();
            //ctrlenr.addEnroll(enr);
            //ctrlenr.save();

            //ctrlenr.display(ctrlenr.enrolledCourses(s));
            course.display(course.subscribedCouses(ctrlenr.enrolledCourses(s)));


            //Console.WriteLine(ctrlenr.getEnrolment(s.Id, c.Id).description());
        }
    }
}

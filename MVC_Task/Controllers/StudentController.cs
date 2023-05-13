using Microsoft.AspNetCore.Mvc;
using MVC_Task.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Group = MVC_Task.Models.Group;

namespace MVC_Task.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View(GetStudents());
        }

        public IActionResult Detail(int id)
        {
            return View(GetStudentById(1, GetStudents()));

        }

        public IActionResult About()
        {
            return View(GetStudentByGroupId(2,GetStudents()));
        }

        public List<Student> GetStudents()
        {
            Student Student1 = new Student();
            Student1.Id = 1;
            Student1.FullName = "Ayaz Alakbarov";
            Student1.Age = 15;
            Student1.GroupId = 1;
         

            Student Student2 = new Student();
            Student2.Id = 2;
            Student2.FullName = "Farhad Abdullayev";
            Student2.Age = 20;
            Student2.GroupId = 2;
         

            Student Student3 = new Student();
            Student3.Id = 3;
            Student3.FullName = "Name3 XXX";
            Student3.Age = 25;
            Student3.GroupId = 2;

            Student Student4 = new Student();
            Student4.Id = 4;
            Student4.FullName = "Name3 XXX";
            Student4.Age = 25;
            Student4.GroupId = 2;


            List<Student> Students = new List<Student>();
            Students.Add(Student1);
            Students.Add(Student2);
            Students.Add(Student3);

            return Students;
        }


        private Student GetStudentById(int id, List<Student> students)
        {
            Student student = students.Find(x => x.Id == id);
            return student;
        }


        public List<Student> GetStudentByGroupId(int groupId, List<Student> students)
        {
            List<Student> extudents = students.FindAll(x => x.GroupId == groupId);
            return extudents;
        }
    }
}


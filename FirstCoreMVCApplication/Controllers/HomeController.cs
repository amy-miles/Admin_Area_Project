using FirstCoreMVCApplication.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace FirstCoreMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        //Create a Variable to Hold List of Students
        //This is going to be our data source
        private List<Student> listStudents = new List<Student>();
        public HomeController()
        {
            //Within the Constructor we are Initializing listStudents variable
            //In Real-Time, we will get the data from the database
            listStudents = new List<Student>()
            {
               new Student() { StudentId = 101, Name = "Cal", Branch = Branch.CSE, Gender = Gender.Other, Address = "A1-2018", Email = "Cal@g.com" },
               new Student() { StudentId = 102, Name = "Priyanka", Branch = Branch.ETC, Gender = Gender.Female, Address = "A1-2019", Email = "Priyanka@g.com" },
               new Student() { StudentId = 103, Name = "David", Branch = Branch.CSE, Gender = Gender.Male, Address = "A1-2020", Email = "David@g.com" },
               new Student() { StudentId = 104, Name = "Pranaya", Branch = Branch.Mech, Gender = Gender.Male, Address = "A1-2021", Email = "Pranaya@g.com" }
            };
        }
        public ViewResult Index()
        {
            //returning all the students
            return View(listStudents);
        }

        public ViewResult Details(int Id)
        {
            //returning the student based on the Student Id
            var studentDetails = listStudents.FirstOrDefault(std => std.StudentId == Id);
            return View(studentDetails);
        }

        public ViewResult Edit()
        {
            return View("Edit");
        }

        public ViewResult Delete()
        {
            return View("Delete");
        }

       
    }
}
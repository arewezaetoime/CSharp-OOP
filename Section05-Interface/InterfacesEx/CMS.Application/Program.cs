﻿using System;
using CMS.UI.Display;
using CMS.UI.Models;

namespace CMS.Application
{
    class Program
    {
        static void Main(string[] args)
        {
           IStudent student = new Student();
            student.FirstName = "Test";
            student.LastName = "testov";

            Console.WriteLine(student.GetFullName());

            Console.WriteLine(IStudent.WhoAmI());
        }
    }
}

﻿using System;

namespace CMS.UI.Models
{
    public class Student : IStudent
    {
        // Class fields
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentId = 0;

        // readonly field
        public readonly int MaxEnrolledCourses = 3;

        // Static field
        public static int MaxBooksAllowed = 6;

    
        // Student constructor
        public Student()
        {
            Console.WriteLine("Calling Student.Student()");

            // All initializations goes here. 
            int TotalCourses = 6;
            MaxEnrolledCourses = TotalCourses;
        }

        public Student(int id, string firstName, string lastName)
        {
            Console.WriteLine("Calling Student.Student(int, string, string)");

            StudentId = id;
            FirstName = firstName;
            LastName = lastName;
        }

        ~Student()
        {
            // Cleanup code goes here. 
        }

        
    }
}

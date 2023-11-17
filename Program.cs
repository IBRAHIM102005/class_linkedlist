


        using System;
        using System.Collections.Generic;

        public class Student
            {
        // Properties
                public string Name { get; set; }
                public int Age { get; set; }

        // Constructor
            public Student(string name, int age)
                {
                    Name = name;
                    Age = age;
                }

        // Method to display information about the student
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

        public class StudentLinkedList
            {
                private LinkedList<Student> students;

        // Constructor
            public StudentLinkedList()
            {
                students = new LinkedList<Student>();
            }

        // Method to add a student to the linked list
        public void AddStudent(string name, int age)
        {
            Student newStudent = new Student(name, age);
            students.AddFirst(newStudent);
        }

        // Method to display the linked list of students
        public void DisplayStudentList()
        {
            foreach (var student in students)
            {
                student.DisplayInfo();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating an instance of the StudentLinkedList class
            StudentLinkedList studentList = new StudentLinkedList();

            // Adding students to the linked list
            studentList.AddStudent("Aslan", 20);
            studentList.AddStudent("Ismayil", 22);
            studentList.AddStudent("Islam", 21);

            // Displaying the linked list of students
            Console.WriteLine("Linked List of Students:");
            studentList.DisplayStudentList();
        }
    }



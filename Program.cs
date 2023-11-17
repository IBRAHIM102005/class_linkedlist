


        using System;
        using System.Collections.Generic;

        public class Student
            {
        
                public string Name { get; set; }
                public int Age { get; set; }

        
            public Student(string name, int age)
                {
                    Name = name;
                    Age = age;
                }

        
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

        public class StudentLinkedList
            {
                private LinkedList<Student> students;

        
            public StudentLinkedList()
            {
                students = new LinkedList<Student>();
            }

        
        public void AddStudent(string name, int age)
        {
            Student newStudent = new Student(name, age);
            students.AddFirst(newStudent);
        }

        
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
            
            StudentLinkedList studentList = new StudentLinkedList();

            
            studentList.AddStudent("Aslan", 20);
            studentList.AddStudent("Ismayil", 22);
            studentList.AddStudent("Islam", 21);

            
            Console.WriteLine("Linked List of Students:");
            studentList.DisplayStudentList();
        }
    }



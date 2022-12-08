using System;

class Creators // клас розробників
{
    public struct student
    {
        public string initials;
        public int group_number;
        public string faculty;
        public string task;
    }
    student[] people;
    Creators()
    {
        people = new student[5];
       // student.initials = "Name";
       // student.group_number = 100;
       // student.faculty = "Faculty";
       // student.task = "Task";
    }
    public void Print() { }
}

using System;
using System.Collections.Generic;

namespace _07.Functional
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int FafacultyNumber { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public IList<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public Student(string firstName, string lastName, int age, int facultyNumber, int phone, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FafacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;

        }
        public static void Main()
        {
            var students = new List<Student>
               {
               new Student("Gosho","Petkov",20,2255332,088436619,"Gosho@abv.bg",new List<int>{3,5,6,2,4},2),
               new Student("Mariq","Ivanova",18,3597415,0896357417,"Mariq@abv.bg",new List<int>{2,6,6,5,6},11),
               new Student("Ana","Dimitrova",19,8534697,0885369428,"Ana@abv.bg",new List<int>{6,3,5,4,2},9),
               new Student("Ivan","Dimitrov",23,6324875,0889354715,"Ivan@abv.bg",new List<int>{3,6,5,4,2},1),
               new Student("Geri","Georgieva",21,5369554,0892354715,"Geri@abv.bg",new List<int>{3,2,5,6,4},6),
               new Student("Pesho","Peshov",20,8546541,0896325472,"Pesho@abv.bg",new List<int>{5,6,5,4,2},5)
               };
        }
    }
}
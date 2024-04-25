using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RookiesConsoleFirstDay
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Birthplace { get; set; }
        public int Age { get; set; }
        public bool IsGraduated { get; set; }

        public Member()
        {

        }

        public Member(string firstName, string lastName, string gender, DateTime dateOfBirth, string phoneNumber, string birthplace, int age, bool isGraduated)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Birthplace = birthplace;
            Age = age;
            IsGraduated = isGraduated;
        }

        public void DisplayMember()
        {
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Date of Birth: {DateOfBirth.ToString("yyyy-MM-dd")}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
            Console.WriteLine($"Birthplace: {Birthplace}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Is Graduated: {(IsGraduated ? "Yes" : "No")}");
        }

        public void DisplayFullname()
        {
            Console.WriteLine($"Full Name: {FirstName} {LastName}");
            
        }







    }

}

using System;
using System.Collections.Generic;

namespace RookiesConsoleFirstDay
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Member> members = new List<Member>();


            members.Add(new Member("John", "Doe", "Male", new DateTime(1999, 5, 15), "123-456-7890", "Ha Noi", 25, true));
            members.Add(new Member("Jane", "Smith", "Female", new DateTime(2000, 8, 25), "987-654-3210", "Ha Noi", 33, false));
            members.Add(new Member("John", "Doe", "Male", new DateTime(1999, 5, 15), "123-456-7890", "New York", 44, true));
            members.Add(new Member("Jane", "Smith", "Female", new DateTime(2001, 8, 25), "987-654-3210", "Los Angeles", 55, false));
            members.Add(new Member("John", "Doe", "Male", new DateTime(1999, 5, 15), "123-456-7890", "New York", 66, true));
            members.Add(new Member("Jane", "Smith", "Female", new DateTime(2001, 8, 25), "987-654-3210", "Los Angeles", 66, false));



            //EX 1
            foreach (Member member in members)
            {
                if (member.Gender == "Male")
                {
                    member.DisplayMember();
                    Console.WriteLine();
                }
            }

            // Ex 2
            Member oldestMeber = new Member();
            int maxAge = 0;
            foreach (Member member in members)
            {
                if (maxAge < member.Age)
                {

                    oldestMeber = member;
                    maxAge = member.Age;
                }

                if (maxAge == member.Age)
                {
                    int result = DateTime.Compare(oldestMeber.DateOfBirth, member.DateOfBirth);
                    if (result > 0)
                    {
                        oldestMeber = member;
                    }

                }

            }
            Console.WriteLine("Oldest Member:");
            oldestMeber.DisplayMember();


            // Ex 3
            //foreach (Member member in members)
            //{
            //    member.DisplayFullname();
            //}

            List<string> fullNames = new List<string>();

            foreach (Member member in members)
            {
                string fullName = $"{member.LastName} {member.FirstName}";
                fullNames.Add(fullName);
            }
            Console.WriteLine("Fullname of members:");
            foreach(string fullname in fullNames)
            {
                Console.WriteLine(fullname);
            }


            // Ex 4:
            List<Member> bornIn2000 = new List<Member>();
            List<Member> bornAfter2000 = new List<Member>();
            List<Member> bornBefore2000 = new List<Member>();

            foreach (Member member in members)
            {
                switch(member.DateOfBirth.Year - 2000)
                {
                    case 0:
                        bornIn2000.Add(member);
                        break;
                    case > 0:
                        bornAfter2000.Add(member);
                        break;
                    case < 0:
                        bornBefore2000.Add(member);
                        break;
                }
            }
            Console.WriteLine("List member born after 2000:");
            foreach (Member member in bornAfter2000) { member.DisplayMember(); }
            Console.WriteLine("List member born in 2000:");
            foreach (Member member in bornIn2000) { member.DisplayMember(); }
            Console.WriteLine("List member born brfore 2000:");
            foreach (Member member in bornBefore2000) { member.DisplayMember(); }


            // Ex 5: 
            bool check = true;
            Console.WriteLine("First member was born in Ha Noi");
            foreach (Member member in members)
            {
                while (check) if (member.Birthplace == "Ha Noi")
                    { 
                        member.DisplayMember();
                        check = false;
                    
                    }
                

                
            }
          

        }
    }
}

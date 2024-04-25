using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;

namespace RookiesConsoleFirstDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Member> members = new List<Member>();
            members.Add(new Member("John", "Doe", "Male", new DateTime(1989, 5, 15), "123-456-7890", "Ha Noi", true));
            members.Add(new Member("Jane", "Smith", "Female", new DateTime(2000, 8, 25), "987-654-3210", "Ha Noi", false));
            members.Add(new Member("Alex", "Doe", "Male", new DateTime(1979, 5, 15), "123-456-7890", "New York", true));
            members.Add(new Member("Peter", "Smith", "Female", new DateTime(2001, 8, 25), "987-654-3210", "Los Angeles", false));
            members.Add(new Member("Fake", "Doe", "Male", new DateTime(1979, 3, 15), "123-456-7890", "New York", true));
            members.Add(new Member("David", "Smith", "Female", new DateTime(2001, 8, 25), "987-654-3210", "Los Angeles", false));

            int choice;
            //UI
            Console.WriteLine("1. Return members who are Male");
            Console.WriteLine("2. Return oldest member");
            Console.WriteLine("3. Return list containing Fullname");
            Console.WriteLine("4. Return 3 lists (Born In 2000, Born After 2000 and Born before 2000)");
            Console.WriteLine("5. Return the first person who was born in Ha Noi");
            Console.WriteLine("6. Clean Screen");
            Console.WriteLine("7. Exit");
            try
            {
                do
                {
                    Console.Write("\nYour choice: ");
                    choice = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 1:
                            MaleMembers();
                            break;
                        case 2:
                            OldestMember();
                            break;
                        case 3:
                            ListMemberWithFullName();
                            break;
                        case 4:
                            ThreeListAfterBeforeAndEqual2000();
                            break;
                        case 5:
                            FirstMemberBornInHaNoi();
                            break;
                        case 6:
                            Console.Clear();
                            break;
                        case 7:
                            Console.WriteLine("\n\nSee You Again! ");
                            break;
                        default:
                            Console.WriteLine("\nWrong choice");
                            break;
                    }
                }
                while (choice != 7);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            //Male Members
            void MaleMembers()
            {
                Console.WriteLine("Members who are Male: ");
                foreach (Member member in members)
                {
                    if (member.Gender == "Male")
                    {
                        member.DisplayMember();
                        Console.WriteLine();
                    }
                }
            }

            // Oldest Member
            void OldestMember()
            {
                Member oldestMember = new Member();
                int maxAge = 0;
                foreach (Member member in members)
                {
                    if (maxAge < member.Age)
                    {
                        oldestMember = member;
                        maxAge = member.Age;
                    }
                    else if (maxAge == member.Age)
                    {
                        int result = DateTime.Compare(oldestMember.DateOfBirth, member.DateOfBirth);
                        if (result > 0)
                        {
                            oldestMember = member;
                        }
                    }
                }
                Console.WriteLine("Oldest Member:");
                oldestMember.DisplayMember();
            }

            // List Member With Full Name
            void ListMemberWithFullName()
            {
                foreach (Member member in members)
                {
                    member.DisplayFullName();
                    Console.WriteLine();
                }
            }

            // 3 List (<2000, 2000 and >2000)
            void ThreeListAfterBeforeAndEqual2000()
            {
                List<Member> bornIn2000 = new List<Member>();
                List<Member> bornAfter2000 = new List<Member>();
                List<Member> bornBefore2000 = new List<Member>();

                foreach (Member member in members)
                {
                    switch (member.DateOfBirth.Year.CompareTo(2000))
                    {
                        case 0:
                            bornIn2000.Add(member);
                            break;
                        case 1:
                            bornAfter2000.Add(member);
                            break;
                        case -1:
                            bornBefore2000.Add(member);
                            break;
                    }
                }
                Console.WriteLine("List member born after 2000:");
                foreach (Member member in bornAfter2000)
                {
                    member.DisplayMember();
                    Console.WriteLine();
                }
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("List member born in 2000:");
                foreach (Member member in bornIn2000)
                {
                    member.DisplayMember();
                    Console.WriteLine();
                }
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("List member born before 2000:");
                foreach (Member member in bornBefore2000)
                {
                    member.DisplayMember();
                    Console.WriteLine();
                }
            }

            //First Member Was Born In Ha Noi
            void FirstMemberBornInHaNoi()
            {
                Console.WriteLine("First member was born in Ha Noi");
                bool found = false;
                foreach (Member member in members)
                {
                    if (member.Birthplace == "Ha Noi")
                    {
                        member.DisplayMember();
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No member was born in Ha Noi");
                }
            }

        }
    }
}

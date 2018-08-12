using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput1;
            string userInput2;
            int userInput3;
            string userInput4;
            int userInput5;

            Console.Write("Please enter your firstname: ");
            userInput1 = Console.ReadLine();
            Console.Write("Please enter your lastname: ");
            userInput2 = Console.ReadLine();
            Console.Write("Please enter your age: ");
            userInput3 = int.Parse(Console.ReadLine());
            Console.Write("Please enter your address: ");
            userInput4 = Console.ReadLine();
            Console.Write("Please enter your phone number: ");
            userInput5 = int.Parse(Console.ReadLine());

            Person user1 = new Person(userInput1, userInput2, userInput3, userInput4, userInput5);

            Console.WriteLine(user1.GetDetails());

            List userList = new List<>( );
        }
    }
}

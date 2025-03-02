using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.VideoGameManagementSystem
{
    internal class Nintendo : Game, IGameOperation
    {
        public override void GetDetails()
        {
            if (Genre == null)
            {
                Console.WriteLine($"Name: {Name}");
            }
            else if (Year == default)
            {
                Console.WriteLine($"Name: {Name} , Genre: {Genre}");
            }
            else
            {
                Console.WriteLine($"Name: {Name} , Genre: {Genre} , Year: {Year}");
            }
        }

        public void GameCompany()
        {
            Console.WriteLine("\nLet's Go Nintendo! Now you're playing with power!");
        }

        public void AddGame()
        {
            Console.WriteLine("Adding Nintendo Game...");
        }
    }
}

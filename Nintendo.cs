using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.VideoGameManagementSystem
{
    /// <summary>
    /// Represents a Nintendo Game derived from Game, implements Get Details, Game Company, and Add Game.
    /// </summary>
    internal class Nintendo : Game, IGameOperation
    {
        /// <summary>
        /// Overrides the GetDetails Method to Display Details about Games
        /// </summary>
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

        /// <summary>
        /// Implements GameCompany() method for Nintendo
        /// </summary>
        public void GameCompany()
        {
            Console.WriteLine("\nLet's Go Nintendo! Now you're playing with power!");
        }

        /// <summary>
        /// Implements AddGame() method for Nintendo
        /// </summary>
        public void AddGame()
        {
            Console.WriteLine("Adding Nintendo Game...");
        }
    }
}

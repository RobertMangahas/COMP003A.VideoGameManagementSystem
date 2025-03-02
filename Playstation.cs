using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.VideoGameManagementSystem
{
    /// <summary>
    /// Represents a Playstation Game derived from Game, implements Get Details, Game Company, and Add Game.
    /// </summary>
    internal class Playstation : Game, IGameOperation
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
        /// Implements GameCompany() method for Playstation
        /// </summary>
        public void GameCompany()
        {
            Console.WriteLine("\nThe Sony Playstation! Play has no limits.");
        }

        /// <summary>
        /// Implements AddGame() method for Playstation
        /// </summary>
        public void AddGame()
        {
            Console.WriteLine("Adding Playstation Game...");
        }
    }
}

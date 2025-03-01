using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.VideoGameManagementSystem
{
    /// <summary>
    /// Represents a generic Game with an abstract method
    /// </summary>
    public abstract class Game
    {
        // Auto-Implemented Properties
        private string _name;
        private string _genre;
        private int _year;

        /// <summary>
        /// Gets or sets the name of the game
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Error: Name cannot be empty. Please provide a valid name.");
                }
                _name = value;
            }
        }

        /// <summary>
        /// Gets or sets the genre of the game
        /// </summary>
        public string Genre
        {
            get { return _genre; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Error: Genre cannot be empty. Please provide a valid genre.");
                }
                _genre = value;
            }
        }

        /// <summary>
        /// Gets or sets the year of publication for the game
        /// </summary>
        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 1975)
                {
                    throw new ArgumentOutOfRangeException("Error: Year cannot be less than 1975. Please provide a valid year.");
                }
                _year = value;
            }
        }

        /// <summary>
        /// An abstract method for getting Game details
        /// </summary>
        public abstract void GetDetails();
    }
}

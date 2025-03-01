using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.VideoGameManagementSystem
{
    /// <summary>
    /// Defines contracts for operatable objects.
    /// </summary>
    internal interface IGameOperation
    {
        /// <summary>
        /// Sends unique Operation message specific to each Game Company
        /// </summary>
        void GameCompany();

        /// <summary>
        /// Sends an Operation Message indicating the Addition of a Game
        /// </summary>
        void AddGame();

        /// <summary>
        /// Sends an Operation Message indicating the Editing of a Game
        /// </summary>
        void EditGame();

        /// <summary>
        /// Sends an Operation Message indicating the Deletion of a Game
        /// </summary>
        void DeleteGame();
    }
}

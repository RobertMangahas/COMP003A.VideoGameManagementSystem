/*
 * Author: Robert Mangahas
 * Course: COMP-003A
 * Faculty: Johnathan Cruz
 * Purpose: A Video Game Library Management System demonstrating the understanding of concepts learned in the past 8 weeks
 */
namespace COMP003A.VideoGameManagementSystem
{
    internal class Program
    {
        private static string name;
        private static string genre;
        private static int year;

        static void Main(string[] args)
        {
            // List to store all games into library
            List<Game> games = new List<Game>();
            int choiceMenu;
            string choiceGame;

            // Pre-Loaded Games
            Nintendo nintendoEx = new Nintendo { Name = "Pikmin" };
            games.Add(nintendoEx);
            Playstation playstationEx = new Playstation { Name = "Final Fantasy VII", Genre = "JRPG" };
            games.Add(playstationEx);
            XBox xboxEx = new XBox { Name = "Halo 3", Genre = "FPS", Year = 2007 };
            games.Add(xboxEx);

            // Greet User
            Console.WriteLine("Welcome to the Video Game Library Management System!");

            // Do-While Loop
            do
            {
                GenerateMenu();
                choiceMenu = int.Parse(Console.ReadLine());

                switch (choiceMenu)
                {
                    case 1: // Add Game
                        Console.Write("\nPlease choose Nintendo, Playstation, or XBox: ");
                        choiceGame = Console.ReadLine();
                        switch (choiceGame)
                        {
                            case "Nintendo":                                
                                GameInput();
                                // Generate New Nintendo Game
                                Nintendo nintendo = new Nintendo { Name = name, Genre = genre, Year = year };
                                games.Add(nintendo);
                                nintendo.GameCompany();
                                nintendo.AddGame();
                                Console.WriteLine("\nGame Added Successfully!");
                                break;
                            case "Playstation":
                                GameInput();
                                // Generate New Playstation Game
                                Playstation playstation = new Playstation { Name = name, Genre = genre, Year = year };
                                games.Add(playstation);
                                playstation.GameCompany();
                                playstation.AddGame();
                                Console.WriteLine("\nGame Added Successfully!");
                                break;
                            case "Xbox":
                                GameInput();
                                // Generate New XBox Game
                                XBox xbox = new XBox { Name = name, Genre = genre, Year = year };
                                games.Add(xbox);
                                xbox.GameCompany();
                                xbox.AddGame();
                                Console.WriteLine("\nGame Added Successfully!");
                                break;
                            default:
                                Console.WriteLine("\nError: Invalid Choice! Please Try Again.");
                                break;
                        }
                        break;
                    case 2: // Display All Games
                        Console.WriteLine("\nDisplaying all Games...\n");
                        foreach (Game game in games)
                        {
                            game.GetDetails();
                        }
                        break;
                    case 3: // Edit Game
                        Console.Write("\nPlease Enter the Name of the Game you want to Edit: ");
                        string gameName = Console.ReadLine();

                        Game editGame = games.Find( a => a.Name.Equals(gameName, StringComparison.InvariantCultureIgnoreCase) );
                        if (editGame != null)
                        {
                            GameInput();
                            editGame.Name = name;
                            editGame.Genre = genre;
                            editGame.Year = year;
                            Console.WriteLine("\nEditing Game...");
                            Console.WriteLine("\nGame Details Updated Successfully!");
                        }
                        else
                        {
                            Console.WriteLine("\nGame Not Found.");
                        }
                        break;
                    case 4: // Delete Game
                        Console.Write("\nPlease Enter the Name of the Game you want to Edit: ");
                        string gameDelete = Console.ReadLine();

                        Game deleteGame = games.Find(a => a.Name.Equals(gameDelete, StringComparison.InvariantCultureIgnoreCase));
                        if (deleteGame != null)
                        {
                            Console.Write($"\nPlease confirm you want to delete the game: {deleteGame}? (y/n): ");
                            string confirmDelete = Console.ReadLine();
                            if (confirmDelete.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
                            {
                                games.Remove(deleteGame);
                                Console.WriteLine("Deleting Game...");
                                Console.WriteLine("Game Deleted Successfully!");
                            }
                            else if (confirmDelete.Equals("N", StringComparison.InvariantCultureIgnoreCase))
                            {
                                Console.WriteLine("\nDeletion Cancelled.");                               
                            } 
                            else
                            {
                                Console.WriteLine("Error: Invalid Choice! Please Try Again.");                            
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nGame Not Found.");
                        }
                        break;
                    case 5: // Exit Program
                        Console.WriteLine("\nExiting the Video Game Library Management System...");
                        break;
                    default:
                        Console.WriteLine("\nInvalid Choice! Please Try Again.");
                        break;
                }
            } while (choiceMenu != 5);
        }
        /// <summary>
        /// Generates Selection Menu and Options
        /// </summary>
        static void GenerateMenu()
        {
            Console.WriteLine($"\nGame Library Management Menu:");
            Console.WriteLine($"1. Add A Game");
            Console.WriteLine($"2. Display All Games");
            Console.WriteLine($"3. Edit A Game");
            Console.WriteLine($"4. Delete A Game");
            Console.WriteLine($"5. Exit Program");
            Console.Write("Enter your choice: ");
        }
        public static void GameInput()
        {
            Console.Write("\nEnter the name of the game: ");
            name = Console.ReadLine();
            Console.Write("Enter the genre of the game: ");
            genre = Console.ReadLine();
            Console.Write("Enter the year the game was published in: ");
            year = int.Parse(Console.ReadLine());
        }
    }
}

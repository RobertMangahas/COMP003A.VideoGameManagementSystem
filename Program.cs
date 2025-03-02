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
        // Method-level variables accessible to All methods within Program
        // Allows for more condensed code
        private static string name;
        private static string genre;
        private static int year;
        private static int choiceMenu;

        static void Main(string[] args)
        {
            // List to store all games into library
            List<Game> games = new List<Game>();
            string choiceGame;

            // Pre-Loaded Games - Provides Example of Overloading
            Nintendo nintendoEx = new Nintendo { Name = "Pikmin" };
            games.Add(nintendoEx);
            Playstation playstationEx = new Playstation { Name = "Final Fantasy VII", Genre = "JRPG" };
            games.Add(playstationEx);
            XBox xboxEx = new XBox { Name = "Halo 3", Genre = "FPS", Year = 2007 };
            games.Add(xboxEx);

            // Greet User - Display Message Introducing the Program
            Console.WriteLine("Welcome to the Video Game Library Management System!");

            // Do-While Loop - Will Loop until satisfied condition of choiceMenu = 5 is met
            do
            {
                // Calls GenerateMenu() Method - Prompts User to make a choice
                GenerateMenu();
                try // Nested Try-Catch for Checking Valid Integer
                {
                    choiceMenu = int.Parse(Console.ReadLine());
                }
                catch (FormatException) // Checks if input is a valid integer
                {
                    Console.WriteLine("\nError: Please enter a valid integer.");
                }
                catch (Exception ex) // Catches extraneous exceptions that were unexpected
                {
                    Console.WriteLine($"\nUnexpected Error: {ex.Message}");
                }

                switch (choiceMenu)
                {
                    case 1: // Add Game
                        // Prompts User to Choose Between 3 Game Companies
                        Console.Write("\nPlease choose Nintendo, Playstation, or XBox: ");
                        choiceGame = Console.ReadLine();
                        switch (choiceGame)
                        {
                            case "Nintendo":  // Nintendo                              
                                GameInput();
                                // Generate New Nintendo Game
                                Nintendo nintendo = new Nintendo { Name = name, Genre = genre, Year = year };
                                games.Add(nintendo);
                                nintendo.GameCompany();
                                nintendo.AddGame();
                                Console.WriteLine("\nGame Added Successfully!");
                                break;
                            case "Playstation": // Playstation
                                GameInput();
                                // Generate New Playstation Game
                                Playstation playstation = new Playstation { Name = name, Genre = genre, Year = year };
                                games.Add(playstation);
                                playstation.GameCompany();
                                playstation.AddGame();
                                Console.WriteLine("\nGame Added Successfully!");
                                break;
                            case "Xbox": // Playstation
                                GameInput();
                                // Generate New XBox Game
                                XBox xbox = new XBox { Name = name, Genre = genre, Year = year };
                                games.Add(xbox);
                                xbox.GameCompany();
                                xbox.AddGame();
                                Console.WriteLine("\nGame Added Successfully!");
                                break;
                            default: // Default when Invalid Choice is Made
                                Console.WriteLine("\nError: Invalid Choice! Please Try Again.");
                                break;
                        }
                        break;

                    case 2: // Display All Games
                        Console.WriteLine("\nDisplaying all Games...\n");
                        foreach (Game game in games) // Calls GetDetail() Method for every game in List<Game> games
                        {
                            game.GetDetails();
                        }
                        break;

                    case 3: // Edit Game
                        // Prompts User for Name of Game to Edit
                        Console.Write("\nPlease Enter the Name of the Game you want to Edit: ");
                        string gameName = Console.ReadLine();

                        // Finds game to edit in List<Game> games
                        Game editGame = games.Find( a => a.Name.Equals(gameName, StringComparison.InvariantCultureIgnoreCase) );
                        
                        if (editGame != null) // If game is found in List<Game> games activate editing sequence
                        {
                            GameInput();
                            editGame.Name = name;
                            editGame.Genre = genre;
                            editGame.Year = year;
                            Console.WriteLine("\nEditing Game...");
                            Console.WriteLine("\nGame Details Updated Successfully!");
                        }
                        else // Else default statement if Game is null, not found, or invalid input
                        {
                            Console.WriteLine("\nGame Not Found.");
                        }
                        break;

                    case 4: // Delete Game
                        // Prompts User for Name of Game to Delete
                        Console.Write("\nPlease Enter the Name of the Game you want to Delete: ");
                        string gameDelete = Console.ReadLine();

                        // Finds game to delete in List<Game> games
                        Game deleteGame = games.Find(a => a.Name.Equals(gameDelete, StringComparison.InvariantCultureIgnoreCase));
                        
                        if (deleteGame != null) // If game is found in List<Game> games activate deletion sequence
                        {
                            // Prompts User to confirm Deletion of Game with (Y/N)
                            Console.Write($"\nPlease confirm you want to delete the game: {deleteGame}? (y/n): ");
                            string confirmDelete = Console.ReadLine();
                            if (confirmDelete.Equals("Y", StringComparison.InvariantCultureIgnoreCase)) // If input is Y delete - Ignores case sensitivity
                            {
                                games.Remove(deleteGame);
                                Console.WriteLine("Deleting Game...");
                                Console.WriteLine("Game Deleted Successfully!");
                            }
                            else if (confirmDelete.Equals("N", StringComparison.InvariantCultureIgnoreCase)) // Else if input is N cancel - Ignores case sensitivity
                            {
                                Console.WriteLine("\nDeletion Cancelled.");                               
                            } 
                            else // Else default statement if Input is Invalid
                            {
                                Console.WriteLine("Error: Invalid Choice! Please Try Again.");                            
                            }
                        }
                        else // Else default statement if Game is null, not found, or invalid input
                        {
                            Console.WriteLine("\nGame Not Found.");
                        }
                        break;

                    case 5: // Exit Program
                        // Displays an Exiting Program Message
                        Console.WriteLine("\nExiting the Video Game Library Management System...");
                        break;

                    default: // Default
                        // Displays an Invalid Choice Message
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

        /// <summary>
        /// Generates a series of input prompts for user to Add/Edit a game
        /// </summary>
        public static void GameInput()
        {
            Console.Write("\nEnter the name of the game: ");
            name = Console.ReadLine();
            Console.Write("Enter the genre of the game: ");
            genre = Console.ReadLine();
            Console.Write("Enter the year the game was published in: ");
            try // Nested Try-Catch for Checking Valid Integer
            {
                year = int.Parse(Console.ReadLine());
            }
            catch (FormatException) // Checks if input is a valid integer
            {
                Console.WriteLine("\nError: Please enter a valid integer.");
            }
            catch (Exception ex) // Catches extraneous exceptions that were unexpected
            {
                Console.WriteLine($"\nUnexpected Error: {ex.Message}");
            }
        }
    }
}

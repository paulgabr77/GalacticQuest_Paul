using GalacticQuest.Items;
using GalacticQuest.Monsters;

namespace GalacticQuest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Galactic Quest!");

            //CreateAndDisplayMonsters();

            //CreateAndDisplayPlayerStats();

            Item excalibur = new Excalibur();
            Item amulet = new ShadowAmulet();

            Console.WriteLine($"Excalibur: {excalibur.Attack} ATT, {excalibur.Health} HP");
            excalibur.SpecialPower();

            Console.WriteLine($"Shadow Amulet: {amulet.Attack} ATT, {amulet.Health} HP");
            amulet.SpecialPower();


            OpenMainMenu();
        }

        internal static void CreateAndDisplayMonsters()
        {
            Console.Write("\n");
            Console.WriteLine("Displaying Created Monsters:");

            List<Monster> monsters = new List<Monster>()
            {
                new Glorbazorg(),
                new Xenotutzi()
            };

            for (int index = 0; index < monsters.Count; ++index)
            {
                monsters[index].OnDeath();
            }
        }

        private static void CreateAndDisplayPlayerStats()
        {
            Console.Write("\n");

            List<(string, int)> items = new List<(string, int)>() { ("Excalibur", 500), ("Tessaiga", 1000) };
            Player player = new Player(50, 1, items, 10);
            //Player player = new Player(50, 1, items);
            //Player player = new Player(40, 2);
            //Player player = new Player(30);
            //Player player = new Player();

            player.ShowProfile();

            (string, int) newItem = ("Dragon Slayer", 1500);
            player.AddItem(newItem, 6);

            player.ShowProfile();

            player.UpdateHp(-60);
            Console.WriteLine($"After updating HP: {player.Hp}");
        }

        internal static void OpenMainMenu()
        {
            bool isAppRunning = true;

            while (isAppRunning)
            {
                Console.Write("\n");
                Console.WriteLine("Select your option and press Enter: \n 1.Travel \n 2.Journal \n 3.Exit \n");
                int.TryParse(Console.ReadLine(), out int readOption);


                try
                {
                    switch (readOption)
                    {
                        case 1:
                            OpenTravelMenu();
                            break;

                        case 2:
                            OpenJournalMenu();
                            break;

                        case 3:
                            isAppRunning = false;
                            break;

                        default:
                            throw new Exception("Invalid Option");

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("(-_-') " + ex.Message);
                    isAppRunning = false;
                }
            }
        }

        internal enum GameOptions
        {
            Monsters = 1,
            Journal = 2,
            Exit = 3
        }

        internal static void OpenTravelMenu()
        {
            Console.Write("\n");
            Console.WriteLine("Select your option and press Enter: \n 1.Explore \n 2.Search For Items \n 3.Back To Ship \n 4.Back To Main Menu\n");

            int.TryParse(Console.ReadLine(), out int readOption);

            switch (readOption)
            {
                case 1:
                    Console.WriteLine("Selected Explore");
                    break;

                case 2:
                    Console.WriteLine("Selected Search For Items");
                    break;

                case 3:
                    Console.WriteLine("Selected Back To Ship");
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Invalid Option. Please try a valid option.");
                    break;

            }
        }

        internal static void OpenJournalMenu()
        {
            Console.Write("\n");
            Console.WriteLine("Select your option and press Enter: \n 1.Monsters \n 2.Planets \n 3.Items \n 4.Back To Main Menu\n");

            int.TryParse(Console.ReadLine(), out int readOption);

            switch (readOption)
            {
                case 1:
                    List<Monster> monsters = CreateMonsterList();
                    ShowMonstersFromClasses(monsters);
                    break;

                case 2:
                    Console.WriteLine("Selected Planets");
                    break;

                case 3:
                    Console.WriteLine("Selected Items");
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Invalid Option. Please try a valid option.");
                    break;
            }
        }
        internal static List<Monster> CreateMonsterList()
        {
            return new List<Monster>()
            {
                new Glorbazorg(),
                new Xenotutzi(),
                new Ignifax(),
                new Stonemouth()
            };
        }
        internal static void ShowMonstersFromClasses(List<Monster> monsters)
        {
            Console.WriteLine("The monsters are:\n");

            for (int i = 0; i < monsters.Count; i++)
            {
                Console.WriteLine($"{monsters[i].Name} - {monsters[i].Hp} HP - {monsters[i].Attack} ATT");
            }


            Console.WriteLine("\nPress 1 to go back or 2 to filter monsters by name:");
            int.TryParse(Console.ReadLine(), out int option);

            switch (option)
            {
                case 1:
                    return;

                case 2:
                    FilterMonsterClasses(monsters);
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        //functions using dictionaries and lists
        //internal static List<string> CreateMonstersWithNames()
        //{
        //    List<string> monstersList = new List<string>
        //    {
        //        "Glorbazorg",
        //        "Xenotutzi",
        //        "Ignifax",
        //        "Kryostasis",
        //        "Nighthorn",
        //        "Leviathan-Maw",
        //        "Hydro-King Aqueron",
        //        "Stonemouth"
        //    };
        //    return monstersList;
        //}

        //internal static Dictionary<string, int> CreateMonstersWith(string hpOrAttack, List<string> monstersList)
        //{
        //    Dictionary<string, int> monstersDictionary = new Dictionary<string, int>();
        //    Random randomGenerator = new Random();

        //    for (int i = 0; i < monstersList.Count; ++i)
        //    {
        //        string monsterKey = monstersList[i];
        //        int monsterValue = 0; // default value

        //        if (hpOrAttack == "hp")
        //        {
        //            monsterValue = randomGenerator.Next(10, 100);
        //        }
        //        else if (hpOrAttack == "attack")
        //        {
        //            monsterValue = randomGenerator.Next(1, 20);
        //        }

        //        monstersDictionary.Add(monsterKey, monsterValue);
        //    }

        //    return monstersDictionary;
        //}

        //internal static void ShowMonsters(Dictionary<string, int> monstersWithHp, Dictionary<string, int> monstersWithAttack)
        //{
        //    Console.WriteLine("The monsters are : ");

        //    for (int index = 0; index < monstersWithHp.Count; ++index)
        //    {
        //        Console.WriteLine(monstersWithHp.Keys.ElementAt(index) + " - " + monstersWithHp.Values.ElementAt(index) + " HP");
        //    }
        //    Console.Write("\n");

        //    for (int index = 0; index < monstersWithAttack.Count; ++index)
        //    {
        //        Console.WriteLine(monstersWithAttack.Keys.ElementAt(index) + " - " + monstersWithAttack.Values.ElementAt(index) + " ATT");
        //    }
        //    Console.Write("\n");

        //    ShowMonstersOptions(monstersWithHp);
        //}

        //internal static void ShowMonstersOptions(Dictionary<string, int> monstersWithHp)
        //{
        //    Console.WriteLine("Press 1 to go back or 2 to filter monsters based on name");

        //    int.TryParse(Console.ReadLine(), out int userOption);
        //    switch (userOption)
        //    {
        //        case 1:
        //            break;

        //        case 2:
        //            FilterMonstersByName(monstersWithHp);
        //            break;

        //        default:
        //            Console.WriteLine("Invalid Option. Please try a valid option.");
        //            break;
        //    }
        //}

        //internal static void FilterMonstersByName(Dictionary<string, int> monstersWithHp)
        //{
        //    Console.WriteLine("Enter letters to filter monsters: ");
        //    string? userInput = Console.ReadLine();

        //    Console.Write("\n");

        //    Dictionary<string, int> filteredMonstersByName = new Dictionary<string, int>();
        //    if (!string.IsNullOrEmpty(userInput))
        //    {
        //        string lowerCasedUserInput = userInput.ToLower();
        //        for (int index = 0; index < monstersWithHp.Count; ++index)
        //        {
        //            string currentMonsterName = monstersWithHp.Keys.ElementAt(index);
        //            string lowerCasedCurrentMonster = currentMonsterName.ToLower();

        //            if (lowerCasedCurrentMonster.Contains(lowerCasedUserInput))
        //            {
        //                int currentMonsterHp = monstersWithHp[currentMonsterName];
        //                filteredMonstersByName.Add(currentMonsterName, currentMonsterHp);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("No input provided. Showing all monsters.");
        //        Console.Write("\n");

        //        for (int index = 0; index < monstersWithHp.Count; ++index)
        //        {
        //            Console.WriteLine(monstersWithHp.Keys.ElementAt(index));
        //        }
        //    }

        //    if (filteredMonstersByName.Count == 0)
        //    {
        //        Console.WriteLine("None of the monsters starts with these letters.");
        //        Console.Write("\n");
        //    }
        //    else
        //    {
        //        for (int index = 0; index < filteredMonstersByName.Count; ++index)
        //        {
        //            Console.WriteLine(filteredMonstersByName.Keys.ElementAt(index) + " - " + filteredMonstersByName.Values.ElementAt(index) + " HP");
        //        }
        //    }
        //}
        internal static void FilterMonsterClasses(List<Monster> monsters)
        {
            Console.WriteLine("Enter letters to filter monsters: ");
            string input = Console.ReadLine()?.ToLower() ?? "";

            Console.WriteLine();

            List<Monster> filtered = new List<Monster>();

            for (int i = 0; i < monsters.Count; i++)
            {
                string name = monsters[i].Name.ToLower();
                if (name.Contains(input))
                {
                    filtered.Add(monsters[i]);
                }
            }

            if (filtered.Count == 0)
            {
                Console.WriteLine("No monsters match your filter.\n");
            }
            else
            {
                for (int i = 0; i < filtered.Count; i++)
                {
                    Console.WriteLine($"{filtered[i].Name} - {filtered[i].Hp} HP - {filtered[i].Attack} ATT");
                }
            }
        }
    }
}
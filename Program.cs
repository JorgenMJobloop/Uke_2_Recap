namespace Uke_2_MVC;

class Program
{
    static void Main(string[] args)
    {
        // int[] positiveNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // List<string> names = new List<string>()
        // { "Lars", "Jakob", "Eirik", "BAX", "Trym Magnus", "Sjaman Durek", "Harald Hårfagre"
        // };

        // Names genericNames = new Names()
        // {
        //     Name = "Leif"
        // };

        // List<Names> names1 = new List<Names>();
        // names1.Add(genericNames);

        // foreach (var people in names1)
        // {
        //     Console.WriteLine(people.Name);
        // }

        // Console.WriteLine(genericNames.Name);


        // for (int i = 0; i < positiveNumbers.Length; i++)
        // {
        //     Console.WriteLine(positiveNumbers[i]);
        // }

        // names.Add("Ida");
        // names.Add("Jon");

        // foreach (string name in names)
        // {
        //     Console.WriteLine(name);
        // }

        Console.WriteLine("Hvor gammel er du? ");

        string? userInput = Console.ReadLine();

        //string expectedAge = "";

        // if (Convert.ToDouble(userInput) >= 18)
        // {
        //     Console.WriteLine($"Du kan komme inn på nattklubben");
        // }
        // else
        // {
        //     Console.WriteLine("Du får ikke komme inn!");
        // }

        switch (userInput.ToLower())
        {
            case "hei":
                Console.WriteLine("Hei der!");
                break;
            case "hade":
                Console.WriteLine("Hade!");
                break;
            case "fakta":
                Console.WriteLine("Factoid betyr ikke en liten og sann fakt, men usann informasjon presentert som faktum.");
                break;
            default:
                Console.WriteLine("Okay.");
                break;
        }

        // eksempel på en lang string
        string longString = @"""
        Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
        """;
        Console.WriteLine(longString);
    }
}

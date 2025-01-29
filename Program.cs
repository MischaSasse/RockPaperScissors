internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Rock Paper Scissors\n" +
            "Please pick one of the three options:\n" +
            "1: Rock, 2: Paper, 3: Scissors");
        int userInput;
        while (true)
        {
            userInput = GetUserInput();
            if (userInput == 0)
            {
                Error();
                continue; // This will restart the loop
            }
            break; //This will break out of the loop if userInput != 0
        }
            int computerInput = ComputerInput();
            Console.WriteLine(Result(userInput, computerInput));
    }
    private static int GetUserInput()
    {
        string userInput = Console.ReadLine().Trim().ToLower();
        return MapInput(userInput);
    }

    private static int MapInput(string? input)
    {
        return input switch
        {
            "rock" or "1" => 1,
            "paper" or "2" => 2,
            "scissors" or "3" => 3,
            _ => 0
        };
    }
    private static int ComputerInput()
    {
        Random randomNumber = new();
        return randomNumber.Next(1, 4);
    }

    private static string Result(int user, int computer)
    {
        if (computer - user == 1 || computer - user == -2) { return "Computer has won with " + ResultMap(computer); }
        if (computer - user == -1 || computer - user == 2) { return "You won, computer chose " + ResultMap(computer); }
        return "Tie, the computer also chose " + ResultMap(computer);
    }

    private static void Error()
    {
        Console.WriteLine("no valid input, please try again");
    }

    private static string ResultMap(int computerInput)
    {
        return computerInput switch
        {
            1 => "rock",
            2 => "paper",
            3 => "scissors",
            _ => "error",
        };
    }
}
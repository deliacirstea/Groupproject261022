//Solution found by my teacher






try
{
    int targetNumber = new Random().Next(10);
    List<int> previousGuesses = new List<int>();

    while (true)
    {
        int number;
        bool guessed;
        do
        {
            Console.WriteLine("Pick a number between 0 and 9 (inclusive): ");
            number = Convert.ToInt32(Console.ReadLine());
            guessed = previousGuesses.Contains(number);

            if (guessed)
                Console.WriteLine("That number has been guessed before:");
        }
        while (guessed);

        if (number == targetNumber) throw new Exception();
        previousGuesses.Add(number);
    }
    
}
            catch (Exception)
        {
            Console.WriteLine("That was a bad number! You lose! Muhahahhahahaha!");
        }
namespace Day01ConsoleVariableAndDataTypes
{
    internal class Program
    {
        //Your code start executing here in Main method
        static void Main(string[] args)
        {
            Run();
            Console.ReadKey();
        }

        /// <summary>
        /// Get string user input 
        /// </summary>
        /// <param name="prompt">Message to be Display in Console</param>
        /// <returns>user input in string format</returns>
        static string? GetStringPrompt(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="prompt">string prompt for age</param>
        /// <returns>age</returns>
        static int GetAgePrompt(string prompt)
        {
            Console.Write(prompt);
            while (true)
            {
                bool success = int.TryParse(Console.ReadLine(), out var age);
                if(success && !(age < 0) )
                {
                    return age;
                }
                Console.Write("Invalid age. Please enter a valid age number: ");

            }
        }
        /// <summary>
        /// inline expression getting birth year by subtracting age from the current year
        /// </summary>
        /// <param name="age">int age</param>
        /// <returns>birth year /returns>
       static int GetBirthYear(int age) => DateTime.UtcNow.Year - age;
        /// <summary>
        /// Display Hello Message
        /// </summary>
        /// <param name="name">string name</param>
        /// <param name="age">int age</param>
        /// <param name="favoriteProgrammingLanguage">string favorite</param>
       /// <param name="birthYear">int birthYear</param>
        static void DisplayHelloMessage(string? name, int age, string? favoriteProgrammingLanguage, int birthYear)
        {

            Console.WriteLine(); //Ensure it has a new line spacing
            Console.WriteLine($"Hello {name}! You are {age} years old and you love {favoriteProgrammingLanguage}.");
            Console.WriteLine($"You were born in {birthYear}.");
        }
     /// <summary>
     /// Run a Driver's method
     /// </summary>
        static void Run()
        {
            string? firstName = GetStringPrompt("Enter your name: ");
            int age = GetAgePrompt("Enter your age: ");
            string? favoriteProgrammingLanguage = GetStringPrompt("Enter your favorite programming language: ");
            int birthYear = GetBirthYear(age);
            DisplayHelloMessage(firstName, age, favoriteProgrammingLanguage,birthYear);
        } 
    }
}

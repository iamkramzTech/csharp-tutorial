namespace Day02ConditionsOperatorsDecisionMaking
{
    class Program
    {
        //Day 02 Machine Problem: Letter Grade
        static void Main(string[] args)
        {

            Run();
            ConvertAnotherGradeWhileYes();
          
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="letterGrade"></param>
        /// <param name="remarks"></param>
        static void DisplayGradeMessage(char letterGrade, string remarks )
        {
            Console.WriteLine($"Your grade is {letterGrade}");
            Console.WriteLine($"Remark: {remarks}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="letterGrade"></param>
        /// <returns></returns>
        static string RemarksLetterGrade(char letterGrade)
        {
            switch(letterGrade)
            {
                case 'A':
                    return "Excellent";
                case 'B':
                    return "Good";
                case 'C':
                    return "Average";
                case 'F':
                    return "Needs Improvement";
                default:
                    return "Invalid Letter Grade";
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        static char ConvertNumericGradeToLetter(int grade)
        {
            if (grade < 0 || grade > 100)
                throw new ArgumentException($"Invalid Numerical Grade {nameof(grade)}");

            if (grade >= 90 && grade <= 100)
                return 'A';
            else if (grade >= 80 && grade <= 89)
                return 'B';
            else if (grade >= 70 && grade <= 79)
                return 'C';
            else
                return 'F';

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
       
        static int GetNumericGrade(string prompt)
        {
            Console.Write(prompt);

            while (true)
            {
                bool success = int.TryParse(Console.ReadLine(), out var grade);
                if (success)
                {
                    return grade;
                }
                Console.Write("Please enter a valid Numerical Grade (whole number only): ");

            }
        }

        //Driver Method
        static void Run()
        {
            try
            {
                int grade = GetNumericGrade("Enter grade (whole number only): ");
                char letterGrade = ConvertNumericGradeToLetter(grade);
                string remarks = RemarksLetterGrade(letterGrade);

                DisplayGradeMessage(letterGrade: letterGrade, remarks: remarks);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
        /// <summary>
        /// Convert Another grade if user press y key
        /// </summary>
        static void ConvertAnotherGradeWhileYes()
        {
            while (true)
            {
                Console.Write("Do you want to convert another grade? (y/n): ");
                var choice = Console.ReadKey(true); // Waits for a key press, but does not display it
                Console.WriteLine();
                if (choice.Key == ConsoleKey.Y)
                {
                    Run();
                }
                else if (choice.Key == ConsoleKey.N)
                {


                    Console.WriteLine("Message: Goodbye..");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }
            }
        }
    }
}

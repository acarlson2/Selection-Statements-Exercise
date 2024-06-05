namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNum = 260;
            Console.WriteLine("Try to guess my favorite number.");
            var userInput = int.Parse(Console.ReadLine());

            if(userInput < favNum)
            {
                Console.WriteLine("Too Low");
            }
            else if(userInput > favNum)
            {
                Console.WriteLine("Too High");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            Console.WriteLine("What is your favorite school subject?");
            var userInput2 = Console.ReadLine();

            switch(userInput2)
            {
                case "Math":
                    Console.WriteLine($"{userInput2}? Not my favorite subject, but good for you.");
                    break;
                case "Science":
                    Console.WriteLine($"{userInput2}? I love {userInput2}!");
                    break;
                case "History":
                    Console.WriteLine($"{userInput2}? That's my favorite subject too!");
                    break;
                case "English":
                    Console.WriteLine($"{userInput2}? Personally, I find that subject kinda boring.");
                    break;
                case "PE":
                    Console.WriteLine($"{userInput2}? That's understandable.");
                    break;
                default:
                    Console.WriteLine($"{userInput2}? I've never heard of that subject before.");
                    break;
            }
        }
    }
}

namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("what's your name?");
            string username = Console.ReadLine();
            Console.WriteLine($"hello, {username}");
            Console.WriteLine("how old are you?");
            int userage =  int.Parse(Console.ReadLine());
            Console.WriteLine($"you are {userage}");
            Console.WriteLine("what's your middle initial");
            char middle = char.Parse(Console.ReadLine());
            Console.WriteLine($"you middle inital is {middle}");
            Console.WriteLine("is colbee the best coder true or false?");
            bool isColbee = bool.Parse(Console.ReadLine());
            Console.WriteLine($"you said {isColbee}");
            Console.WriteLine("do you know what half of one is?");
            double halfof1 = double.Parse(Console.ReadLine());
            Console.WriteLine ($"your answer is {halfof1}"); 
            Console.WriteLine("how much money would you like?");
            decimal money = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"your name is {username} and your middle initial is {middle} and you are {userage} and you get {money} dollars");
            

        }
    }
}

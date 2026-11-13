class Program
{
    static void Main(string[] args)
    {
        int Num1;
        int Num2;
        int choice;
        Console.WriteLine("Welcome to the Calculator!");
        Console.WriteLine("Please enter the first number:");
        Num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please Enter The second number:");
        Num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the operation:");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        
        choice = Convert.ToInt32(Console.ReadLine());
        
        switch (choice)
        {
            case 1:
                Console.WriteLine("The result is: " + (Num1 + Num2));
                break;

            case 2:
                Console.WriteLine("The result is: " + (Num1 - Num2));
                break;

            case 3:
                Console.WriteLine("The result is: " + (Num1 * Num2));
                break;

            case 4:
                if (Num2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                else
                {
                    Console.WriteLine("The result is: " + (Num1 / Num2));
                }   
                break;
        }

    }
}
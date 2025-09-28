namePrinter();

void namePrinter ()
{ 
    Console.WriteLine("Please enter your name :");
    string name = Console.ReadLine();
    Console.WriteLine("Please enter your age?");
    int age = Convert.ToInt32(Console.ReadLine());
    int newAge = age + 5;
    Console.WriteLine($"Hello {name} ,you will be {newAge} in 5 years");
}


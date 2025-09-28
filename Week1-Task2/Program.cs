userAge();
void userAge()
{
 Console.WriteLine("Please enter your age?");
 int age = Convert.ToInt32(Console.ReadLine());

    if (age < 13)
    {
        Console.WriteLine("You are a child");
    }
    else if (age >= 13 && age <= 19)
    {
        Console.WriteLine("You are a teenager");
    }
    else if (age > 19 && age < 110)
    {
        Console.WriteLine("You are an adult");
    }
    else
    {
        Console.WriteLine("Input an age that is greater than 0 or less than 110");
    }



}

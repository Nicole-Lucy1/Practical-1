leapYear();
void leapYear() 
{
Console.WriteLine("Please enter a Year");
int year = Convert.ToInt32(Console.ReadLine());

if(year%4 == 0)
    {
        Console.WriteLine("It's a leap year");
    }
else if(year < 0)
    {
        Console.WriteLine("Input a postive year");
    }
else
    {
        Console.WriteLine("It's not a leap year");
    }
    
}
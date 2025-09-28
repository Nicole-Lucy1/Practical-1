
PositiveNegativeChecker();
void PositiveNegativeChecker()
{
Console.WriteLine("Please enter an integer");
int number = Convert.ToInt32(Console.ReadLine());
if (number >0)
{
   Console.WriteLine("This is a positive number");
}
else if (number < 0)
{
   Console.WriteLine("This is a negative number");
}
    else
    {
        Console.WriteLine("This number is 0");
    }


}

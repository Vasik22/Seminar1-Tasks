Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number2");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number3");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number > number2)
 {
    number2 = number;
 }
if (number3 > number2)
{
    Console.WriteLine ( " Max "+number3);
 } else
{
  Console.WriteLine ( " Max "+number2);   
}

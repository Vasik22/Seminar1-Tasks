//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine("Enter number1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number2");
int number2=Convert.ToInt32(Console.ReadLine());
if (number1 >=number2){
Console.WriteLine("MaxNumber "+number1);
}
else {
   Console.WriteLine("MaxNumber"+number2); 
}
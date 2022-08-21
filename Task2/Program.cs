Console.WriteLine("Enter number1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number2");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number3");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 >=number2){
Console.WriteLine ("MaX"+ number1);
}

else {
Console.WriteLine ("MaX"+ number2);
}
if (number2 > number3){
Console.WriteLine ("MaX"+ number2);
}
else {
   Console.WriteLine ("MaX"+ number3);
}
if (number1 > number3) {
Console.WriteLine ("MaX"+ number1);
}
else {
    Console.WriteLine ("MaX"+ number3);
}

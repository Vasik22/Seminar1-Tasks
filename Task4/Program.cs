Console.Write("Enter number:");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
for (i = 1; i<number; i++){
    if  (i % 2==0) {
        Console.WriteLine(i);
    }
}

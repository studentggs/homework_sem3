/*Задача 19

Console.Write("Enter your number: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
Console.WriteLine("Отрицательное число не может быть полиндромном!");
int numTemp =num;
int value;
int numRevers = 0;
while (numTemp > 0)
{
    value = numTemp % 10;
    numRevers = numRevers * 10 + value;
    numTemp /= 10; 
}
if (numRevers == num)
Console.WriteLine("Да");
else 
Console.WriteLine("Нет");*/


/* Задача 21

   double LinelengthAB(int x1, int x2,  int y1, int y2, int z1, int z2)
  {
    double lengthAB = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return lengthAB;
  }
  Console.Write("Enter X coord A: ");
  int xAcoord = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter Y coord A: ");
  int yAcoord = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter Z coord A: ");
  int zAcoord = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter X coord B: ");
  int xBcoord = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter Y coord B: ");
  int yBcoord = Convert.ToInt32(Console.ReadLine());
  Console.Write("Enter Z coord B: ");
  int zBcoord = Convert.ToInt32(Console.ReadLine());

  double dist = LinelengthAB(xAcoord, xBcoord, yAcoord, yBcoord, zAcoord, zBcoord);
  Console.WriteLine($"Distance AB is {dist:f2}");*/


/*Задача 23

void PSquare(int N)
{
    for (int temp =1;temp<=N;temp++)
    {
        double number = Math.Pow(temp,3);
        Console.Write(number + " ");
    }
}
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
PSquare(number);*/

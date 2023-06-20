void Number1version1()
{
    int NegativeNumber=0;
    for(int i = 0;i<99999999;i++)
    {
        Console.WriteLine("Введите число: ");
        int num=Convert.ToInt32(Console.ReadLine());
        if(num<0)
        {
            NegativeNumber++;
        }
        Console.WriteLine($"Введено отрицательных чисел: {NegativeNumber}");
    }
}
void Number1version2()
{
    Console.WriteLine("Сколько чисел хотите ввести?");
    int num=Convert.ToInt32(Console.ReadLine());
    int [] array = new int [num];
    int Neg=0;
    int count=1;
    for(int i=0;i<array.Length;i++)
    {
        Console.WriteLine($"{count}.Введите число: ");
        int num2=Convert.ToInt32(Console.ReadLine());
        if(num2<0)
        {
            Neg++;
        }
        count++;
    }
    Console.WriteLine($"Вы ввели отрацательных чисел: {Neg}");
}
void Number2()
{
    Console.WriteLine("Введите число: ");
    int a=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число: ");
    int b=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число: ");
    int c=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число: ");
    int d=Convert.ToInt32(Console.ReadLine());
    int x=(d-c)/(a-b);
    int y=a*x+c;
    Console.WriteLine($"({x},{y})");
}
Number1version2();
Number2();
Number1version1();
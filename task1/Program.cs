Console.WriteLine("выберите задание");
Console.WriteLine("цифра 1 - задача 47");
Console.WriteLine("цифра 2 -задача 50");
Console.WriteLine("цифра 3 -задача 52");
int n = Convert.ToInt32(Console.ReadLine());

switch(n)
{
    case 1:
        task1();
        break;
    case 2:
        task2();
        break;
    case 3:
        task3();
        break;
    default:
        break;
}

void task1()
{

Console.WriteLine("Введите m и n");
int m= Convert.ToInt32(Console.ReadLine());
int n= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите массив построчно через пробел");
double [,] array2d = new double [m,n];
for (int i=0; i<m; i++)
{
    string [] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for (int j=0; j<n; j++)
    {
        array2d[i,j]=Convert.ToDouble(text[j]);
    
    }
}

void print(double [,] array2d)
{
   for (int i=0; i<array2d.GetLength(0); i++)
    {
         for (int j=0; j<array2d.GetLength(1); j++)
    {
        Console.Write(array2d[i,j] + " ");
    } 
    Console.WriteLine();
}
}   
print(array2d);

}

void task2()
{

Console.WriteLine("Введите m и n");
int m= Convert.ToInt32(Console.ReadLine());
int n= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int x= Convert.ToInt32(Console.ReadLine());
int [,] array2d = new int [m,n];
Random random = new Random();
int count = 0;
for (int i=0; i<m; i++)
{
    for (int j=0; j<n; j++)
    {
        array2d[i,j]=random.Next(0,10);
        Console.Write(array2d[i,j] + " ");
    }
    Console.WriteLine();
}
for (int i=0; i<array2d.GetLength(0); i++)
{
    for (int j=0; j<array2d.GetLength(1); j++)
    {
        if (array2d[i,j] == x)
        Console.Write("Индексы искомого числа: "+i+"-"+j+" ");
        else
        count ++;
    }
}
if (count>=m*n)
Console.Write("Числа в массиве нет");
}

void task3()
{
Console.WriteLine("Введите m и n");
int m= Convert.ToInt32(Console.ReadLine());
int n= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите массив построчно через запятую");
int [,] array2d = new int [m,n];

for (int i=0; i<m; i++)
{
    string [] text = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
     for (int j=0; j<n; j++)
    {
        array2d[i,j]=Convert.ToInt32(text[j]);
      
    }
    
}
for (int j=0; j<array2d.GetLength(1); j++)
    {
        double sum=0;
         for (int i=0; i<array2d.GetLength(0); i++)
    {
        sum =(sum + array2d[i,j]);
    } 
    Console.WriteLine(sum/m);
    
}
}
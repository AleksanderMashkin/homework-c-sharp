/*
{
Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double [rows, columns];
for (int i = 0; i < matrix.GetLength (0); i++)
{
    for (int j = 0; j < matrix.GetLength (1); j++)
    {
        matrix[i,j] = new Random().Next(1,10);
    }
}

for (int i = 0; i < matrix.GetLength (0); i++)
{
    for (int j = 0; j < matrix.GetLength (1); j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }
Console.WriteLine();
}
}
*/

/*
{
Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какое число найти");
int search = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double [rows, columns];
for (int i = 0; i < matrix.GetLength (0); i++)
{
    for (int j = 0; j < matrix.GetLength (1); j++)
    {
        matrix[i,j] = new Random().Next(1,10);
    }
}

for (int i = 0; i < matrix.GetLength (0); i++)
{
    for (int j = 0; j < matrix.GetLength (1); j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }
Console.WriteLine();
}
if (rows <  matrix.GetLength(0) && columns < matrix.GetLength(1)) Console.WriteLine(matrix[rows, columns]);
else Console.WriteLine($"{search} -> такого числа в массиве нет");
Console.WriteLine();
}
*/

{
Console.WriteLine("Введите число строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
double [,] matrix = new double [rows, columns];
for (int i = 0; i < matrix.GetLength (0); i++)
{
    for (int j = 0; j < matrix.GetLength (1); j++)
    {
        matrix[i,j] = new Random().Next(1,10);
    }
}

for (int i = 0; i < matrix.GetLength (0); i++)
{
    for (int j = 0; j < matrix.GetLength (1); j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }
Console.WriteLine();
}


    for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, j];
    }
    Console.Write($"{ sum / matrix.GetLength(0)} ");
}
}


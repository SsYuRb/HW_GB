Console.Write("Введите количество строк в Вашем массиве: ");
int a = Int32.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в Вашем массиве: ");
int b = Int32.Parse(Console.ReadLine());
int [,] numbers = new int[a, b];

void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} | ");
        }
    Console.WriteLine();
    }
}

void FillRandomNumbers (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,20);
        }
    }
}

void AverageNumbers (int [,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double count = 0;
        int sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            count = count + array[j,i];
            sum += 1;
            if (sum == 3) {Console.Write($"{Math.Round(count/sum, 2)} | ");}
        }
    }
}
FillRandomNumbers(numbers);
Console.WriteLine("Ваш массив: ");
PrintArray(numbers);
Console.WriteLine("Среднее арифметическое элементов каждой столбца: ");
AverageNumbers(numbers);
int[,] arrayNumb = new int [4,4];

void FillArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1,10);
        }
    }
}

FillArray(arrayNumb);

// оставлю для проверки кода
// void PrintArray (int[,] matrix)
// { 
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }

// PrintArray(arrayNumb);

int [] matr = new int [arrayNumb.GetLength(0)];

void EveryRowsAmount(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int amount = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            amount += matrix[i, j];
        }
        matr [i] = amount;
    }
}

EveryRowsAmount(arrayNumb);

void LessAverageRows (int[] matrix)
{
    int count = 0;
    int minNumber = 37;
    for (int i = 0; i < matrix.Length; i++)
    {
        if (matrix[i] < minNumber) 
        {
            minNumber = matrix[i];
            count = i+1;
        }
    }
    Console.Write(count);
}

LessAverageRows(matr);
Console.Write(" строка - это строка с наименьшей суммой элементов");
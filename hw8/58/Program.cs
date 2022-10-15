int[,] arrayNumbFirst = new int [2,2];
int[,] arrayNumbSecond = new int [2,2];

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

FillArray(arrayNumbFirst);
FillArray(arrayNumbSecond);

void PrintArray (int[,] matrix)
{ 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
    Console.WriteLine();
    }
}

PrintArray(arrayNumbFirst);
Console.WriteLine();
PrintArray(arrayNumbSecond);

int[,] multiple = new int [arrayNumbFirst.GetLength(1),arrayNumbSecond.GetLength(0)];

void MatrMultiplic (int[,] first, int[,] second)
{
    for (int i = 0; i < first.GetLength(1); i++)
    {
        for (int j = 0; j < second.GetLength(0); j++)
        {
            for (int k = 0; k < first.GetLength(1); k++)
            {
                multiple[i, j] += first[i,k] * second[k,j];
            }
        }
    }
}

MatrMultiplic(arrayNumbFirst, arrayNumbSecond);
Console.WriteLine();
Console.WriteLine("Результирующая матрица: ");
PrintArray(multiple);
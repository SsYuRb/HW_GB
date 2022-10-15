int [,] arrayNum = new int [4,4];
int count = 1;

void FillArray (int[,] array)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        array [0, j] = count;
        count += 1;
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        array[i, array.GetLength(1)-1] = count;
        count += 1;
    }
    for (int j = array.GetLength(1)-2; j != -1; j--)
    {
        array [array.GetLength(0)-1, j] = count;
        count += 1;
    }
    for (int i = array.GetLength(0)-2; i != 0; i--)
    {
        array[i, 0] = count;
        count += 1;
    }
}
FillArray(arrayNum);

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

PrintArray(arrayNum);
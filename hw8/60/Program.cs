int[,,] tripleArray = new int [2,2,2];
int [] array = new int [8];

void ArrayRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int numb = new Random().Next(10,99);
        while (array.Contains(numb)) numb = new Random().Next(10,99);
        array [i] = numb;
    }
}
ArrayRandom(array);

void FillArray (int[,,] tripl)
{
    int count = 0;
        for (int i = 0; i < tripl.GetLength(0); i++)
        {
            for (int j = 0; j < tripl.GetLength(1); j++)
            {
                for (int k = 0; k < tripl.GetLength(2); k++)
                {
                    tripl[i,j,k] = array[count];
                    count += 1;
                }
            }
        }
    }

FillArray(tripleArray);

void PrintArray(int[,,] tripl)
{
    for (int i = 0; i < tripl.GetLength(0); i++)
    {
        for (int j = 0; j < tripl.GetLength(1); j++)
        {
            for (int k = 0; k < tripl.GetLength(2); k++)
            {
                Console.Write($"{tripl[i,j,k]} {(i, j, k)} ");
            }
        Console.WriteLine();
        }
    }
}

PrintArray(tripleArray);


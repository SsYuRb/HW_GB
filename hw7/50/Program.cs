int [,] numbers = new int[3, 4];

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

Console.Write("Введите какое-нибудь число: ");
int digit = Int32.Parse(Console.ReadLine());
int count = 0;

void SearchInArray(int digit, int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (digit == array[i,j]) 
            {
                count += 1;
                if (count == 1) {Console.Write("Ваше число находится на позиции: ");}
                else if (count > 1) {Console.Write("А также на позиции: ");}
                Console.WriteLine($"{(i, j)}");
                
            }
            
        }
    }
    if (count == 0) {Console.WriteLine("Такого числа в массиве нет!");}
}

FillRandomNumbers(numbers);
PrintArray(numbers);
SearchInArray(digit, numbers);

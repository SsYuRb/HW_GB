Console.WriteLine("Введите количество чисел: ");
int digits = Int32.Parse(Console.ReadLine());
int[] arrayDigits = new int[digits];
for (int i = 0; i < digits; i++)
{
    if (i == 0)
    {
        Console.Write("Введите число: ");
    }
    arrayDigits[i] = Int32.Parse(Console.ReadLine());
    if (i != digits - 1)
    {
        Console.Write("Введите следующее число: ");
    }
}
int summ = 0;
for (int i = 1; i < digits; i += 2)
{
    summ = summ + arrayDigits[i];
}
Console.Write("Сумма элементов на нечетных позициях: ");
Console.WriteLine(summ);

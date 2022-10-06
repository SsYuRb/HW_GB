Console.WriteLine("Введите количество чисел: ");
int digits = Int32.Parse(Console.ReadLine());
int[] arrayDigits = new int[digits];
for (int i = 0; i<digits; i++)
{
    if (i == 0)
    {
        Console.Write("Введите число: ");
    }
    arrayDigits[i] = Int32.Parse(Console.ReadLine());
    if (i != digits-1)
    {
        Console.Write("Введите следующее число: ");
    }
}
int count = 0;
for (int i = 0; i<digits; i++)
{
    if (arrayDigits[i]%2==0) {count += 1; }
}
Console.Write("Колличество четных чисел: ");
Console.WriteLine(count);

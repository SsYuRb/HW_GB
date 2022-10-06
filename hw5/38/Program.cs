Console.WriteLine("Введите количество чисел: ");
int digits = Int32.Parse(Console.ReadLine());
double[] arrayDigits = new double[digits];

for (int i = 0; i < digits; i++)
{
    if (i == 0)
    {
        Console.Write("Введите число: ");
    }
    arrayDigits[i] = double.Parse(Console.ReadLine());
    if (i != digits - 1)
    {
        Console.Write("Введите следующее число: ");
    }
}

double maxNumber = arrayDigits[0];
double minNumber = arrayDigits[0];

for (int i = 0; i < digits; i++)
{
    if (arrayDigits[i] > maxNumber) { maxNumber = arrayDigits[i]; }
    else if (arrayDigits[i] < minNumber) { minNumber = arrayDigits[i]; }
}
Console.Write("Максимальное введенное число: ");
Console.WriteLine(maxNumber);
Console.Write("Миниамльное введенное число: ");
Console.WriteLine(minNumber);
Console.Write("Разница между максимальным и миниамльным введенным числом равна: ");
double dif = maxNumber - minNumber;
Console.WriteLine(dif);
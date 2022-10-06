// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Write ("Введите числа через пробел: ");
string numbers = Console.ReadLine ();
string [] arrayNumbers = numbers.Split(" ");
int [] arrayOfIntNumbers = new int[arrayNumbers.Length];
for (int i = 0; i < arrayNumbers.Length; i++)
{
    arrayOfIntNumbers[i] = Int32.Parse(arrayNumbers[i]);
}
int count = 0;
for (int i = 0; i < arrayNumbers.Length; i++)
{
    if (arrayOfIntNumbers[i]>0) {count += 1; }
}
Console.Write ("Колличество чисел > 0: ");
Console.WriteLine(count);
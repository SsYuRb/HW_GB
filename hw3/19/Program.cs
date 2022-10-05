void Pallindrom(string number)
{
    int lenght_number = number.Length;
    string digit = "";
    int numbers = Int32.Parse(number);
    int numbers_reserv = Int32.Parse(number);
    while (lenght_number > 0)
    {
        int digits = numbers % 10;
        digit = digit + digits.ToString();
        numbers = numbers/10;
        lenght_number = lenght_number - 1;
    }
    int digit1 = Int32.Parse(digit);
    if (digit1 == numbers_reserv)
    {
        Console.WriteLine("Ваше число палиндром.");
    }
    else 
    {
        Console.WriteLine("Нет, Ваше число не палиндром");
    }
}
Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
Pallindrom(input);
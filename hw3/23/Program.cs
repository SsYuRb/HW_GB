Console.WriteLine("Введите число: ");
int number = Int32.Parse(Console.ReadLine());
void Cubes (int numb1)
{
    for (int i = 1; i < numb1+1; i++)
    {
        int cube = i*i*i;
        Console.WriteLine(cube);
    }
}
Console.WriteLine("Ваши кубы: ");
Cubes(number);
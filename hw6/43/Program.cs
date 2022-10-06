// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write ("Введите значения k1 и b1 для первого графика через пробел: ");
string k1b1 = Console.ReadLine ();
string [] arrayk1b1 = k1b1.Split(" ");
int [] arrayIntK1b1 = new int[arrayk1b1.Length];
for (int i = 0; i < arrayk1b1.Length; i++)
{
    arrayIntK1b1[i] = Int32.Parse(arrayk1b1[i]);
}
Console.Write ("Введите значения k2 и b2 для первого графика через пробел: ");
string k2b2 = Console.ReadLine ();
string [] arrayk2b2 = k2b2.Split(" ");
int [] arrayIntK2b2 = new int[arrayk2b2.Length];
for (int i = 0; i < arrayk2b2.Length; i++)
{
    arrayIntK2b2[i] = Int32.Parse(arrayk2b2[i]);
}
int x = (arrayIntK2b2[1]-arrayIntK1b1[1])/(arrayIntK1b1[0]-arrayIntK2b2[0]);
int y = arrayIntK1b1[0]*x+arrayIntK1b1[1];
Console.WriteLine($"Точка пересечения прямых ({x};{y})");
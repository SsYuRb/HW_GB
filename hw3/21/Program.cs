void Distance (int a1, int b1, int c1, int a2, int b2, int c2)
{
    int distance = (a1-a2)*(a1-a2)+(b1-b2)*(b1-b2)+(c1-c2)*(c1-c2);
    double sqrt = Math.Sqrt(distance);
    Console.WriteLine(sqrt);
}
Console.WriteLine ("Введите х1: ");
int x1 = Int32.Parse(Console.ReadLine());
Console.WriteLine ("Введите у1: ");
int y1 =  Int32.Parse(Console.ReadLine());
Console.WriteLine ("Введите z1: ");
int z1 =  Int32.Parse(Console.ReadLine());
Console.WriteLine ("Введите х2: ");
int x2 =  Int32.Parse(Console.ReadLine());
Console.WriteLine ("Введите у2: ");
int y2 =  Int32.Parse(Console.ReadLine());
Console.WriteLine ("Введите z2: ");
int z2 =  Int32.Parse(Console.ReadLine());
Distance(x1,y1,z1,x2,y2,z2);
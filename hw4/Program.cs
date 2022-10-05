// Есть магазин "Еда"
// В магазине есть охранник
// Охранник ведёт запись всех, кто заходит в магазин
// Охранник ведёт запись всех, кто выходит из магазин
// Зайти и выйти можно в целый час.
// Выяснить в какой промежуток времени было больше всего
// посетителей
// Данные вводятся парами: приход-уход
// Максимум 100 покупателей
// Входные данные
// 10-12
// 11-13
// 9-12
// Ответ
// 11-12
int [] Hour = new int [24];

int [] TimeIO (int comeInTime, int comeOutTime, int [] col)
{
    for (int hour = 0; hour < col.Length; hour ++) 
    {
        if (comeInTime == hour)
        {
            for (int i = hour; i < comeOutTime; i ++)
            {
                col [i] = col [i] + 1;
            }
        }
    }
    return col;
}

int [] HowManyPeople(int countOfPersons, int[] col)
{
    for (int i = 1; i <= countOfPersons; i ++)
    {
        Console.Write ("Введите время входа и выхода: ");
        string[] tio = Console.ReadLine().Split('-');
        int timeIn = Int32.Parse(tio[0]);
        int timeOut = Int32.Parse(tio[1]);
        col = TimeIO(timeIn, timeOut, col);
        if (i != countOfPersons)
        {
            Console.WriteLine ("Следующий человек");
        }
    }
    Console.WriteLine ();
    return col;
}

int [] FindMaxInterval (int [] array)
{
    int max = array [0];
    int maxIndex = 0;
    int interval = 1;
    
    for (int i = 0; i < array.Length; i ++)
    {
        if (array [i] > max)
        {
            max = array [i];
            maxIndex = i;
        }
    }
    
    for (int k = maxIndex + 1; k < array.Length; k ++ )
    {
        if (array[k] == array[maxIndex])
        {
            interval += 1;
        }
        else
        {
            break;
        }
    }
    return new [] {maxIndex, (maxIndex + interval)};
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.Write ("Сколько людей было в магазине? ");
int countOfPersonsInStore = Int32.Parse(Console.ReadLine());

Hour = HowManyPeople (countOfPersonsInStore, Hour);

int [] intervalOfMaxPersons = FindMaxInterval (Hour);
string maxInterval = string.Join(":", intervalOfMaxPersons);
Console.WriteLine("Интервал, в который было больше всего людей - " + maxInterval);

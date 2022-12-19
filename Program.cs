// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Задание должно быть выполнено в методе.
//  В методе не должно быть вывода в консоль. Не использовать String!
// 14212 -> нет
// 12821 -> да
// 23432 -> да


void CheckPalindromicNumber(int number)
{
    if(number >= 10000)
    {
        int division1 = number / 10000;
        int remainder1 = number % 10;
 
            if(division1 == remainder1)
            {
                number = number / 10;
                int division2 = (number / 100) % 10;
                int remainder2 = number  % 10;
                if(division2 == remainder2)
                    Console.WriteLine("Yes");
            }
            else 
            Console.WriteLine("No");
            
    }
    else
    Console.WriteLine("Wrong number!");
}
 
Console.WriteLine("Input five digit number:");
int number = int.Parse(Console.ReadLine()!);
CheckPalindromicNumber(number);


// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве. 
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int z1 = ReadInt("Введите координату Z первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");
int z2 = ReadInt("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длина отрезка {length}");



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N. 
// Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int num = InputInt();
int[] cubeTable = GetCubeTable(num);
PrintArray(cubeTable);

int InputInt()
{
Console.WriteLine("Input number");
bool isNum = int.TryParse(Console.ReadLine(), out num);
if (isNum)
{
    return num;
}
else {
    Console.WriteLine("Wrong number");
    return -1;
}
}

int[] GetCubeTable(int num)
{
int[] array = new int[num];

for (int i = 0; i < num; i++)
    {
        array[i] = (int)(Math.Pow(i + 1, 3));
    }
    return array;
    Console.WriteLine();
}

    void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}  ");
        }
    }



// Написать программу, которая найдёт точку пересечения двух прямых 
// Уравнение: y1 = k1 * x + b1, y2 = k2 * x + b2
// Значения b1, k1, b2 и k2 задаются пользователем

Console.WriteLine();
Console.WriteLine("Данная программа найдёт точку пересечения двух прямых, заданных уравнениями:"); 

Console.WriteLine();
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");

Console.WriteLine();
Console.WriteLine("Введите значения переменных:");

Console.WriteLine();
Console.Write("Введите значение к1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение к2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2 && b1 != b2) // Прямые парралельны
{
    Console.WriteLine();
    Console.WriteLine("Прямые не пересекаются (прямые параллельны).");
}
else
{
if (k1 == k2 && b1 == b2) // Прямые совпадают
{
    Console.WriteLine();
    Console.WriteLine("Прямые совпадают (бесконечное множество точек пересечения).");
}
else // Прямые пересекаются
{

double op1 = k1 - k2;
double op2 = b2 - b1;
double x = op2 / op1;

double corX = x;
double corY = k2 * x + b2;

Console.WriteLine();
Console.WriteLine ($"Точка пересечения прямых имеет координаты ({corX}, {corY})"); 
}
}

// Протестировано 12.12.2022 13:18
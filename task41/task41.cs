// Пользователь через ввод задает размер массива
// Пользователь вводит числа из которых будет состоять массив
// Посчитать сколько чисел больше 0 ввел пользователь


void FillArray (int[] fill)
{
    int length = fill.Length;
    int index = 0;
    Console.WriteLine();
    Console.WriteLine("Введите поочередно элементы массива");
    for (index = 0; index < fill.Length; index++)
    {
        Console.Write("Введите элемент: ");
        fill[index] = Convert.ToInt32(Console.ReadLine());
    }
}

void printArr (int[] print)
{
    int len = print.Length;
    int i= 0;
    string space = " ";
    Console.WriteLine();
    Console.Write("Сформированный массив: ");
    {
        for (i = 0; i < print.Length; i++)
        {
            Console.Write(print[i] + space);
        }
    }
}

int checkZero (int[] zero)
{
    int length = zero.Length;
    int j = 0;
    int count = 0;
    for (j = 0; j < zero.Length; j++)
    {
        if (zero[j] > 0)
        {
            count++;
        }
        if (zero[j] < 0)
        {
            continue;
        }
    }
    return count;
}

Console.Write("Введите размер массива: ");
int userData = Convert.ToInt32(Console.ReadLine());

int[] userArr = new int[userData];

FillArray(userArr);
printArr(userArr);
Console.WriteLine();

int res0 = checkZero(userArr);

Console.WriteLine();
Console.Write("Количество элементов массива, которые больше нуля: " + res0);
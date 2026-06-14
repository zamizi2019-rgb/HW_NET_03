Console.WriteLine("Задание 1");
int[] numbers1 = { 5, -2, 7, 0, 3, 8, -1, 4, 10, 2 };

Console.WriteLine("Вариант А");

Console.Write("Элементы: ");
for (int i = 0; i < numbers1.Length; i++)
{
    Console.Write(numbers1[i] + " ");
}
Console.WriteLine();

int sumA = 0;
for (int i = 0; i < numbers1.Length; i++)
{
    sumA = sumA + numbers1[i];
}
Console.WriteLine("Сумма элементов: " + sumA);

double averageA = (double)sumA / numbers1.Length;
Console.WriteLine("Среднее арифметическое: " + averageA);

int minA = numbers1[0];
for (int i = 1; i < numbers1.Length; i++)
{
    if (numbers1[i] < minA)
    {
        minA = numbers1[i];
    }
}
Console.WriteLine("Минимальный элемент: " + minA);

int maxA = numbers1[0];
for (int i = 1; i < numbers1.Length; i++)
{
    if (numbers1[i] > maxA)
    {
        maxA = numbers1[i];
    }
}
Console.WriteLine("Максимальный элемент: " + maxA);

int evenCountA = 0;
int oddCountA = 0;
for (int i = 0; i < numbers1.Length; i++)
{
    if (numbers1[i] % 2 == 0)
    {
        evenCountA = evenCountA + 1;
    }
    else
    {
        oddCountA = oddCountA + 1;
    }
}
Console.WriteLine("Количество чётных: " + evenCountA);
Console.WriteLine("Количество нечётных: " + oddCountA);

Console.WriteLine();
Console.WriteLine("Вариант B");

Console.Write("Элементы: ");
for (int i = 0; i < numbers1.Length; i++)
{
    Console.Write(numbers1[i]);
    if (i < numbers1.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine();

int sumB = 0;
int minB = numbers1[0];
int maxB = numbers1[0];
int evenCountB = 0;
int oddCountB = 0;

for (int i = 0; i < numbers1.Length; i++)
{
    sumB = sumB + numbers1[i];

    if (numbers1[i] < minB)
    {
        minB = numbers1[i];
    }

    if (numbers1[i] > maxB)
    {
        maxB = numbers1[i];
    }

    if (numbers1[i] % 2 == 0)
    {
        evenCountB = evenCountB + 1;
    }
    else
    {
        oddCountB = oddCountB + 1;
    }
}

double averageB = (double)sumB / numbers1.Length;

Console.WriteLine("Сумма элементов: " + sumB);
Console.WriteLine("Среднее арифметическое: " + averageB);
Console.WriteLine("Минимальный элемент: " + minB);
Console.WriteLine("Максимальный элемент: " + maxB);
Console.WriteLine("Количество чётных: " + evenCountB);
Console.WriteLine("Количество нечётных: " + oddCountB);
/*
 -------------------------------------------------------------------------------------------------
*/
Console.WriteLine();
Console.WriteLine("Задание 2");

Random rnd = new Random();
int[] numbers2 = new int[15];
for (int i = 0; i < numbers2.Length; i++)
{
    numbers2[i] = rnd.Next(-100, 100);
}

int[] numbers2ForB = new int[15];
for (int i = 0; i < numbers2.Length; i++)
{
    numbers2ForB[i] = numbers2[i];
}

Console.WriteLine("Вариант А");

Console.Write("Исходный массив: ");
for (int i = 0; i < numbers2.Length; i++)
{
    Console.Write(numbers2[i] + " ");
}
Console.WriteLine();

int posCountA = 0;
int negCountA = 0;
int zeroCountA = 0;

for (int i = 0; i < numbers2.Length; i++)
{
    if (numbers2[i] > 0)
    {
        posCountA++;
    }
    else if (numbers2[i] < 0)
    {
        negCountA++;
    }
    else
    {
        zeroCountA++;
    }
}
Console.WriteLine("Положительных: " + posCountA);
Console.WriteLine("Отрицательных: " + negCountA);
Console.WriteLine("Равных 0: " + zeroCountA);

for (int i = 0; i < numbers2.Length; i++)
{
    if (numbers2[i] < 0)
    {
        numbers2[i] = 0;
    }
}

int maxValA = numbers2[0];
int maxIdxA = 0;
for (int i = 1; i < numbers2.Length; i++)
{
    if (numbers2[i] > maxValA)
    {
        maxValA = numbers2[i];
        maxIdxA = i;
    }
}

Console.Write("Массив после замены отрицательных на 0: ");
for (int i = 0; i < numbers2.Length; i++)
{
    Console.Write(numbers2[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Индекс первого максимального элемента: " + maxIdxA + " со значением " + maxValA);

Console.WriteLine();
Console.WriteLine("Вариант B");

Console.Write("Исходный массив: ");
for (int i = 0; i < numbers2ForB.Length; i++)
{
    Console.Write(numbers2ForB[i]);
    if (i < numbers2ForB.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine();

int posCountB = 0;
int negCountB = 0;
int zeroCountB = 0;

for (int i = 0; i < numbers2ForB.Length; i++)
{
    if (numbers2ForB[i] > 0) posCountB++;
    else if (numbers2ForB[i] < 0) negCountB++;
    else zeroCountB++;
}

Console.WriteLine("Положительных: " + posCountB);
Console.WriteLine("Отрицательных: " + negCountB);
Console.WriteLine("Равных 0: " + zeroCountB);

for (int i = 0; i < numbers2ForB.Length; i++)
{
    if (numbers2ForB[i] < 0)
    {
        numbers2ForB[i] = 0;
    }
}

int maxValB = numbers2ForB[0];
int maxIdxB = 0;
for (int i = 1; i < numbers2ForB.Length; i++)
{
    if (numbers2ForB[i] > maxValB)
    {
        maxValB = numbers2ForB[i];
        maxIdxB = i;
    }
}

Console.Write("Массив после замены отрицательных на 0: ");
for (int i = 0; i < numbers2ForB.Length; i++)
{
    Console.Write(numbers2ForB[i]);
    if (i < numbers2ForB.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine();
Console.WriteLine("Индекс первого максимального элемента: " + maxIdxB + " со значением " + maxValB);
/*
 -------------------------------------------------------------------------------------------------
*/
Console.WriteLine();
Console.WriteLine("Задание 3");

int[] numbers3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int[] numbers3ForB = new int[10];
for (int i = 0; i < numbers3.Length; i++)
{
    numbers3ForB[i] = numbers3[i];
}

Console.WriteLine("Вариант А");

Console.Write("Исходный массив: ");
for (int i = 0; i < numbers3.Length; i++)
{
    Console.Write(numbers3[i] + " ");
}
Console.WriteLine();

int firstElemBeforeA = numbers3[0];
Console.WriteLine("Первый элемент до переворота: " + firstElemBeforeA);

int half = numbers3.Length / 2;
for (int i = 0; i < half; i++)
{
    int tmp = numbers3[i];
    int rightSide = numbers3.Length - 1 - i;
    numbers3[i] = numbers3[rightSide];
    numbers3[rightSide] = tmp;
}

int firstElemAfterA = numbers3[0];

Console.Write("Массив после переворота: ");
for (int i = 0; i < numbers3.Length; i++)
{
    Console.Write(numbers3[i] + " ");
}
Console.WriteLine();
Console.WriteLine("Первый элемент после переворота: " + firstElemAfterA);

if (firstElemBeforeA != firstElemAfterA)
{
    Console.WriteLine("Первый элемент изменился");
}
else
{
    Console.WriteLine("Первый элемент не изменился");
}

Console.WriteLine();
Console.WriteLine("Вариант B");

Console.Write("Исходный массив: ");
for (int i = 0; i < numbers3ForB.Length; i++)
{
    Console.Write(numbers3ForB[i]);
    if (i < numbers3ForB.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine();

int firstElemBeforeB = numbers3ForB[0];
Console.WriteLine("Первый элемент до переворота: " + firstElemBeforeB);

int[] reversed = new int[numbers3ForB.Length];
int idx = 0;
for (int i = numbers3ForB.Length - 1; i >= 0; i--)
{
    reversed[idx] = numbers3ForB[i];
    idx++;
}

for (int i = 0; i < numbers3ForB.Length; i++)
{
    numbers3ForB[i] = reversed[i];
}

int firstElemAfterB = numbers3ForB[0];

Console.Write("Массив после переворота: ");
for (int i = 0; i < numbers3ForB.Length; i++)
{
    Console.Write(numbers3ForB[i]);
    if (i < numbers3ForB.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine();
Console.WriteLine("Первый элемент после переворота: " + firstElemAfterB);

if (firstElemBeforeB != firstElemAfterB)
{
    Console.WriteLine("Первый элемент изменился");
}
else
{
    Console.WriteLine("Первый элемент не изменился");
}
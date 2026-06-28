Console.WriteLine("Задание 1");
int Size = 10;
int[] numbers1 = new int[Size];

for (int i = 0; i < Size; i++)
{
    numbers1[i] = i;
}
Console.WriteLine("Вариант А");

Console.Write("Элементы: ");
for (int i = 0; i < numbers1.Length; i++)
{
    Console.Write(numbers1[i] + ", ");
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
for (int i = 0; i < Size; i++)
{
    Console.Write(numbers1[i] + ", ");
}
int sum = numbers1.Sum(x => x);
Console.WriteLine();
Console.WriteLine("Сумма элементов: " + sum);
double average = numbers1.Average(x => x);
Console.WriteLine("Среднее арифметическое: " + average);
int max = numbers1.Max();
Console.WriteLine("Максимальный элемент: " + max);
int min = numbers1.Min();
Console.WriteLine("Минимальный элемент: " + min);
int even = numbers1.Count(x => x % 2 == 0);
Console.WriteLine("Количество чётных: " + even);
int odd = numbers1.Count(x => x % 2 == 1);
Console.WriteLine("Количество нечётных: " + odd);

//-------------------------------------------------------------------------------------------------
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
    Console.Write(numbers2[i] + ", ");
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
    Console.Write(numbers2[i] + ", ");
}
Console.WriteLine();
Console.WriteLine("Индекс первого максимального элемента: " + maxIdxA + " со значением " + maxValA);

Console.WriteLine();
Console.WriteLine("Вариант B");
int posCountB = 0;
int negCountB = 0;
int zeroCountB = 0;

Console.Write("Исходный массив: ");
for (int i = 0; i < numbers2ForB.Length; i++)
{
    Console.Write(numbers2ForB[i] + ", ");
}
Console.WriteLine();

for (int i = 0; i < numbers2ForB.Length; i++)
{
    if (numbers2ForB[i] > 0)
    {
        posCountB++;
    }
    else if (numbers2ForB[i] < 0)
    {
        negCountB++;
    }
    else
    {
        zeroCountB++;
    }
}
Console.WriteLine("Положительных: " + posCountB);
Console.WriteLine("Отрицательных: " + negCountB);
Console.WriteLine("Равных 0: " + zeroCountB);
int maxValB = numbers2ForB.Max();
int maxIndexB = Array.IndexOf(numbers2ForB, maxValB);
Console.Write("Массив после замены отрицательных на 0:: ");
for (int i = 0; i < numbers2ForB.Length; i++)
{
    Console.Write(numbers2ForB[i] + ", ");
}
Console.WriteLine();
Console.WriteLine("Индекс первого максимального элемента: " + maxIndexB + " со значением " + maxValB);
Console.WriteLine();
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

Console.WriteLine();
Console.WriteLine("Вариант B");

Console.Write("Исходный массив: ");
Console.WriteLine(string.Join(", ", numbers3ForB));

int firstElemBeforeB = numbers3ForB[0];
Console.WriteLine("Первый элемент до переворота: " + firstElemBeforeB);

Array.Reverse(numbers3ForB);

int firstElemAfterB = numbers3ForB[0];

Console.Write("Массив после переворота: ");
Console.WriteLine(string.Join(", ", numbers3ForB));
Console.WriteLine("Первый элемент после переворота: " + firstElemAfterB);

if (firstElemBeforeB != firstElemAfterB)
{
    Console.WriteLine("Первый элемент изменился");
}
else
{
    Console.WriteLine("Первый элемент не изменился");
}

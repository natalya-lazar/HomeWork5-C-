//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//Решение:

/*int [] CreateRandomArray (int size)
{
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(100, 1000);

    return newArray;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

int FindEven (int [] array)
{
    int countEven = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
        countEven += 1;
return countEven;        
}

Console.WriteLine("Input array size: ");
int user_size = Convert.ToInt32(Console.ReadLine());

int [] user_array = CreateRandomArray(user_size);
ShowArray(user_array);
int user_even = FindEven(user_array);
Console.WriteLine($"Number of even elements is: {user_even}");
*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
//Решение:

/*int [] CreateRandomArray (int size, int min, int max)
{
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(min, max+1);

    return newArray;
}
void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}
int SumUneven(int [] array)
{
    int sum_uneven = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum_uneven += array[i];
    return sum_uneven;    
}
Console.WriteLine("Input array size: ");
int user_size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value of array elements: ");
int user_min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of array elements: ");
int user_max = Convert.ToInt32(Console.ReadLine());
int [] new_array = CreateRandomArray(user_size, user_min, user_max);
ShowArray(new_array);
int result = SumUneven(new_array);
Console.WriteLine($"Sum of array elements having uneven positions is: {result}");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
//Решение:

double [] CreateRandomArray (int size, int min, int max)
{
    double [] newArray = new double [size];
    for (int i = 0; i < size; i++)
    {newArray[i] = new Random().Next(min, max+1) + new Random().NextDouble();
     newArray[i] = Math.Round(newArray[i], 3);
    }
    return newArray;
}
void ShowArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}
double FindMax (double [] array)
{  int i = 0;
   double max = array[i];
    for (i = 0; i < array.Length; i++)
        if (array[i] > max)
            {max = array[i];}
return max;
}
double FindMin (double [] array)
{  int i = 0;
   double min = array[i];
    for (i = 0; i < array.Length; i++)
        if (array[i] < min)
            {min = array[i];}
return min;
}
Console.WriteLine("Input array size: ");
int user_size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min value of array elements: ");
int user_min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value of array elements: ");
int user_max = Convert.ToInt32(Console.ReadLine());
double [] user_array = CreateRandomArray(user_size, user_min, user_max);
ShowArray(user_array);
double result = FindMax(user_array) - FindMin(user_array);
Console.WriteLine($"The difference between the maximum array element ({FindMax(user_array)}) and minimum array element ({FindMin(user_array)}) is: {result}");
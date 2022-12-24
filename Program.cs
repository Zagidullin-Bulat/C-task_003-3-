﻿// Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N.
// Полученный массив вывести на экран.
// Указание: Вывод массива вынести в отдельную функцию.

Console.WriteLine ("Введите число: ");
int cube = Convert.ToInt32 (Console.ReadLine());

void Cube (int[] cube)
{
    int counter = 0;
    int length = cube.Length;
    while (counter <  length)
    {
        cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
        counter++;
    }
}

void PrintArry (int[] array1)
{
    int count = array1.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(array1[index]+ " ");
        index++;
    }
} 

int[] arry = new int [cube+1];
Cube (arry);
PrintArry (arry);
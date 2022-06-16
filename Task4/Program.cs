//**Задача 30:**
//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
//int[] ar=new int[8]
//FillArray(int[] array)


using System;
using static System.Console;


Clear();
int[] array = GetRandomArray(8,0,1);
WriteLine($"[{String.Join(",",array)}]");


//void PrintArray(int[] array);
//{
//    Write("[");
//    for(int i=0; i<Array.Length-1,i++);
//}


int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5



using System;
using static System.Console;


Clear();

Write("WWedite chislo : ");
int N = Convert.ToInt32(ReadLine());
int sum = NumDigits(N);

WriteLine($"Koloichestwo cifr = {sum}");


int NumDigits(int N)
{
    int result = 0;
    for(int i=0; i<=N;i++)
    {
        while(N>0)
        {
            N = N/10;
            i++;
    
        }
        result=i;
    }
    

    return result;
}
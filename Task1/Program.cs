using System;
using static System.Console;


Clear();

Write("WWedite chislo : ");

//int N = Convert.ToInt32(ReadLine());

WriteLine($"Summa chisel = {GetSum(Convert.ToInt32(ReadLine()))}");

//int sum=GetSum(N);
//WriteLine($"Summa chisel = {sum}");

int GetSum(int r)
{
    int result = 0;
    for(int i=1;i<=r;i++)
    {
        result+=i;
    }
    return result;
}
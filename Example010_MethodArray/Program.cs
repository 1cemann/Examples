using System;
using static System.Console;

Clear();


int[]array={1, 12, 31, 4, 18, 15, 16, 17, 18};

int n = array.Length;
int find=18;

int index=0;

while(index<n)
{
    if(array[index]==find)
    {
        WriteLine(index);
        break;
    }
    index++;
}


//!!!!!!!!!!!!!!!НАЙТИ Ный ЭЛЕМЕНТ МАССИВА!!!!!!!!!!!!!!!!!!!!!
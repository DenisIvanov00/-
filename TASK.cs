using System;
using static System.Console;

string[] firstArr = { "Hi", "Hello", "17", "qwerty", "..." };
int newArrSize = 0;
int counter = 0;
for (int i = 0; i < firstArr.Length; i++)
{
    if (firstArr[i].Length <= 3)
        newArrSize++;
}
string[] newArr = new string[newArrSize];
for (int i = 0; i < firstArr.Length; i++)
{
    if (firstArr[i].Length <= 3)
    {
        newArr[counter] = firstArr[i];
        counter++;
    }
}
Write(String.Join(" ", newArr));
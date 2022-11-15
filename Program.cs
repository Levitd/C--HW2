using System;
using static System.Console;

Clear();

//Задача 10
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*
Write("Введите Трехзначное число: ");
int number = Convert.ToInt32(ReadLine());

if (number > 99 && number < 1000)
{
    WriteLine($"Вторя цифра от введенного числа: {DecNumber(number)}");
}
else
{
    WriteLine($"Введенное число не трехзначное");
}

int DecNumber(int num)
{
    return num / 10 - num / 100 * 10;
}
*/
//---------------------------------------------------------------------------

//Задача 13
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Write("Введите число: ");
try
{
    int number = Convert.ToInt32(ReadLine());

    int result = Digit3(number);
    if (result == -1)
    {
        WriteLine($"Третьей цифры нет");
    }
    else
    {
        WriteLine($"Третья цифра от введенного числа: {result}");
    }

}
catch (OverflowException)
{
    Console.Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Console.Write("Ожидалось число! Ввели не число!");
}

int Digit3(int num)
{
    //Так как в условии нет, что заданное число положительное, а знак числа не является цифрой, то искать будем именно третью цифру.
    //Для этого будем оперировать абсолютным значением введеного числа 
    num = Math.Abs(num);

    int lenhgtNumber = num.ToString().Length;

    if (lenhgtNumber < 3)
    {
        return -1;
    }
    else
    {

        while (lenhgtNumber > 3)
        {
            num = num / 10;
            lenhgtNumber--;
        }
        return num % 10;
    }
}
*/
// -----------------------------------------------------------------------------------------
//Задача 15
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Write("Введите число, обозначающее день недели: ");
try
{
    int number = Convert.ToInt32(ReadLine());

    Holiday(number);
    
}
catch (OverflowException)
{
    Console.Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Console.Write("Ожидалось число! Ввели не число!");
}

void Holiday(int num){
if (num == 6 || num == 7)
    {
        WriteLine($"Да, это выходной");
    }
    else if (num >= 1 && num < 6)
    {
        WriteLine($"Нет, это не выходной");
    } else {
        WriteLine($"Введенное число не обозначет день недели!");
    }
}

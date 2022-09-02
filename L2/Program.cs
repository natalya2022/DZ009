/* Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

int SumNaturalNumbers(int numM, int numN)
{
    if (numM == numN)
    {
        return numM;
    }
    return numM + SumNaturalNumbers(numM + 1, numN);
}

void Main()
{
    int numM = Prompt("Введите значение М ");
    int numN = Prompt("Введите значение N ");
    if (numM < 1 && numN < 1)
    {
        System.Console.WriteLine("Решения задачи не существует");
        return;
    }
    if (numM < 1)       // Если вне диапазона, приводим к 1
    {
        numM = 1;
    }
    if (numN < 1)       // Если вне диапазона, приводим к 1
    {
        numN = 1;
    }
    if (numM > numN)        // Считаем от меньшего к большему
    {
        int temp = numM;
        numM = numN;
        numN = temp;
    }
    System.Console.WriteLine(SumNaturalNumbers(numM, numN));
}

Main();

/* Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29 */


int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

int AkkermanFunction(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    if(numM > 0 && numN == 0)
    {
        return AkkermanFunction(numM - 1, 1);
    }
        return AkkermanFunction(numM - 1, AkkermanFunction(numM, numN -1 ));
}

void Main()
{
    int numM = Prompt("Введите значение М ");
    int numN = Prompt("Введите значение N ");
    if (numM < 0 && numN < 0)
    {
        System.Console.WriteLine("Решения задачи не существует");
        return;
    }
    System.Console.WriteLine(AkkermanFunction(numM, numN));
}

Main();

void FillListNumbers(List<int> numbersToFill)
{
    string symbol = string.Empty;
    Console.Clear();
    Console.WriteLine("Для выхода нажмите 'q'.");
    Console.WriteLine("Введите число и нажмите Enter:");
    do
    {
        symbol = Console.ReadLine();

        if (symbol == "q")
            break;
        numbersToFill.Add(Convert.ToInt32(symbol));
    } while (true);

}

void PrintArray(List<int> numbersToPrint)
{
    Console.Write("[");
    for (int i = 0; i < numbersToPrint.Count(); i++)
    {
        Console.Write(numbersToPrint[i]);
        if (i < numbersToPrint.Count() - 1)
            Console.Write("   ");
    }
    Console.WriteLine("]");
}

int CountPositiveNumber(List<int> numbersToCount)
{
    int counter = 0;
    for (int i = 0; i < numbersToCount.Count(); i++)
    {
        if (numbersToCount[i] > 0)
            counter++;
    }
    return counter;
}


List<int> numberCollection = new List<int>();
FillListNumbers(numberCollection);
int amountPositiveInArray = CountPositiveNumber(numberCollection);

Console.WriteLine("В массиве:");
PrintArray(numberCollection);
Console.WriteLine("{0} чисел больше нуля", amountPositiveInArray);


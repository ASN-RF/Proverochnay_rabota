/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых 
   меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
   выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно 
   массивами. 
                    Примеры:
                    ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
                    ["1234", "1567", "-2", "computer science"] -> ["-2"]
                    ["Russia", "Denmark", "Kazan"] -> []. */
string[] ArrayVar0 = new string[] { };
string[] ArrayVar1 = new string[] { "hello", "2", "world", ":-)" };
string[] ArrayVar2 = new string[] { "1234", "1567", "-2", "computer science" };
string[] ArrayVar3 = new string[] { "Russia", "Denmark", "Kazan" };
void PrintArrayVar(string[] array0) // ПЕЧАТЬ Заданных массивов в примере
{
    Console.Write("['");
    var str = string.Join("', '", array0);
    Console.Write(str);
    Console.Write("'] --> [");
}
void PrintArray(string[] array1) // Печать массива
{
    int count = 0;
    for (int i = 0; i < array1.Length - 1; i++)
    {
        if (String.IsNullOrWhiteSpace(array1[i]))
        {
            Console.Write("");
        }
        else
        {
            if (count > 0) Console.Write(",");
            count++;
            Console.Write($"'{array1[i]}'");
        }
    }
    for (int i = array1.Length - 1; i < array1.Length; i++)
        if (array1.Length < 2) Console.Write($"'{array1[i]}']");
        else
        {
            if (String.IsNullOrWhiteSpace(array1[i]))
            {
                Console.Write("]");
            }
            else
            {
                Console.Write($",'{array1[i]}']");
            }
        }
    Console.WriteLine();
}
void FormatArray(string[] array1) // Форматирование массива
{
    for (int i = 0; i < array1.Length; i++)
    {
        string ElementOut = array1[i];
        if (ElementOut.Length <= 3)
        {
            array1[i] = ElementOut;
        }
        else array1[i] = string.Empty;
    }
}

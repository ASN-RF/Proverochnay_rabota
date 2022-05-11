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
Console.WriteLine("Здравствуйте! Как бы Вы хотели увидеть решения поставленной задачи?");
Console.WriteLine("Если хотете сами ввести символы, то введите слово -Да- и нажмите -Enter-");
Console.WriteLine("Если хотите чтобы были использованы символы из примера, то введите -Нет- и нажмите -Enter-!");
string? VariantVvoda = Console.ReadLine();
if (VariantVvoda != null) Console.WriteLine("Спасибо! Желаем приятной проверки задания!");
if (VariantVvoda!.ToLower() == "да" || VariantVvoda.ToLower() == "нет")
{
    if (VariantVvoda.ToLower() == "да")
    {
        Console.WriteLine("Введите Ваши элементы отделяя каждый объект с символами пробелом, либо запятой и нажмите -Enter-:");
        string[] ElementIn = Console.ReadLine()!.Split(new char[] { ' ', ',' },
                               StringSplitOptions.RemoveEmptyEntries);
        string[] ArrayVar4 = ElementIn;
        PrintArrayVar(ArrayVar4);
        FormatArray(ArrayVar4);
        PrintArray(ArrayVar4);
    }
    else
    {
        Console.WriteLine("В примере были приведены 3 варианта, просим выбрать один из них (введите номер и нажминте -Enter-");
        Console.WriteLine("1 -" + "[" + "hello, " + "2, " + "world, " + " :-)" + "]");
        Console.WriteLine("2 -" + "[" + "1234, " + "1567, " + "- 2, " + "computer science" + "]");
        Console.WriteLine("3 -" + "[" + "Russia, " + "Denmark, " + "Kazan" + "]");
        int Variant = Convert.ToInt32(Console.ReadLine());
        if (Variant == 1)
        {
            PrintArrayVar(ArrayVar1);
            FormatArray(ArrayVar1);
            PrintArray(ArrayVar1);
        }
        if (Variant == 2)
        {
            PrintArrayVar(ArrayVar2);
            FormatArray(ArrayVar2);
            PrintArray(ArrayVar2);
        }
        if (Variant == 3)
        {
            PrintArrayVar(ArrayVar3);
            FormatArray(ArrayVar3);
            PrintArray(ArrayVar3);
        }
        if (Variant < 1 || Variant > 3)
        {
            Console.WriteLine("Такого варианта нет! Game over!");
        }
    }
}
else
{
    Console.WriteLine("К сожалению, на данном этапе программа, не сможет удовлетворить Ваше любопытство, т.к. программа работает в границах от ДА до НЕТ. Просим выбрать из этих двух вариантов! Заранее спасибо!");
    Console.WriteLine("Game over!");
}

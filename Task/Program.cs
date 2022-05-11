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

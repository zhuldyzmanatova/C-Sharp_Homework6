# pragma warning disable

// Домашнее задание к уроку 6
// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.
// a b c => “abcdef”
// d e f
/*
char [,] elements = new char [,]{{'a', 'b', 'c',}, {'d', 'e', 'f'}};

string str = "";

void GetStringFromArray()
{
    for (int i = 0; i < elements.GetLength(0); i++)
    {
        for (int j = 0; j < elements.GetLength(1); j++)
        {
            str = str + elements[i,j];
        }
    }
    System.Console.WriteLine(str);
}
GetStringFromArray();
*/

// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.
// “aBcD1ef!-” => “abcd1ef!-”
/*
string str = "aBcD1ef!-";

void GetStringToLowers()
{
    for (int i = 0; i < str.Length; i++)
    {
        str = str.ToLower();
    }
    System.Console.WriteLine(str);
}
GetStringToLowers();
*/

// Задача 3: Задайте произвольную строку. 
// Выясните, является ли она палиндромом.
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да
/*
Console.WriteLine("Введите строчку");
string userInput = Console.ReadLine();
Console.Write(userInput);

bool IsPalindrome(string input)
{
    for (int i = 0; i < input.Length/2; i++) 
    {
        if (input[i] != input[input.Length-1-i])
        {
            return false;  
        }          
    }
    return true;
}
IsPalindrome(userInput);

if (IsPalindrome(userInput))
{
    Console.WriteLine(" => Да");
}
else
{
    Console.WriteLine(" => Нет");
}
*/

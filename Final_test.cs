// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. 

string[] EnterStringArray(string request)
{
    System.Console.Write($" {request} >> ");
    string response = Console.ReadLine() + " ";
    /*Консоль пожурила за возможное нулевое значение. пока не знаю, как такое правильно решать,
    поэтому просто добавила пробел */
    string[] userStringArray = response.Split(' ', ',');
    return (userStringArray);
}

void ArrayOutput(string[] arrayToDisplay)
{
    string result = ("");
    for (int i = 0; i < arrayToDisplay.Length; i++)
    {
        result = result + arrayToDisplay[i] + ", ";

    }

    result = result.TrimEnd(' ', ',') + ".";
    System.Console.WriteLine(result);

}

string[] ShortWordFinder(string[] arrayToTest)
{
    string shortWordString = string.Empty;
    for (int i = 0; i < arrayToTest.Length; i++)
    {
        if (arrayToTest[i].Length <= 3 && arrayToTest[i].Length > 0)
            shortWordString = shortWordString + arrayToTest[i] + " ";

    }
    string[] shortWordArray = shortWordString.Split(' ');
    return shortWordArray;

}



string[] shortWordArray = ShortWordFinder(EnterStringArray("Через пробел или запятую введите текст (какие-нибудь добрые слова, ну, или как пойдет... )"));
if (shortWordArray.Length > 1)
{
    System.Console.WriteLine("Записи в 3 символа или короче:");
    ArrayOutput(shortWordArray);
}
else System.Console.WriteLine("Похоже, коротких слов не нашлось(");


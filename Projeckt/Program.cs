// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string InputWords(string message)
{
    Console.WriteLine(message);
    string word = Console.ReadLine()!;
    return word;
}

string[] CreateArray(string message)
{
    Console.WriteLine(message);
    int count = Convert.ToInt32(Console.ReadLine());
    string[] arrayWords = new string[count];
    for (int i = 0; i < arrayWords.Length; i++)
    {
        arrayWords[i] = InputWords("Введите строку: ");
    }
    return arrayWords;
}

string[] CreateArrayLenWordsAreLessThenTree(string[] words)
{
    string strWords = "";
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length <= 3)
        {
            strWords += words[i]+"/t";
        }
    }
    strWords = strWords.Substring(0,strWords.Length-2);
    string[] arrayLenWordsAreLessThenTree = strWords.Split("/t");
    return arrayLenWordsAreLessThenTree;
}


string[] arrayWords = CreateArray("Введите количество строк: ");
string[] arrayWordlenLessTheree = CreateArrayLenWordsAreLessThenTree(arrayWords);
Console.Write($"[{string.Join(", ", arrayWords)}] --> [{string.Join(", ", arrayWordlenLessTheree)}]");

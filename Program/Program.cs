// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Console.Clear();
Console.Write("Введите количество элементов массива: ");
int num = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
string[] array = GetArray(num);
string[] array2 = GetNewArray(array);
PrintArray(array);
Console.Write(" --->> ");
PrintArray(array2);




static int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
string[] GetArray(int num)
{
    string[] result = new string[num];
    for (int i = 0; i < result.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        result[i] = Console.ReadLine();
    }
    return result;
}

string[] GetNewArray(string[] arr)
{
    int s = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            s++;
        }
    }
    string[] result = new string[s];
    s = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            result[s] = arr[i];
            s++;
        }
    }
    return result;

}

void PrintArray(string[] inArray)
{
    Console.Write($"['{String.Join("', '", inArray)}']");
}


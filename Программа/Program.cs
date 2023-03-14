// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
// коллекциями, лучше обойтись исключительно массивами.

string[] array = InitArray();
string[] result = FindNewArray(array, 3);

string[] FindNewArray(string[] input, int n) 
{
    string[] output = new string[CountNewArray(input, n)];
    for(int i = 0, j = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) 
        {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}

int CountNewArray(string[] input, int n) 
{
    int count = 0;
    for(int i = 0; i < input.Length; i++) 
    {
        if(input[i].Length <= n) 
        {
            count++;
        }
    }
    return count;
}

string[] InitArray() 
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");
/* Написать программу, которая из имеюшегося
 массива строк формирует массив из строк,
длина которых <=3 символа.
 */

Console.Clear(); 
void MethodInputArr(string[] InputArr)
{
    Console.Write($"Input array: ");
    for (int i = 0; i < InputArr.Length; i++) Console.Write($"{InputArr[i]} ");
    Console.WriteLine();
}

void MethodOutputArr(string[] OutputArr)
{
    Console.Write($"Output array: ");
    string[] newarr = new string[OutputArr.Length];
    for (int i = 0; i < OutputArr.Length; i++)
    {
        if (OutputArr[i].Length <= 3)
        {
            newarr[i] = OutputArr[i];
            Console.Write($"{newarr[i]} ");
        }
    }
    Console.WriteLine();
}

string[] array = { "world", "2", "+", ":-)" , "123", "^_^", "***","4444"};

Console.WriteLine();
MethodInputArr(array);
Console.WriteLine();
MethodOutputArr(array);
Console.WriteLine(); 
 

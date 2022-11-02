//  Напишите программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна трем символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] text = { "home", "789", "ver", "pusan", "9", "go", "=-0", "not", "Hi", "Hello" }; 
int newArrayLength = KnowLengthOfNewArray(text); 
string[] newArray = SortOutArray(text, newArrayLength); 
PrintArray(newArray);

void PrintArray(string[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int KnowLengthOfNewArray(string[] array2) 
{
    int count = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i].Length <= 3) count = count + 1;
    }
    return count;
}

string[] SortOutArray(string[] array3, int length) 
{
    string[] newArray = new string[length];
    int j = 0;
    for (int i = 0; i < array3.Length; i++)
    {
        if(array3[i].Length<=3)
        {
            newArray[j] = array3[i];
            j++;
        }
    }
    return newArray;
}



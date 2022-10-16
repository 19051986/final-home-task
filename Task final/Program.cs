//Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести 
//с клавиатуры, либо задать на старте выполнения алгоритма. При решение не 
//рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string ReadData(string line)
{
    //Выводим сообщение
    Console.WriteLine(line);
    string result = Console.ReadLine() ?? "";
    return result;
}

string[] GetArrayisString(string line)
{
    string[] stringArray = line.Split(",");
    return stringArray;
}

string[] GetArrayisArr(string[] array)
{
    int count = 0;
    string[] result = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            result[count] = array[i];
            count ++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}

//Печать одномерного массива
void Print1DArr(string[] arr)
{
    Console.Write("[{0}]", string.Join(",", arr));
}

// Исполнение программы
string[] stringsArray = GetArrayisString(ReadData("Введите массив через запятую:"));
Console.WriteLine();
Print1DArr(stringsArray);
Console.Write(" >> ");
Print1DArr(GetArrayisArr(stringsArray));
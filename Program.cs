int max=3;              // максимальная длина элементов


// создаем функцию считывания массива из консоли
string[] GetArrayStringConsole (string inConsoleSimbol)
{
    string[] arraySimbol = new string[inConsoleSimbol.Length];
    arraySimbol = inConsoleSimbol.Split(",");
    return arraySimbol;
}
// считаем количество элементов массива,длина которых меньше и равна заданной
int CountItems(string[] arr, int max)
{
    int count = 0;                                      // инициируем счетчик
    for (int i = 0; i < arr.Length; i++)                // проверяем длину элемента
    {
        if (arr[i].Length <= max) count++;              // увеличиваем счетчик
    }
    return count;                                       // возвращаем результат
}
// создаём новый массив и заполняем его элементами, длина которых меньше заданной
string[] NewArray(string[] arr, int max)
{
    int newArrayLenght = CountItems(arr, max);          // узнаем, сколько элементов массива меньше заданной длины
    string[] newArray = new string[newArrayLenght];     // создаем новый массив полученной длины
    int newArrayIndex = 0;                              // счетчик индексов нового массива
    for (int i = 0; i < arr.Length; i++)                // перебираем исходный массив
    {
        if (arr[i].Length <= max)                       // проверяем, подходит ли элемент массива заданным условиям
        {
            newArray[newArrayIndex] = arr[i];           // копируем элемент в новый массив
            newArrayIndex++;                            // увеличиваем индекс
        }
    }
    return newArray;                                    // возвращаем новый массив
}

// выводим массив в консоль в красивом формате
void PrintArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write('"');
        System.Console.Write(array[i]);
        System.Console.Write('"');
        if (i < array.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
}

// выводим итоговый результат
Console.Write("Введите набор символов через знак (,) : ");
string inStringSimbol = Console.ReadLine();
string[] arraySimbol = GetArrayStringConsole(inStringSimbol);
Console.WriteLine();
Console.WriteLine("Введенные символы : ");
PrintArray(arraySimbol);
Console.WriteLine();
Console.WriteLine("Итоговый массив со строками длиной меньше " + max +":");
string[] newArray = NewArray(arraySimbol, max);

PrintArray(newArray);
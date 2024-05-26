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
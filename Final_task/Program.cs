Console.Clear();
Console.Write("Введите необходимое количество строк? ");

string[] AskArray = new string[] { };
int value = Convert.ToInt32(Console.ReadLine());

AskArray = new string[value]; 
for (int i = 0; i < value; i++)
{
    Console.WriteLine($"Введите {i+1}-ю строку: ");
    string res = Convert.ToString(Console.ReadLine());
    AskArray[i] = res;
}

string[] TotalArray = new string[value];
int len = 3;
int n = 0;

for (int j = 0; j < value; j++)
{
    if (AskArray[j].Length <= len)
    {
        TotalArray[n] = AskArray[j];
        n++;
    }
}

// функция вывода массива

string PrintArray(string[] array)
{
    string result = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
    }

    return result;
}

Console.WriteLine("строки, длина которых меньше либо равна 3 символа:");
Console.WriteLine($"{PrintArray(TotalArray)}");

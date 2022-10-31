Console.Clear();
Console.Write("Сколько элементов Вы хотите ввести? ");

int value = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[value];
for (int i = 0; i < value; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    arrayStrings[i] = element;
}

string[] arrayFinal = new string[value];
int len = 3;
int pos = 0;

for (int j = 0; j < value; j++)
{
    if (arrayStrings[j].Length <= len)
    {
        arrayFinal[pos] = arrayStrings[j];
        pos++;
    }
}

// функция вывода массива
string PrintArray(string[] array)
{
    string result = string.Empty;
    result = "[ ";
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write(array[i] + " ");
        result += $"{array[i],1}";
       if (i < array.Length - 1) result += ", ";
    }

    result += " ]";
    return result;
}

Console.WriteLine("элементы массива, длина которых меньше либо равна 3 символа:");
Console.WriteLine($"{PrintArray(arrayFinal)}");
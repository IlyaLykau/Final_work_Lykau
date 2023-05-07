// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.Write("Введите количество элементов массива: ");
int mas = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[mas];

void CreateArray(string[] stringArray)
{
  for (int i = 0; i < stringArray.Length; i++)
  {
    Console.WriteLine($"Введите {i + 1} элемент массива");
    stringArray[i] = Console.ReadLine();
  }
  Console.WriteLine();
}

string[] FindSymbol(string[] stringArray)
{
  int count = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length <= 3)
      count++;
  }
  string[] rez = new string[count];
  int j = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length <= 3)
    {
      rez[j] = stringArray[i];
      j++;
    }
  }
  return rez;
}

void PrintArray(string[] stringArray)
{
  Console.Write("[");
  for (int i = 0; i < stringArray.Length; i++)
  {
    Console.Write($"'{stringArray[i]}'\t");
  }
  Console.Write("]");
  Console.WriteLine();
}

CreateArray(stringArray);
PrintArray(stringArray);
PrintArray(FindSymbol(stringArray));
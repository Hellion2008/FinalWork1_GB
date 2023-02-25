


string[] GetArray(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{i}: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

int GetNumber(string text)
{
  Console.Write(text);
  int number = int.Parse(Console.ReadLine());
  return number;
}

int size = GetNumber("Enter length of array: ");
Console.WriteLine("[" + String.Join(", ",GetArray(size)) + "]");

string [] array = new string [5] {"hello", "2", "world", "234", "23"};
string [] array2 = new string [ array.Length];

void NewArray (string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array2[count] = array[i];
        count++;
        }
    }
}
NewArray(array, array2);
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
NewArray(array, array2);
PrintArray(array2);
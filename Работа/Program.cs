string[] SravnenieSlov(string[] array)
{
    string[] list = new string[array.Length];
    int index=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            list[index] = array[i];
            index++;
        }
        for (int j = 0; j < list.Length&&j>index; j++)
        {
            list[j]=null;
        }
    }
    return list;
}
void PrintList(string[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        System.Console.WriteLine(list[i]);
        System.Console.WriteLine();
    }
}


string[] list = { "привет", "_+=", ":)", "world", "sun" };
PrintList(list);
System.Console.WriteLine();

PrintList(SravnenieSlov(list));





string[] SravnenieStrok(string[] array)
{
    string[] list = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            list[i] = array[i];
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
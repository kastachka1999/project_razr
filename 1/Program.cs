string[] start = { "hello", "git", "remote", "add" };


string[] end = new string[Create_Arr(start)];



int Create_Arr(string[] array)
{
    int a = 0;
    foreach (string el in array)
    {
        if (el.Length < 4)
        {
            a++;
        }
    }
    return a;
}

void Check(string[] array, string[] array2)
{
    for (int i = 0, j = 0; i < start.Length; i++)
    {
        if (array[i].Length < 4)
        {
            array2[j] = array[i];
            j++;
        }
    }
}
void Prewiev(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Check(start, end);
Prewiev(end);


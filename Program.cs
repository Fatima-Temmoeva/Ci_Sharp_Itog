Console.WriteLine("Enter massiv size");
int n = Convert.ToInt32(Console.ReadLine());
string[] massiv = new string[n];
Console.WriteLine();
Console.WriteLine("Enter massiv elements");

void WriteInArray(string[] array)
{
    for (int ind = 0; ind < array.Length; ind++)
    {
        array[ind] = (Console.ReadLine());
    }
}
void PrintToScreen(string[] arr)
{
    int index = 0;
    int dlina = arr.Length;
    while (index < dlina) 
    {
        Console.Write(arr[index] + " ");
        index++;
    }
}

string[] NewMassiv(string[] mas)
{
    string[] massiv2 = new string[mas.Length];
    int x = 0;
    for (int i = 0; i < mas.Length; i ++)
    {
        if (mas[i].Length <= 3)
        {
            massiv2[x] = massiv[i];
            x++;
        }
    }
    return massiv2;
}

WriteInArray(massiv);
Console.WriteLine();
Console.WriteLine("Massive");
PrintToScreen(massiv);
Console.WriteLine();
Console.WriteLine("Massive2");
string[] newmassiw = NewMassiv(massiv);
PrintToScreen(newmassiw);

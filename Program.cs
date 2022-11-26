string[] CreateStringArray()
{
    Console.WriteLine("Tape amount of strings");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
        {
        Console.WriteLine($"Tape string №{i+1}");
        array[i] = Console.ReadLine();
        }
    return array;
}

void ShowArray(string[] array)     
{
    for(int i = 0; i < array.Length; i++)     
        if (i == array.Length - 1)
        Console.Write(array[i] + ".");  
        else
        Console.Write(array[i] + ", ");       

    Console.WriteLine();  
}
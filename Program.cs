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

string[] CreateNewStringArray(string[] array)
{
    int j = 0;
    string[] newStringArray = new string[array.Length];
    for(int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            { 
                newStringArray[j] = array[i];
                j++;
            }   
        }
    return newStringArray;
}
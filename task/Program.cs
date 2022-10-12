string[] SelectWords(string[] array, int n)
{
    int count=0;    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= n)
        {   
            array[count] = array[i];  
            count++;          
        }
    }
    Array.Resize(ref array, count);
    return array;
}

void Print(string[] array)
{
    Console.Write("[" + string.Join(", ", array) + "]");
    Console.WriteLine();
}

string[] words = { "privet", ":))", "O_o", "Hiiiiii", "computer", "science", "hh" };
Print(SelectWords(words,3));
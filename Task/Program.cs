Console.Clear();

string[] array = new string [4]{"3", "defc", ":}!", "papaya"};

void PrintArray(string[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < arr.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
}

string[] ArrRes (string[] arr)
{
    int size = 0, index = 0;

    for (int j = 0; j < arr.Length; j++) 
        if (arr[j].Length <= 3) size++;

    string[] newArr = new string [size];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[index] = arr[i];
            index++;
        }
    }
    return newArr;
}

PrintArray(array);
PrintArray(ArrRes(array));

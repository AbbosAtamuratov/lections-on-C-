// See https://aka.ms/new-console-template for more information
int[] GenerateArray () 
{
    int[] array = new int [8];
    for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
}
    return array;

}

void PrintArray (int[] Array) 
{
    for(int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i] + " ");
    }
}

PrintArray(GenerateArray());


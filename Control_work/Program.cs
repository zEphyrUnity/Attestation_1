const int SMALL_WORD = 3;
String[] data = {"", "Hello", "Geek", "World", "Try", "", "Int", "or", "Double", "0"};
String[] smallWordArray = SmallWordFinder(data);

Print(data);
Console.Write(" -> ");
Print(smallWordArray);

string[] SmallWordFinder(string[] data)
{
    String[] smallWordArray = new String[0];
    int k = 0;

    for(int i = 0; i < data.Length; i++)
    {
        if(data[i].Length <= SMALL_WORD & data[i] != "") 
        {
            Array.Resize(ref smallWordArray, smallWordArray.Length + 1); 
            smallWordArray[k] = data[i]; 
            k++;
        }
    }

    return smallWordArray;
}

void Print(String[] data)
{
    Console.Write($"[{String.Join(", ", data.Select(element => "\"" + element + "\""))}]");
}
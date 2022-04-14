int[,] DeckCards()
{
    int[,] array = new int[4, 13];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int valueCard = 1;
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = valueCard;
            valueCard++;
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MixCard(int[,] array)
{
    for (int col = 0; col < array.GetLength(0); col++)
    {
        for (int str = 0; str < array.GetLength(1); str++)
        {
            int i = new Random().Next(0, 3);
            int j = new Random().Next(0, 12);
            int tempI = col;
            int tempJ = str;
            array[tempI,tempJ]=array[col, str];
            array[col, str] = array[i, j];
            array[i,j]=array[tempI,tempJ];

        }
    }
    return array;
}
PrintArray(DeckCards());
Console.WriteLine();
PrintArray(MixCard(DeckCards()));

int count = 0;
int max = 0;
for (int i = 1012; i <= 9638; i++)
{
    if ((i % 3 == 0) && (i % 11 != 0) && (i % 13 !=0) && (i % 17 != 0) && (i % 19 != 0)){
        max=i;
        count++;
    }
}
Console.WriteLine(count);
Console.WriteLine(max);
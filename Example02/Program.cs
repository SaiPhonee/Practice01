int requestNumber()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int CreateNumber(int leftBound, int rightBound)
{
    int number = new Random().Next(leftBound, rightBound);
    return number;
}
int CountInit(int count)
{
    count = 7;
    return count;
}
void Hello(int count)
{
    Console.WriteLine($"Добро пожаловать в игру УГАДАЙКА. Тебе дается {count} попыток чтобы отгадать число которое загадал компьютер");
}

int CountOfAttempts = CountInit(7);
int Secretnumber = CreateNumber(0, 101);
int PlayersNumber = 0;

void CheckCondition(int PlayersNumber, int SecretNumber, int GameInit)
{
    Hello(CountInit(7));
    while (CountOfAttempts > 0)
    {
        PlayersNumber = requestNumber();
        if (PlayersNumber == Secretnumber)
        {
            Console.WriteLine("Поздравляем! Вы выиграли");
            break;
        }
        else
        {
            CountOfAttempts--;
            if (PlayersNumber > Secretnumber)
            {
                Console.WriteLine($"Введенное число больше загаданного. У вас осталось {CountOfAttempts} попыток.  Попробуйте снова");
            }
            else
            {
                Console.WriteLine($"Введенное число меньше загаданного. У вас осталось {CountOfAttempts} попыток.  Попробуйте снова");
            }
        }
        if (CountOfAttempts == 0)
            Console.WriteLine("У вас закончились попытки. К сожалению вы проиграли");
    }
}


CheckCondition(PlayersNumber, CreateNumber(0, 101), CountOfAttempts);

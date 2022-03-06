int middleNumber(int num)
{
    num = num / 10;
    int answer = num % 10;
    return answer;
}

Console.WriteLine("Введите 3-х значное число");
int number = Convert.ToInt32(Console.ReadLine());
int result = middleNumber(number);

Console.WriteLine(result);
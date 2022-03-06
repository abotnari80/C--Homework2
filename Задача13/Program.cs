int thirdNumber(int x) {

    if (x > 99) {

        while (x > 999) {
            x = x / 10;
        }

        int answer = x % 10;
        return(answer);
    }

    else {
        return(10);
    }
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int ans = thirdNumber(number);
if (ans == 10) Console.WriteLine("Третьей цифры нет");
else Console.WriteLine(ans);
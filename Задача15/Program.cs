string weekends(int day)
{
    string weekend = "да";
    string workday = "нет";
    string error = "такого дня недели нет";

    if (day > 0 && day < 8)
    {
        if (day == 6 || day ==7)
            return weekend;
        else
            return workday;
    }
    else
    {
        return error;
    }

}

Console.WriteLine("Введите номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
string result = weekends(dayNumber);
Console.WriteLine(result);
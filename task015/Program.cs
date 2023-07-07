// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг",
"Пятница", "Суббота", "Воскресенье" };

int numberDay;
bool isValidNumberDay = false;

do
{
    Console.Write("Введите номер дня недели от 1 до 7: ");
    string input = Console.ReadLine();

    isValidNumberDay = int.TryParse(input, out numberDay);

    if (isValidNumberDay && numberDay >= 1 && numberDay <= 7)
    {
        break;
    }
    else
    {
        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 7!");
    }
}
while (!isValidNumberDay || numberDay < 1 || numberDay > 7);
numberDay--;
if (numberDay > 4) Console.WriteLine($"{daysOfWeek[numberDay]} является выходным днем!");
else
    Console.WriteLine($"{daysOfWeek[numberDay]} не является выходным днем!");
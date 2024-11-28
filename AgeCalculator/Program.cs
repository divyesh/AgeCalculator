// See https://aka.ms/new-console-template for more information
Console.WriteLine($"Age: {Age(DateTime.Today.AddYears(-11).AddDays(1),DateTime.Today)} Year(s)");

static int Age(DateTime from, DateTime to, int age = 0)
{
    DateTime next=from.AddYears(1).AddDays(-1);
    if(to<=next) return age;

    return Age(next.AddDays(1),to,++age);
}
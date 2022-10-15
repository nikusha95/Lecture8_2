// See https://aka.ms/new-console-template for more information

using System.Globalization;
using System.Threading.Channels;
using Properties;

int? x = null;

// string? s = null;
// Student? st = null;

Subject subject = new Subject("Math", 5);


Console.WriteLine(subject.Name);

string name = subject.Name;
subject.Name = "C#";

Console.WriteLine(subject.Credit);
subject.Credit = 8;

Console.WriteLine(subject.Credit);


Subject sub = new()
{
    Credit = 10,
    Level = 3
};

User u = new User()
{
    FirstName = "F",
    LastName = "l",
    Id = 12
};

Console.WriteLine(u.ToString());

DateTime date = new DateTime(2021, 12, 1, 15, 12, 0);

Console.WriteLine(date.ToString("F"));

date = date.AddDays(-1);

Console.WriteLine(date.ToString("F"));
Console.WriteLine(date.DayOfWeek);
Console.WriteLine(date.TimeOfDay);

var todayDate = DateTime.Now;

Console.WriteLine(todayDate.ToString("F"));
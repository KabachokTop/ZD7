using System;

class Course
{
    public string Name { get; set; }
    public int Duration { get; set; }  

    public Course(string name, int duration)
    {
        Name = name;
        Duration = duration;
    }

    public override string ToString()
    {
        return $"Курс: {Name}, тривалість: {Duration} год.";
    }
}

class OnlineCourse : Course
{
    public string Platform { get; set; }

    public OnlineCourse(string name, int duration, string platform)
        : base(name, duration)
    {
        Platform = platform;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Платформа: {Platform}.";
    }
}

class Program
{
    static void Main()
    {
        Course course = new Course("Програмування на C#", 60);
        OnlineCourse onlineCourse = new OnlineCourse("Основи ООП", 40, "Coursera");

        Console.WriteLine(course);
        Console.WriteLine(onlineCourse);
    }
}
public class Art
{
    public string Name;
    public string Author;
    public int Year;
    public string Place;

    public string Discription;

    public Art(string name, string author, int year)
    {
        Name = name;
        Author = author;
        Year = year;
        Place = "В нашей галерее";
        Discription = "Нет описания";
    }

    public void Print()
    {
        Console.WriteLine("-------------------");
        Console.WriteLine($"{Name} от {Author} ({Year})");
        Console.WriteLine($"Расположено {Place}");
        Console.WriteLine("-------------------");
        Console.WriteLine();

    }

    public void ChangePlace(string place)
    {
        Place = place;
    }

    public void ChangeYear(int year)
    {
        if (year > 2026)
        {
            return;
        }
        Year = year;
    }

    public void ChangeDiscription(string discription)
    {
        Discription = discription;
    }

    public string GetDiscription()
    {
        return Discription;
    }
}
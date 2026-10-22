public class Art
{
    public string Name;
    public string Author;
    public int Year;
    public string Place;

    public Art(string name, string author, int year)
    {
        Name = name;
        Author = author;
        Year = year;
        Place = "В нашей галерее";
    }

    public void Print()
    {
        Console.WriteLine($"{Name} от {Author} ({Year})");
    }
}
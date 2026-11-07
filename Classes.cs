public class Art
{
    private string _name = "Без названия";
    public string Name {
        get {
            return _name;
        }

        private set {
            if (string.IsNullOrWhiteSpace(value)) {
                _name = "Без названия";
                return;
            }

            _name = value.Trim();
        }
    }

    private string _author = "Неизвестно";
    public string Author {get
        {
            return _author;
        } private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                _author = "Неизвестно";
                return;
            }
            _author = value.Trim();

        }
    }
    private int _year;
    public int Year
    {
        get { return _year; }
        private set
        {
            if (value > 2026)
            {
                _year = 2026; 
                return;
            }
            _year = value;
        }
    }
    public string Place;

    public string Discription;

    public Art(string name, string author, int year)
    {
        Name = name;
        Author = author;
        this.Year = year;
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
        this.Year = year;
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
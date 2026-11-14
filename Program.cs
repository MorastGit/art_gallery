


Art art1 = new Art("Волга      ", "     Лена Шарова", 1999);
Art art2 = new Art("Цветы", "Врангель", 1987);
Art art3 = new Art("Деревья на закате", "Галина Левиченко", 2001);
Art art4 = new Art("Рассвет", "Александр Петров", 2025);

List<Art> arts = new List<Art>();
arts.Add(art1);
arts.Add(art2);
arts.Add(art3);
arts.Add(art4);
foreach (var art in arts)
{
    art.Print();
}

art1.ChangePlace("в лувре");
art3.ChangeYear(2222);
art2.ChangeYear(1300);

Art latestArt = arts[0];
Console.WriteLine("после изменений:");
foreach (Art art in arts)
{
    art.Print();
    if (art.Year > latestArt.Year)
    {
        latestArt = art;
    }
}
Console.WriteLine($"Самая поздняя картина: {latestArt.Name} ({latestArt.Year})");


if (arts.Count() > 0) {
    Console.WriteLine($"Первый: {arts[0].Name}");
    Console.WriteLine($"Последний: {arts[arts.Count() - 1].Name}");
}

art1.ChangeDiscription("Лена Шарова создала эту картину в году 1999 в рамках проекта «Волга»");
Console.WriteLine(art1.GetDiscription());

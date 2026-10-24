

Art art1 = new Art("Волга", "Лена Шарова", 1999);
Art art2 = new Art("Цветы", "Врангель", 1987);
Art art3 = new Art("Деревья на закате", "Галина Левиченко", 2001);

art1.Print();
art2.Print();
art3.Print();

art1.ChangePlace("в лувре");
art3.ChangeYear(2222);
art2.ChangeYear(1300);

Console.WriteLine("ПОСЛЕ");
art1.Print();
art2.Print();
art3.Print();





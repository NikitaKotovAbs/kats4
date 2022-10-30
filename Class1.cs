internal class Class1
{
  
    public static void Menu()
    {
        List<string> cake = new List<string>();
        Console.WriteLine("    Меню");
        cake.Add("Форма");
        cake.Add("Размер");
        cake.Add("Вкус");
        cake.Add("Количество");
        cake.Add("Глазурь");
        cake.Add("Декор");
        for (int i = 0; i < cake.Count; i++)
        {
            Console.WriteLine("   " + i + ".{0}", cake[i]);
        }
    }
    public static void Switch()
    {

        int position = 1;
        while (true)
        {
            Console.Clear();
            Menu();
            Console.SetCursorPosition(1, position);
            Console.WriteLine("->");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            if (key.Key == ConsoleKey.UpArrow)
            {
                position = position - 1;
            }
            if (key.Key == ConsoleKey.DownArrow)
            {
                position = position + 1;
            }
            if (position == 0)
            {
                position = position + 1;
            }
            if (position == 7)
            {
                position = position - 1;
            }
            if (position == 1 && key.Key == ConsoleKey.Enter)
            {
                Form();
            }
            if (position == 2 && key.Key == ConsoleKey.Enter)
            {
                Size();
            }
            if (position == 3 && key.Key == ConsoleKey.Enter)
            {
                taste();
            }
            if (position == 4 && key.Key == ConsoleKey.Enter)
            {
                quantity();
            }
            if (position == 5 && key.Key == ConsoleKey.Enter)
            {
                glaze();
            }
            if (position == 6 && key.Key == ConsoleKey.Enter)
            {
                decoration();
            }
        }

    }
    public static void Form()
    {

        Console.Clear();
        List<string> form = new List<string>();
        form.Add("Круг - 500");
        form.Add("Квадрат - 500");
        form.Add("Прямоугольник - 500");
        form.Add("Сердцечко - 700");
        Console.SetCursorPosition(0, 1);
        for (int i = 0; i < form.Count; i++)
        {
            Console.WriteLine("   " + i + ".{0}", form[i]);
        }
        Console.ReadLine();
        
    }
    public static void Size()
    {
        Console.Clear();
        List<string> Size1 = new List<string>();
        Size1.Add("Маленький (Диаметр - 16см, 8 порций) - 1000р");
        Size1.Add("Обычнчый (Диаметр - 18см, 10 порций) - 1200р");
        Size1.Add("Большой (Диаметр - 18см, 24 порций) - 2000р");
        Console.SetCursorPosition(0, 1);
        for (int i = 0; i < Size1.Count; i++)
        {
            Console.WriteLine("   " + i + ".{0}", Size1[i]);
        }
        Console.ReadLine();
    }
    
    public static void taste()
    {
        Console.Clear();
        List<string> taste = new List<string>();
        taste.Add("Ванильный - 100");
        taste.Add("Шоколадный - 400");
        taste.Add("Карамельный - 200");
        taste.Add("Ягодный - 250");
        Console.SetCursorPosition(0, 1);
        for (int i = 0; i < taste.Count; i++)
        {
            Console.WriteLine("   " + i + ".{0}", taste[i]);
        }
        Console.ReadLine();
    }
    public static void quantity()
    {
        Console.Clear();
        List<string> quantity = new List<string>();
        quantity.Add("Два коржа");
        quantity.Add("Три коржа");
        quantity.Add("Четыре коржа");
        quantity.Add("Пять коржей");
        Console.SetCursorPosition(0, 1);
        for (int i = 0; i < quantity.Count; i++)
        {
            Console.WriteLine("   " + i + ".{0}", quantity[i]);
        }
        Console.ReadLine();
    }
    public static void glaze()
    {
        Console.Clear();
        List<string> glaze1 = new List<string>();
        glaze1.Add("Шоколад");
        glaze1.Add("Крем");
        glaze1.Add("Бизе");
        glaze1.Add("Драже");
        Console.SetCursorPosition(0, 1);
        for (int i = 0; i < glaze1.Count; i++)
        {
            Console.WriteLine("   " + i + ".{0}", glaze1[i]);
        }
        Console.ReadLine();
    }
    public static void decoration()
    {
        Console.Clear();
        List<string> decoration = new List<string>();
        decoration.Add("Шоколадный");
        decoration.Add("Ягодный");
        decoration.Add("С бобром");
        decoration.Add("Кремовый");
        Console.SetCursorPosition(0, 1);
        for (int i = 0; i < decoration.Count; i++)
        {
            Console.WriteLine("   " + i + ".{0}", decoration[i]);
        }
        Console.ReadLine();
    }
}
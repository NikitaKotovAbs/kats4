
    internal class Class2
    {
    public static void Switch2()
    {

        int position = 1;
        while (true)
        {
            Console.Clear();
            /*Menu();*/
            Console.SetCursorPosition(0, position);
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
            if (position == 4)
            {
                position = position - 1;
            }
            
            
        }

    }
}


using System;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int vibor = 0;
                int end = 8;
                Music catalog = new Music();
                catalog.AddDisc("Лучшее 2022");
                catalog.AddSong("Лучшее 2022", "Miyagi", "Captain");
                catalog.AddSong("Лучшее 2022", "Miyagi", "I Got Love");

                catalog.AddDisc("Поп Микс");
                catalog.AddSong("Поп Микс", "Dua Lipa", "Levitating");
                catalog.AddSong("Поп Микс", "The Weeknd", "Take My Breath");


                catalog.PrintCatalog();
                while (vibor != 8)
                {
                    Console.WriteLine("Выберите действие");
                    Console.WriteLine("1-Добавление диска");
                    Console.WriteLine("2-Добавление песни");
                    Console.WriteLine("3-Удаление диска");
                    Console.WriteLine("4-Удаление песни");
                    Console.WriteLine("5-Вывод содержания диска");
                    Console.WriteLine("6-Поиск по исполнителю");
                    Console.WriteLine("7-Показать каталог");
                    Console.WriteLine("8-Выход");


                    vibor = int.Parse(Console.ReadLine());
                    if (vibor == 1)
                    {
                        Console.WriteLine("Введите название диска");
                        string nazvDiska = Console.ReadLine();
                        catalog.AddDisc(nazvDiska);
                    }
                    else if (vibor == 2)
                    {
                        Console.WriteLine("Введите название диска в который хотите добавить песню");
                        string nazvDis = Console.ReadLine();
                        Console.WriteLine("Введите Исполнителя");
                        string ispoln = Console.ReadLine();
                        Console.WriteLine("Введите название песни");
                        string nazvMusica = Console.ReadLine();
                        catalog.AddSong(nazvDis, ispoln, nazvMusica);
                    }
                    else if (vibor == 3)
                    {
                        Console.WriteLine("Введите названия диска который хотите удалить");
                        string delDisk = Console.ReadLine();
                        catalog.RemoveDisc(delDisk);
                    }
                    else if (vibor == 4)
                    {
                        Console.WriteLine("Введите названия диска для удаления песни");
                        string nazvDisk = Console.ReadLine();
                        Console.WriteLine("Введите Исполнителя");
                        string ispolnitel = Console.ReadLine();
                        Console.WriteLine("Введите название песни из диска");
                        string navzMusic = Console.ReadLine();

                        catalog.RemoveSong(nazvDisk, ispolnitel, navzMusic);
                    }
                    else if (vibor == 5)
                    {
                        Console.WriteLine("Введите название диска для вывода его содержимого");
                        string findDisk = Console.ReadLine();
                        catalog.PrintDisc(findDisk);
                    }
                    else if (vibor == 6)
                    {
                        Console.WriteLine("Введите исполнителя для поиска");
                        string findInspolnitel = Console.ReadLine();
                        catalog.SearchByArtist(findInspolnitel);
                    }
                    else if (vibor == 7)
                    {
                        catalog.PrintCatalog();
                    }
                    else if (vibor == 8)
                    {
                        vibor = end;
                    }
                }
            }catch
            {
                Console.WriteLine("Неверный ввод");
            }
            
            


            //Console.WriteLine("Введите названия диска который хотите удалить");
            //string delDisk = Console.ReadLine();
            //catalog.RemoveDisc(delDisk);
            //Console.WriteLine("Введите названия диска для удаления песни");
            //string nazvDisk = Console.ReadLine();
            //Console.WriteLine("Введите Исполнителя");
            //string ispolnitel = Console.ReadLine();
            //Console.WriteLine("Введите название песни из диска");
            //string navzMusic = Console.ReadLine();

            //catalog.RemoveSong(nazvDisk,ispolnitel, navzMusic);


            //Console.WriteLine("Введите название диска для вывода его содержимого");
            //string findDisk = Console.ReadLine();
            //catalog.PrintDisc(findDisk);


            //Console.WriteLine("Введите исполнителя для поиска");
            //string findInspolnitel = Console.ReadLine();
            //catalog.SearchByArtist(findInspolnitel);

            //catalog.PrintCatalog();
        }
    }
}

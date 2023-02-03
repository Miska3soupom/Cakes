using System.ComponentModel.DataAnnotations;
using System.Text;
using System.IO;

namespace Cakes
{
    internal class Program
    {
        static Arrows Strelki = new Arrows();
        static Cakes Tort = new Cakes();
        static List<string> Form = new List<string>() { "Квадратная - 200", "Круглая - 180", "Конус - 250", "Фигурная - 300" };
        static List<string> Size = new List<string>() { "Маленький - 150", "Средний - 180", "Большой - 210", "Свой - 260" };
        static List<string> Taste = new List<string>() { "Карамельный - 80", "Клубничный - 100", "Тропический - 150", "Кремовый - 120", "Фруктовый - 140" };
        static List<string> Korz = new List<string>() { "Один - 50", "Два - 90", "Три - 130" };
        static List<string> Eyes = new List<string>() { "Карамельная - 80", "Шоколадная - 70", "Без глазури - 0" };
        static List<string> Decor = new List<string>() { "Обычный - 100", "День рожденья - 190", "Свадебный - 300", "Праздничный - 240" };
        static int position, underpos, FPrice, GPrice, KPrice, DPrice, SPrice, TPrice;
        static string path = "C:\\Users\\misha\\OneDrive\\Рабочий стол\\Заказ.txt";
        static void Main(string[] args)
        {
            do
            {
                position = Strelki.ArrowsPick(9, 2);
                underpos = ChooseFunc(position);
                if (underpos != 0 && position != 9)
                {
                    AppendText(position, underpos);
                }
            } while (position != 9);
            Tort.Price = FPrice + SPrice + TPrice + KPrice + GPrice + DPrice;
            if (File.Exists(path))
            {
                File.WriteAllText(path, $"Ваш заказ:\n{Tort.Forme}, {Tort.Size}, {Tort.Taste}, {Tort.Bread}, {Tort.Addition}, {Tort.Decoration}\nИтоговая цена: {Tort.Price}");
            }
            else
            {
                File.Create(path);
                File.WriteAllText(path, $"Ваш заказ:\n{Tort.Forme}, {Tort.Size}, {Tort.Taste}, {Tort.Bread}, {Tort.Addition}, {Tort.Decoration}\nИтоговая цена: {Tort.Price}");
            }
            

        }

        public void MainMenu()
        {
            List<string> Choose = new List<string>() { "Форма", "Размер", "Вкус", "Количество коржей", "Глазурь", "Декор", "Завершить сборку" };
            Arrows ChArrow = new Arrows();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Добро пожаловать в мкондитерскую УМихалыча!\nСоберите свой торт по следующим параметрам" +
            "\n-----------------------------");
            int Place = 3;
            foreach (string ChName in Choose)
            {
                Console.SetCursorPosition(3, Place);
                Console.WriteLine(ChName);
                Place++;
            }
            return;
        }

        public static int ChooseFunc(int Position)
        {
            int UnderPos = 0;
            switch (Position) 
            {
                case 3:
                    UnderPos = Strelki.ArrowsPick(Form.Count + 2, 2);
                    break;
                case 4:
                    UnderPos = Strelki.ArrowsPick(Size.Count + 2, 2);
                    break;
                case 5:
                    UnderPos = Strelki.ArrowsPick(Taste.Count + 2, 2);
                    break;
                case 6:
                    UnderPos = Strelki.ArrowsPick(Korz.Count + 2, 2);
                    break;
                case 7:
                    UnderPos = Strelki.ArrowsPick(Eyes.Count + 2, 2);
                    break;
                case 8:
                    UnderPos = Strelki.ArrowsPick(Decor.Count + 2, 2);
                    break;
                case 9:
                    Console.WriteLine("Вы завершили сборку торта)");
                    UnderPos = -1;
                    break;
            }
            return UnderPos;
        }

        public void UnderMenu()
        {
            Console.SetCursorPosition(0,0);
            switch (position)
            {
                case 3:
                    Console.WriteLine("Форма торта\nВыбирите из доступных вариатнов:\n----------------------------");
                    Vivod(Form);
                    break;
                case 4:
                    Console.WriteLine("Размер торта\nВыбирите из доступных вариатнов:\n----------------------------");
                    Vivod(Size);
                    break;
                case 5:
                    Console.WriteLine("Вкус торта\nВыбирите из доступных вариатнов:\n----------------------------");
                    Vivod(Taste);
                    break;
                case 6:
                    Console.WriteLine("Количество коржей в торте\nВыбирите из доступных вариатнов:\n----------------------------");
                    Vivod(Korz);
                    break;
                case 7:
                    Console.WriteLine("Глазурь\nВыбирите из доступных вариатнов:\n----------------------------");
                    Vivod(Eyes);
                    break;
                case 8:
                    Console.WriteLine("Декор торта\nВыбирите из доступных вариатнов:\n----------------------------");
                    Vivod(Decor);
                    break;
            }
        }

        private static void Vivod(List<string> vivod)
        {
            int i = 3;
            foreach (string name in vivod)
            {
                Console.SetCursorPosition(3, i);
                Console.WriteLine(name);
                i++;
            }
        }

        private static void AppendText(int Menu, int PodMenu)
        {
            switch (Menu)
            {
                case 3:
                    Tort.Forme = Form[PodMenu-3];
                    switch (PodMenu-3)
                    {
                        case 0: FPrice = 200; break;
                        case 1: FPrice = 180; break;
                        case 2: FPrice = 250; break;
                        case 3: FPrice = 300; break;
                    }
                    break; 
                case 4:
                    Tort.Size = Size[PodMenu-3];
                    switch (PodMenu - 3)
                    {
                        case 0: SPrice = 150; break;
                        case 1: SPrice = 180; break;
                        case 2: SPrice = 210; break;
                        case 3: SPrice = 260; break;
                     }
                    break;
                case 5:
                    Tort.Taste = Taste[PodMenu-3];
                    switch (PodMenu - 3)
                    {
                        case 0: TPrice = 80; break; 
                        case 1: TPrice = 100; break; 
                        case 2: TPrice = 150; break; 
                        case 3: TPrice = 120; break; 
                    }
                    break;
                case 6:
                    Tort.Bread = Korz[PodMenu - 3];
                    switch (PodMenu-3)
                    {
                        case 0: KPrice = 50; break;
                        case 1: KPrice = 90; break;
                        case 2: KPrice = 130; break;
                    }
                    break;
                case 7:
                    Tort.Addition = Eyes[PodMenu-3];
                    switch (PodMenu - 3)
                    {
                        case 0: GPrice = 80; break;
                        case 1: GPrice = 70; break;
                        case 2: GPrice = 0; break;
                    }
                    break;
                case 8:
                    Tort.Decoration = Decor[PodMenu - 3];
                    switch (PodMenu - 3)
                    {
                        case 0: DPrice = 100; break;
                        case 1: DPrice = 190; break;
                        case 2: DPrice = 300; break;
                        case 3: DPrice = 240; break;
                    }
                    break;
            }
        }
    }
}
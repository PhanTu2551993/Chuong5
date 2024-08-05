using System.Text;

namespace _5._3
{
    class CD
    {
                public string CDName { get; set; }
                public string CDType { get; set; }
                public double  CDPrice { get; set; }

        public CD(string cDName, string cDType, double cDPrice)
        {
            CDName = cDName;
            CDType = cDType;
            CDPrice = cDPrice;
        }

        public CD()
        {
        }
    }

    internal class Program
    {
        const int MaxCd = 1000;
        static int currentCount = 0;
        static CD[] catalog = new CD[MaxCd];
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int choice;

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("---------------------------");
                Console.WriteLine("1. ADD CD");
                Console.WriteLine("2. Search CD");
                Console.WriteLine("3. Display catalog");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Your choice 1 - 4 ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddCD();
                        break;
                    case 2:
                        SearchCD();
                        break;
                    case 3:
                        DisplayCD();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please choose again.");
                        break;
                }
            }while (true);
        }

        static void AddCD()
        {
            if (currentCount >= MaxCd)
            {
                Console.WriteLine("Ổ đĩa đã đầy. Không thể thêm mới");
            }

            Console.WriteLine("Nhập CD Name ");
            string name = Console.ReadLine();
            Console.WriteLine("Nhập CD Type ");
            string type = Console.ReadLine();
            Console.WriteLine("Nhập CD price ");
            double price = double.Parse(Console.ReadLine());

            CD newCD = new CD(name, type, price);
            catalog[currentCount] = newCD;
            currentCount++;
            Console.WriteLine("Thêm mới CD thành công");
        }

        static void SearchCD()
        {
            Console.WriteLine("Nhập tên CD muốn tìm");
            string nameSearch = Console.ReadLine();

            bool check = false;

            for (int i = 0; i < currentCount; i++)
            {
                  if (nameSearch.Equals(catalog[i].CDName))
                {
                    check = true;
                    Console.WriteLine($"CD Name: {catalog[i].CDName}\t CD Type : {catalog[i].CDType} \tCD Price : {catalog[i].CDPrice}");
                }
            }

            if (!check)
            {
                Console.WriteLine($"Không tìm thấy CD có tên {nameSearch}");
            }
          
        }

        static void DisplayCD()
        {
            if (currentCount == 0)
            {
                Console.WriteLine("The catalog is empty.");
                return;
            }
            for (int i = 0; i < currentCount; i++)
            {
                if (catalog[i] != null)
                {
                    Console.WriteLine($"{i + 1}\t{catalog[i].CDName}\t{catalog[i].CDType}\t{catalog[i].CDPrice} VND");
                }
            }
        }
    }
}

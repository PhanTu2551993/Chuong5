using System.Text;

namespace Chuong5
{
    class Item
    {
        private int id;
        private string name;
        private float price;
        private int quantity;

        public Item()
        {
        }

        public Item(int id, string name, float price, int quantity)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public float TotalValue()
        {
            return Price * Quantity;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Item[] items = new Item[5];

            // Nhập chi tiết cho 5 món hàng 

            for (int i = 0; i < 5; i++)
            {
                items[i] = new Item();
                Console.WriteLine($"Nhập thông tin cho sản phẩm thứ {i + 1}");
                Console.WriteLine("Nhập mã số");
                items[i].Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập tên hàng");
                items[i].Name = Console.ReadLine();
                Console.WriteLine("Nhập giá tiền");
                items[i].Price = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhập số lượng");
                items[i].Quantity = int.Parse(Console.ReadLine());

            }

            // Hiển thị tên từng món hàng và tổng giá trị của nó
            Console.WriteLine("\nChi tiết từng món hàng:");
            foreach (var item in items)
            {
                Console.WriteLine($"Tên sản phẩm : {item.Name},Tổng giá trị : {item.TotalValue()}");
            }


            float totalProduct = 0;

            foreach (var item in items)
            {
                totalProduct += item.TotalValue();
            }

            Console.WriteLine($"\n Tổng giá trị kho hàng : {totalProduct}");

        }
    }
}

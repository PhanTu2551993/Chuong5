using System.Text;

namespace _5._2
{
    class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Student()
        {
        }

        public Student(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Student[] students = new Student[5];
            for (int i = 0; i < 5; i++)
            {
                 students[i] = new Student();
                Console.WriteLine($"Nhập tên sinh viên thứ : {i+1}");
                students[i].Name = Console.ReadLine();
                Console.WriteLine($"Nhập điếm sv thứ : {i+1}");
                students[i].Score = int.Parse(Console.ReadLine());

            }

            Array.Sort(students, (x, y) => y.Score.CompareTo(x.Score));

            Console.WriteLine("3 sinh viên có điểm số cao nhất");
            for (int i = 0; i < 3 && i < students.Length; i++)
            {
                Console.WriteLine($"Sv : {students[i].Name}, Điểm : {students[i].Score}");
            }
        }
    }
}

using Management.Application.Services;
namespace Management.Client
{
    internal class Program
    {
        static string[] students = new string[12];
        static int count = 0;

        static void Main(string[] args)
        {
             int urinishlar = 0;
            bool access = false;

            do
            {
                Console.Clear();
                Console.WriteLine(" TIZIMGA KIRISH");
                Console.Write("Parolngizni kiriting: ");
                string password = Console.ReadLine();

                if (password == "1234")
                {
                    access = true;
                    break;
                }
                else
                {
                    urinishlar++;
                    Console.WriteLine(" Parol noto‘g‘ri!");
                    Console.WriteLine($" Qolgan urinishlar" +"soni" +$" {3 - urinishlar}ta:");
                    Console.ReadLine();
                }

            } while (urinishlar < 3);

            if (!access)
            {
                Console.WriteLine("\n Urinishlar soni tugadi. Dastur yopildi!");
                return;
            }
            string choice;
            do
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════╗");
                Console.WriteLine("║       TALABALAR QABULI       ║");
                Console.WriteLine("╠══════════════════════════════╣");
                Console.WriteLine("║ 1   Ro‘yxatdan o‘tish        ║");
                Console.WriteLine("║ 2   Ro‘yxatdan o‘tganlar soni║");
                Console.WriteLine("║ 3   Qabul statistikasi       ║");
                Console.WriteLine("║ 0   Chiqish                  ║");
                Console.WriteLine("╚══════════════════════════════╝");
                Console.Write("Tanlang(1-3): ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RegisterStudent();
                        break;
                    case "2":
                        ShowRegisteredCount();
                        break;
                    case "3":
                        ShowStatistics();
                        break;
                    case "0":
                        Console.WriteLine("\n Dastur tugadi. Xayr!");
                        break;
                    default:
                        Console.WriteLine(" Noto‘g‘ri tanlov!");
                        Console.ReadLine();
                        break;
                }

            } while (choice != "0");
        }
        static void RegisterStudent()
        {
            Console.Clear();

            if (count >= 12)
            {
                Console.WriteLine(" QABUL YOPIQ!");
                Console.WriteLine(" Maksimal 12 ta talaba qabul qilinadi.");
                Console.ReadLine();
                return;
            }

            Console.Write("Talaba ismini kiriting\n Ism:");
            string firstName = Console.ReadLine();
            
            Console.Write(" Talaba familiyasini kiriting\n Familya: ");
            string lastName = Console.ReadLine();

            students[count] = $"{firstName} {lastName}";
            count++;

            Console.WriteLine(" Siz muvaffaqiyatli ro‘yxatdan o‘tdingiz!");
            Console.ReadLine();
        }
        static void ShowRegisteredCount()
        {
            Console.Clear();
            Console.WriteLine($" Ro`yxatdan o`tganlar soni: {count} ta");
            Console.WriteLine($" Talabalar sig‘im: 12 ta");

            Console.ReadLine();
        }
        static void ShowStatistics() 
        {
            Console.Clear();
            Console.WriteLine(" QABUL STATISTIKASI\n");
            Console.WriteLine($" Qabul qilinganlar: {count} ta");
            Console.WriteLine($" Maksimal sig‘im: 12 ta");
            Console.WriteLine($" Qolgan bo‘sh joylar: {12 - count} ta");
            Console.ReadLine();
        }
    }
}


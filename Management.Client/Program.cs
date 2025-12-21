using Management.Application.Services;

internal class Program
{
    static StudentService studentService = new StudentService();
    const int MaxUrinish = 3;    // Parol urinishlar soni
    const int MaxSigim = 12;     // Maksimal talaba soni

    static void Main(string[] args)
    {
        int urinishlar = 0;
        bool access = false;

        // Tizimga kirish
        do
        {
            Console.Clear();
            Console.WriteLine("TIZIMGA KIRISH");
            Console.Write("Parolni kiriting: ");
            string password = Console.ReadLine();

            if (password == "1234")
            {
                access = true;
                Console.WriteLine("\nXush kelibsiz Asrorbek!");
                Console.ReadLine();
                break;
            }
            else
            {
                urinishlar++;
                Console.WriteLine($"Parol noto‘g‘ri! Qolgan urinishlar: {MaxUrinish - urinishlar}");
                Console.ReadLine();
            }

        } while (urinishlar < MaxUrinish);

        if (!access)
        {
            Console.WriteLine("\nUrinishlar soni tugadi. Dastur yopildi!");
            return;
        }

        string choice;
        do
        {
            Console.Clear();
            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine("║       TALABALAR QABULI       ║");
            Console.WriteLine("╠══════════════════════════════╣");
            Console.WriteLine("║   1  Yangi talaba qo‘shish   ║");
            Console.WriteLine("║   2  Talabalar ro‘yxati      ║");
            Console.WriteLine("║   3  Qabul statistikasi      ║");
            Console.WriteLine("║   0  Chiqish                 ║");
            Console.WriteLine("╚══════════════════════════════╝");
            Console.Write("Tanlang: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RegisterStudent();
                    break;
                case "2":
                    ShowStudents();
                    break;
                case "3":
                    ShowStatistics();
                    break;
                case "0":
                    Console.WriteLine("\nDastur tugadi. Xayr!");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Noto‘g‘ri tanlov!");
                    Console.ReadLine();
                    break;
            }

        } while (choice != "0");
    }

    static void RegisterStudent()
    {
        Console.Clear();

        if (studentService.DbContext.Students == null)
        {
            Console.WriteLine("Talabalar ma'lumotlar bazasi mavjud emas!");
            Console.ReadLine();
            return;
        }

        if (studentService.DbContext.StudentCount >= MaxSigim)
        {
            Console.WriteLine($"QABUL YOPIQ! Maksimal {MaxSigim} ta talaba qabul qilinadi.");
            Console.ReadLine();
            return;
        }

        Console.Write("Talaba ismini kiriting\nISM: ");
        string firstName = Console.ReadLine()?.Trim();
        if (string.IsNullOrWhiteSpace(firstName))
        {
            Console.WriteLine("Ism bo‘sh bo‘lishi mumkin emas!");
            Console.ReadLine();
            return;
        }

        Console.Write("Talaba familiyasini kiriting\nFAMILYA: ");
        string lastName = Console.ReadLine()?.Trim();
        if (string.IsNullOrWhiteSpace(lastName))
        {
            Console.WriteLine("Familiya bo‘sh bo‘lishi mumkin emas!");
            Console.ReadLine();
            return;
        }

        studentService.AddStudent(firstName, lastName);

        var addedStudent = studentService.DbContext.Students[studentService.DbContext.StudentCount - 1];
        Console.WriteLine($"\n{addedStudent.Firstname} {addedStudent.Lastname} muvaffaqiyatli ro‘yxatdan o‘tdingiz!");
        Console.WriteLine($"TALABA ID: {addedStudent.Id}");
        Console.ReadLine();
    }

    static void ShowStudents()
    {
        Console.Clear();

        if (studentService.DbContext.Students == null || studentService.DbContext.StudentCount == 0)
        {
            Console.WriteLine("Hech qanday talaba yo‘q.");
        }
        else
        {
            Console.WriteLine("Talabalar ro‘yxati:\n");
            for (int i = 0; i < studentService.DbContext.StudentCount; i++)
            {
                var s = studentService.DbContext.Students[i];
                Console.WriteLine($"{i + 1}. {s.Firstname} {s.Lastname} | ID: {s.Id}");
            }
        }
        Console.ReadLine();
    }

    static void ShowStatistics()
    {
        Console.Clear();

        int count = studentService.DbContext.Students?.Length ?? 0; 

        Console.WriteLine("QABUL STATISTIKASI\n");
        Console.WriteLine($"Qabul qilinganlar: {count} ta");
        Console.WriteLine($"Maksimal sig‘im: {MaxSigim} ta");
        Console.WriteLine($"Bo‘sh joylar: {MaxSigim - count} ta");
        Console.ReadLine();
    }
}

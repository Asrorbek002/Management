using Management.Application.Services;

namespace Management.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentService= new StudentService();
            studentService.AddStudent("Asrorbek", "Abdurashidov");
            studentService.AddStudent("Ali", "Aliyev");
        }
    }
}

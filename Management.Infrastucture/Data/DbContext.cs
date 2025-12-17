using Management.Domain.Models;
namespace Management.Infrastucture.Data
{
   public class DbContext
    {
        public DbContext()
        {
            this.Students = new Student[12];
        }
        public Student[] Students { get; set; }
        public int StudentCount { get; set; } = 0;
    }
}

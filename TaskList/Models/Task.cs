using System.Data.Entity;
using System.Linq;
namespace Models
{
    public class Task
    {
        public Task()
            : base()
        {

        }

        public int Id { get; set; }
        public string TaskTitle { get; set; }
        public string TaskDescription { get; set; }
        public string ImportanceLevel { get; set; }
        public string Date { get; set; }
    }
}

using System.Collections.Generic;

namespace MVC_Task.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}

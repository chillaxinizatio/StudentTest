using System.Collections.Generic;

namespace StudentTest.Features
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string OfficeLocation { get; set; }
        public virtual ICollection<Class> Classes
            { get; set; } = new HashSet<Class>();
    }
}

using System.Collections.Generic;

namespace HighSchoolLesson.Models
{
    public class Subject : Entity
    {
        public string Name { get; set; }
        public virtual Mentor Mentor { get; set; }
        public virtual ICollection<SubjectsStudents> Students { get; set; } = new List<SubjectsStudents>();
    }
}
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NavigationLesson.Models
{
    // [Table("books")]
    public class Book : Entity
    {
        // [Column("name")]
        // [Required]
        public string Title { get; set; }
        public Guid AuthorId { get; set; } 

        // [ForeignKey("AuthorId")] // обязательно должен быть Id!
        //[InverseProperty(Id)] //прочитать про этот атрибут
        public Author Author { get; set; }
    }
}

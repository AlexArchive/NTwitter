using System;
using System.ComponentModel.DataAnnotations;

namespace AngularBookstore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Book Title is Required")]
        [MinLength(3, ErrorMessage ="Movie Title must be at least 3 characters")]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Range(0, 100, ErrorMessage ="Price must be between 0 and 100 dollars.")]
        public decimal Price { get; set; }

        [Required]
        public DateTime PublishDate { get; set; }
    }
}
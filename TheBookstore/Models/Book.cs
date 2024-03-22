//using System;
//using System.Collections.Generic;

//namespace TheBookstore.Models;

//public partial class Book
//{
//    public int BookId { get; set; }

//    public string Title { get; set; } = null!;

//    public string Author { get; set; } = null!;

//    public string Publisher { get; set; } = null!;

//    public string Isbn { get; set; } = null!;

//    public string Classification { get; set; } = null!;

//    public string Category { get; set; } = null!;

//    public int PageCount { get; set; }

//    public double Price { get; set; }
//}


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TheBookstore.Models
{
    public partial class Book
    {
        [Required]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Author { get; set; } = string.Empty;
        [Required]
        public string Publisher { get; set; } = string.Empty;
        [Required]
        public string Isbn { get; set; } = string.Empty;
        [Required]
        public string Classification { get; set; } = string.Empty;
        [Required]
        public string Category { get; set; } = string.Empty;
        [Required]
        public int PageCount { get; set; }
        [Required]
        public double Price { get; set; }
    }
}


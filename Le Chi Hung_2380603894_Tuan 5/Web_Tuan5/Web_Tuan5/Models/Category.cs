using System.ComponentModel.DataAnnotations;
using Web_Tuan5.Models;

namespace Web_Tuan5.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên chủ đề không được để trống")]
        public string Name { get; set; } = string.Empty;

        // Quan hệ 1 - nhiều
        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
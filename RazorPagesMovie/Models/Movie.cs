using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int Id { get; set; } //数据库需要id字段获取主键 

        [StringLength(60, MinimumLength = 3)] 
        [Required]  //[Required] 和 [MinimumLength] 特性指示属性必须具有一个值
        public string? Title { get; set; } = string.Empty; //?表示属性可为空 

        //[Display(Name ="Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$"), Required, StringLength(30)]
        public string? Genre { get; set; } = string.Empty;

        [Range(1, 100), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5)]
        public string Rating { get; set; } = string.Empty;
    }
}

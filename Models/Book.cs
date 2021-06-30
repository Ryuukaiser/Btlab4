namespace Btlab4.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Book")]
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [Required(ErrorMessage = "Mã không được trống ")]
        [Display(Name = "Mã Sách")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Tiêu đề không được trống ")]
        [StringLength(255, ErrorMessage = "Tiêu đề sách không được vượt quá 250 ký tự")]
        [Display(Name = "Tiêu Đề")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Miêu tả không được trống ")]
        [StringLength(255, ErrorMessage = "Miêu tả sách không được vượt quá 250 ký tự")]
        [Display(Name = "Miêu tả")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Tác giả không được trống ")]
        [StringLength(255, ErrorMessage = "Tác giả sách không được vượt quá 250 ký tự")]
        [Display(Name = "Tác giả")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Đường dẫn ảnh bìa không được trống ")]
        [StringLength(255)]
        [Display(Name = "Đường dẫn ảnh bìa")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Giá không được trống ")]
        public int Price { get; set; }
    }
}

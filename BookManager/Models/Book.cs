namespace BookManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage ="Id kh�ng ???c ?? tr?ng")]
        [Range(1,2,ErrorMessage ="ID t? 1 t?i 2")]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100,ErrorMessage ="kh�ng qu� 100 k� t?")]
        [Required(ErrorMessage = "TI�u ?? kh�ng ???c ?? tr?ng")]
        public string Title { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        [Required(ErrorMessage = "Description kh�ng ???c ?? tr?ng")]
        public string Description { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30,ErrorMessage="kh�ng qu� 30 k� t?")]
        [Required(ErrorMessage = "T�c gi? kh�ng ???c ?? tr?ng")]
        public string Author { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        [Required(ErrorMessage = "H�nh ?nh kh�ng ???c ?? tr?ng")]
        public string Images { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Gi� kh�ng ???c ?? tr?ng")]
        [Range(1000, 1000000, ErrorMessage = "Gi� t? 1000 t?i 1000000")]
        public int Price { get; set; }
        public Book() { }
    }
}

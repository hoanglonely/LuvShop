﻿using LuvShop.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LuvShop.Model.Models
{
    [Table("Products")]
    public class Product : Audiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }
        public int CategoryID { get; set; }
        [MaxLength(256)]
        public string Image { get; set; }
        [Column(TypeName = "xml")]
        public string MoreImages { get; set; }
        public decimal Price { get; set; }
        public decimal? PromotionPrice { get; set; } //Gia khuyen mai
        public int? Warranty { get; set; } //Bao hanh
        [MaxLength(500)]
        public string Description { get; set; }
        [MaxLength(256)]
        public string Content { get; set; }

        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }
        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }
    }
}
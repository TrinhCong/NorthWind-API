using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace NorthWind.API.Models
{
    [Table("categories", Schema = "public")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int category_id { get; set; }
        public string category_name{get;set;}
        public string description{get;set;}
    }
}
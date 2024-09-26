using ShoeStore.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourProjectName.Models
{
    public class ShoeDetail
    {
        [Key]
        public int ShoeId { get; set; }
        [ForeignKey("ShoeType")]
        public int ShoeTypeId { get; set; }
        public string? ShoeName { get; set; }
        public decimal ShoePrice { get; set; }
        public string? ShoeDescription { get; set; }
        public string? ShoeImage { get; set; }

        public virtual ShoeType? ShoeType { get; set; }
    }
}

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class Inventory
    {
        [Required]
        [DisplayName("Inventory ID")]
        public int InventoryID { get; set; }

        [Required]
        [DisplayName("Quantity to Order")]
        public int Supplies { get; set; }

        [Required]
        [DisplayName("Medication Name(s)")]
        public string Medications { get; set; }

        [Required]
        [DisplayName("Equipment Required for Medication")]
        public string Equipment { get; set; }

        [Required]
        [DisplayName("Order Date")]
        [DataType(DataType.Date)]
        public string OrdersandEquipment { get; set; }

        [Required]
        [DisplayName("Stock in Hospital")]
        public string Stock { get; set; }

    }
}

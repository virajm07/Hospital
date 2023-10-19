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
        [DisplayName("Quantity")]
        public string Supplies { get; set; }

        [Required]
        [DisplayName("Medication Name(s)")]
        public string Medications { get; set; }

        [Required]
        [DisplayName("Equipment Required")]
        public string Equipment { get; set; }

        [Required]
        [DisplayName("Orders")]
        public string OrdersandEquipment { get; set; }

        [Required]
        public string Stock { get; set; }

    }
}

using System.ComponentModel;

namespace Hospital.Models
{
    public class Inventory
    {

        [DisplayName("Inventory ID")]
        public int InventoryID { get; set; }
        public string Supplies { get; set; }
        public string Medications { get; set; }
        public string Equipment { get; set; }

        [DisplayName("Orders and Equipment")]
        public string OrdersandEquipment { get; set; }
        public string Stock { get; set; }

    }
}

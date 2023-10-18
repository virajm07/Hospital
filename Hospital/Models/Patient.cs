using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class Patient
    {
        [DisplayName("Patient ID")]
        public int PatientID { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }

        [DisplayName("Contact Number")]
        public string ContactNumber { get; set; }

        [DataType(DataType.Date)]
        public string DOB { get; set; }

        [DisplayName("Health Conditions")]
        public string HealthConditions { get; set; }

        public ICollection<Staff>Staffs { get; set; }
    }
}

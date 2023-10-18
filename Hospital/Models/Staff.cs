using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class Staff
    {
        [DisplayName("Staff ID")]
        public int StaffID { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public string DOB { get; set; }

        [DisplayName("Contact Number")]
        public string ContactInfo { get; set; }

        [DisplayName("Criminal History")]
        public string CriminalHistory { get; set; }

        [DisplayName("Medical History")]
        public string MedicalHistory { get; set; }

        [DisplayName("Health Conditions")]
        public string HealthConditions { get; set; }

        [DisplayName("Work Schedule")]
        public string WorkSchedule { get; set; }

        public ICollection<Patient>Patients { get; set; }
    }
}

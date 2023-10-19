using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class Staff
    {
        public int StaffID { get; set; }

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string DOB { get; set; }

        [DisplayName("Contact Number")]
        [RegularExpression("(^\\([0]\\d{2}\\))(\\d{6,7}$)", ErrorMessage = "Please enter a valid phone number format e.g. (021)1234567")]
        public string ContactInfo { get; set; }

        [Required]
        [DisplayName("Criminal History")]
        public string CriminalHistory { get; set; }

        [Required]
        [DisplayName("Medical History")]
        public string MedicalHistory { get; set; }

        [Required]
        [DisplayName("Health Conditions")]
        public string HealthConditions { get; set; }

        [Required]
        [DisplayName("Work Schedule")]
        public string WorkSchedule { get; set; }

        public ICollection<Patient>Patients { get; set; }
    }
}

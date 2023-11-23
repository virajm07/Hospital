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

        [DisplayName("Contact Number (use format (000)000000)")]
        [RegularExpression("((^\\([0]\\d{1}\\))(\\d{7}$)|(^\\([0][2]\\d{1}\\))(\\d{6,8}$)|([0][8][0][0])([\\s])(\\d{5,8}$))", ErrorMessage = "Please enter a valid phone number")]
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

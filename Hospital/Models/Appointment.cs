using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }

        [DisplayName("Patient Full Name")]
        public string PatientFullName { get; set; }

        [DisplayName("Staff Full Name")]
        public string StaffFullName { get; set; }

        [DisplayName("Patient ID")]
        public string PatientID { get; set; }

        [DisplayName("Staff ID")]
        public string StaffID { get; set; }

        [DisplayName("Appointment Room")]
        public string AppointmentRoom { get; set; }

        [DisplayName("Appointment Date and Time")]
        [DataType(DataType.DateTime)]
        public string AppointmentDate { get; set; }
    }
}

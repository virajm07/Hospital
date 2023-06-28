namespace Hospital.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public string PatientFullName { get; set; }
        public string StaffFullName { get; set; }
        public string PatientID { get; set; }
        public string StaffID { get; set; }
        public string AppointmentRoom { get; set; }
        public string AppointmentDate { get; set; }
    }
}

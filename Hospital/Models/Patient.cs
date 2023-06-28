namespace Hospital.Models
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string DOB { get; set; }
        public string HealthConditions { get; set; }

        public ICollection<Staff>Staffs { get; set; }
    }
}

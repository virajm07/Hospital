namespace Hospital.Models
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string ContactInfo { get; set; }
        public string CriminalHistory { get; set; }
        public string MedicalHistory { get; set; }
        public string HealthConditions { get; set; }
        public string WorkSchedule { get; set; }

        public ICollection<Patient>Patients { get; set; }
    }
}

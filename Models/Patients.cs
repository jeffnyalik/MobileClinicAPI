namespace MobileClinicAPI.Models
{
    public class Patients
    {
        // Patient.cs
        public class Patient
        {
            public int PatientID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string OtherName { get; set; }
            public DateTime? DateOfBirth { get; set; }
            public string Gender { get; set; }
            public string IDNumber { get; set; }
            public string HomeCounty { get; set; }
            public string Mobile { get; set; }
            public string Email { get; set; }
            public string NameOfAlternative { get; set; }
            public string TelephoneNumber { get; set; }
            public bool HasDisability { get; set; }
        }

        // Appointment.cs
        public class Appointment
        {
            public int AppointmentID { get; set; }
            public int PatientID { get; set; }
            public int DoctorID { get; set; }
            public DateTime? AppointmentDate { get; set; }
            public TimeSpan? AppointmentTime { get; set; }
        }

    }
}

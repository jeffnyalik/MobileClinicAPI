namespace MobileClinicAPI.Models
{
    public class Patients
    {
        // Patient.cs
        public class Patient
        {
            public int ID { get; set; }
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

    }
}

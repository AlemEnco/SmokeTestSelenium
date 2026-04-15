namespace SmokeTestSelenium.Setup.Entity
{
    [Serializable]
    public class AppointmentEntity
    {
        public String? Browser { get; set; }
        public Int16 Environment { get; set; }

        public String? Email { get; set; }
        public String? Password { get; set; }
        public String? LocationId { get; set; }
        public String? NetworkId { get; set; }
        public String? SpecialtyId { get; set; }
        public String? LocationProviderId { get; set; }
        public PatientDetail? ObjPatient { get; set; }
        public String? Patient { get; set; }
        public String? Provider { get; set; }
        public String? Consent { get; set; }

        #region Patient

        [Serializable]
        public class PatientDetail
        {
            public String? FirstName { get; set; }
            public String? MiddleName { get; set; }
            public String? LastName { get; set; }
            public String? EmailPatient { get; set; }
            public String? Dob { get; set; }
            public String? Gender { get; set; }
            public String? PhoneNumber { get; set; }
            public String? MRN { get; set; }
            public String? SSN { get; set; }
            public String? SecondaryPhoneNumber { get; set; }
            public String? AddressLine1 { get; set; }
            public String? AddressLine2 { get; set; }
            public String? City { get; set; }
            public String? State { get; set; }
            public String? ZipCode { get; set; }
            public String? EmergencyContactName { get; set; }
            public String? EmergencyContactPhone { get; set; }
            public String? Diagnosis { get; set; }
            public String? ProceduresTest { get; set; }
            public String? MemberId { get; set; }
            public String? AddressLine { get; set; }
        }

        #endregion Patient

    }
}

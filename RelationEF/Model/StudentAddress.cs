namespace RelationEF.Model
{
    public class StudentAddress
    {
        public int StudentAddressId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }

        public int StudentId { get; set; } // Foreign Key Property
        public Student Student { get; set; } // Reference Navigation Property.
    }
}

//One to one Relation between Student and StudentAdress Entity

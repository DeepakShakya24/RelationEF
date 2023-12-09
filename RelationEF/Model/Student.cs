using System.Diagnostics;

namespace RelationEF.Model
{
    //Dependent Entity, because it has Foreign Key
    public class Student
    {
        //Scalar Property
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

       // public int GradeId { get; set; }

        //Reference Navigation, this will be foreign Key in Student Table., Foreign Key Will Craete as GradeId in Student Table
        public Grade Grade { get; set; }

        public StudentAddress StudentAddress { get; set; }
    }
}


//One to Many Relation between Student and Grade Entity, because many Students can have same Grades.
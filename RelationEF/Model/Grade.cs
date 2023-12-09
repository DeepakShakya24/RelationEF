namespace RelationEF.Model
{
    //Prinicipal Entity
    public class Grade
    {
        public int Id { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }

        public List<Student> Students { get; set; }
    }
}
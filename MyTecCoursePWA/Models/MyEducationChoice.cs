namespace MyTecCoursePWA.Models
{
    public class MyEducationChoice
    {
        public int Id { get; set; }
        public string User { get; set; }
        public Education Education { get; set; }
        public Pathway Pathway { get; set; }
        public Specialization Specialization { get; set; }

    }
}

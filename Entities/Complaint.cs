namespace ComplaintRequestSystem.Entities
{
    public class Complaint : BaseEntity
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public Department Department { get; set; } 
        public string ComplaintText { get; set; }
    }
}

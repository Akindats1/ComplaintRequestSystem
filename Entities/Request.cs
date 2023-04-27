namespace ComplaintRequestSystem.Entities
{
    public class Request : BaseEntity
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public Department Department { get; set; } 
        public string RequestText { get; set; }
       
    }
}

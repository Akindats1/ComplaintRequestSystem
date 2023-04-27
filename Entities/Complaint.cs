namespace ComplaintRequestSystem.Entities
{
    public class Complaint : BaseEntity, IComparable<Complaint>
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public Department Department { get; set; } = new Department();
        public string ComplaintText { get; set; }

        public int CompareTo(Complaint? other)
        {
            throw new NotImplementedException();
        }
    }
}

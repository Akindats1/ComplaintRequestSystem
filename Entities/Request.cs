namespace ComplaintRequestSystem.Entities
{
    public class Request : BaseEntity, IComparable<Request>
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public Department Department { get; set; } = new Department();
        public string RequestText { get; set; }

        public int CompareTo(Request? other)
        {
            throw new NotImplementedException();
        }
    }
}

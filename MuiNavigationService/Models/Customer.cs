namespace MuiNavigationService.Models
{
    public enum OrderStatus { None, New, Processing, Shipped, Received };

    public class Customer : AbstractCloneable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsMember { get; set; }
        public OrderStatus Status { get; set; }

        public bool Equals(Customer obj)
        {
            return obj.Id == Id 
                && obj.FirstName == FirstName 
                && obj.LastName == LastName 
                && obj.Email == Email 
                && obj.IsMember == IsMember 
                && obj.Status == Status;
        }
    }
}

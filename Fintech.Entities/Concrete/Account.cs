namespace Fintech.Entities.Concrete
{
    public class Account
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Hangi kullanıcıya ait [cite: 71]
        public string AccountNumber { get; set; } = string.Empty;
        public decimal Balance { get; set; } // Hesap bakiyesi
        public string Currency { get; set; } = "TRY";
    }
}
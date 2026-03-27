namespace Fintech.Entities.Concrete
{
    public class CreditScore
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Hangi kullanıcıya ait [cite: 74]
        public int Score { get; set; } // Hesaplanan puan
        public DateTime CalculationDate { get; set; } = DateTime.Now;
    }
}
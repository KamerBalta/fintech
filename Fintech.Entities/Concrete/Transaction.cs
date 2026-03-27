namespace Fintech.Entities.Concrete
{
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; } // İşlemi yapan kullanıcı
        public decimal Amount { get; set; } // İşlem tutarı [cite: 44]
        public string TransactionType { get; set; } = string.Empty; // [cite: 44]
        public string PaymentMethod { get; set; } = string.Empty; // [cite: 44]
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public bool IsFraud { get; set; } = false; // Fraud tespit sonucu [cite: 73]
        public double RiskScore { get; set; } // Modelden gelen risk oranı [cite: 73]
    }
}
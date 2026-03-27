using Fintech.Business.Abstract;
using Fintech.DataAccess.Concrete.Context;

namespace Fintech.Business.Concrete
{
    public class CreditScoreManager : ICreditScoreService
    {
        private readonly FintechContext _context = new FintechContext();

        public int CalculateScore(int userId)
        {
        // Kullanıcının toplam harcama sayısını alalım   
            // Örnek basit bir mantık: 
            // Kullanıcının toplam harcama sayısını alalım (Rapordaki davranış analizi [cite: 14, 45])
            var transactionCount = _context.Transactions.Count(t => t.UserId == userId);

            // Her işlem için 10 puan verelim (Bu senin bitirme ödevindeki algoritman olacak)
            int newScore = transactionCount * 10;

            return newScore;
        }
    }
}
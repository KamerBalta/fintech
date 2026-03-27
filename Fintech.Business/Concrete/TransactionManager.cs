using Fintech.Business.Abstract;
using Fintech.DataAccess.Concrete.Context;
using Fintech.Entities.Concrete;

namespace Fintech.Business.Concrete
{
    public class TransactionManager : ITransactionService
    {
        private readonly FintechContext _context = new FintechContext();

        public void Add(Transaction transaction)
        {
            // BURASI KRİTİK: İşlem kaydedilmeden önce Fraud kontrolü tetiklenecek
            // Şimdilik varsayılan olarak kaydediyoruz
            _context.Transactions.Add(transaction);
            _context.SaveChanges();

            // İşlemden sonra kullanıcının kredi puanını güncelleme metodunu çağıracağız
        }

        public List<Transaction> GetListByUserId(int userId)
        {
            return _context.Transactions.Where(t => t.UserId == userId).ToList();
        }
    }
}
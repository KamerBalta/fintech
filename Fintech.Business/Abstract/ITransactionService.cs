using Fintech.Entities.Concrete;
using System.Collections.Generic; // Bu satırı eklemeyi unutma!

namespace Fintech.Business.Abstract
{
    public interface ITransactionService
    {
        // Yeni bir harcama/işlem eklemek için
        void Add(Transaction transaction);

        // Kullanıcının tüm geçmiş işlemlerini listelemek için
        List<Transaction> GetListByUserId(int userId);
    }
}
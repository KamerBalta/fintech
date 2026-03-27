using Fintech.Business.Abstract;
using Fintech.DataAccess.Concrete.Context;
using Fintech.Entities.Concrete;
using System.Linq;

namespace Fintech.Business.Concrete
{
    public class UserManager : IUserService
    {
        // Veritabanına erişmek için context'i çağırıyoruz
        private readonly FintechContext _context = new FintechContext();

        public void Add(User user)
        {
            // Kullanıcı kaydedilmeden hemen önce ID üretiliyor
            user.CustomerNumber = GenerateCustomerNumber();
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public long GenerateCustomerNumber()
        {
            string today = DateTime.Now.ToString("yyyyMMdd"); // Örn: 20260327
            
            // Bugün kaydedilen son kullanıcıyı bul
            var lastUserToday = _context.Users
                .Where(u => u.CustomerNumber.ToString().StartsWith(today))
                .OrderByDescending(u => u.CustomerNumber)
                .FirstOrDefault();

            if (lastUserToday == null)
            {
                // Bugünün ilk müşterisi: 202603270001
                return long.Parse(today + "0001");
            }

            // Bugün müşteri varsa, numarasını 1 artır
            return lastUserToday.CustomerNumber + 1;
        }
    }
}

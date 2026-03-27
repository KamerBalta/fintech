using Fintech.Entities.Concrete;

namespace Fintech.Business.Abstract
{
    public interface IUserService
    {
        // Kullanıcıyı kaydederken bu metodu çağıracağız
        void Add(User user);
        
        // O günün son müşteri numarasını bulmak için kullanacağız
        long GenerateCustomerNumber();
    }
}
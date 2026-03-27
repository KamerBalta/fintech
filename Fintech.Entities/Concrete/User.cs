using System;

namespace Fintech.Entities.Concrete
{
    public class User
    {
        public int Id { get; set; } // Veritabanı için Primary Key
        
        // Senin istediğin format: 202603270001
        // Sayısal büyüklükten dolayı 'long' kullanmak daha güvenlidir.
        public long CustomerNumber { get; set; } 
        
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        
        // Kredi puanı başlangıçta 0 veya nötr bir değer olabilir
        public int CreditScore { get; set; } = 0;
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
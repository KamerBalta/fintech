namespace Fintech.Business.Abstract
{
    public interface ICreditScoreService
    {
        int CalculateScore(int userId); // Puanı hesapla ve döndür
    }
}
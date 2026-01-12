using HWInflation.Models;

namespace HWInflation.Repositories
{
    public interface IStoreScrapperRepository
    {
        Task<IEnumerable<StoreScrapper>> GetStorieScrappers();
        Task<StoreScrapper> GetStoreScrapper(int id);
        Task<StoreScrapper> CreateStoreScrapper(StoreScrapper storeScrapper);
        Task<StoreScrapper> UpdateStoreScrapper(int id, StoreScrapper storeScrapper);
    }
}

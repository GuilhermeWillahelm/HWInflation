using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using HWInflation.Models;

namespace HWInflation.Repositories
{
    public class StoryScrapperRepository : IStoreScrapperRepository
    {
        public Task<StoreScrapper> CreateStoreScrapper(StoreScrapper storeScrapper)
        {
            throw new NotImplementedException();
        }

        public Task<StoreScrapper> GetStoreScrapper(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StoreScrapper>> GetStorieScrappers()
        {
            throw new NotImplementedException();
        }

        public Task<StoreScrapper> UpdateStoreScrapper(int id, StoreScrapper storeScrapper)
        {
            throw new NotImplementedException();
        }
    }
}

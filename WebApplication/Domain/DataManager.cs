using WebApplication.Domain.Repositories.Abstract;
namespace WebApplication.Domain
{
    public class DataManager
    {
        public IServiceItemsRepository ServiceItems;

        public DataManager(IServiceItemsRepository serviceItemsRepository)
        {
            ServiceItems = serviceItemsRepository;
        }
    }
}
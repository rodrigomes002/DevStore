using DevStore.API.Models;

namespace DevStore.API.Repository
{
    public interface IProductRepository
    {
        List<Product> List();
    }
}

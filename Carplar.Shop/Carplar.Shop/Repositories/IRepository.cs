namespace Carplar.Shop.Repositories
{
    public interface IRepository
    {
        IShopRepository Shop { get; }

        ICustomerRepository Customer { get; }
    }
}
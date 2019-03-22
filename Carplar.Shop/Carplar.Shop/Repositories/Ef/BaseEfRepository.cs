using Carplar.Shop.EntityFramework;

namespace Carplar.Shop.Repositories
{
    public class BaseEfRepository
    {
        protected readonly Db Context;

        public BaseEfRepository(Db context) {
            Context = context;
        }
    }
}

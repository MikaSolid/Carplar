namespace Carplar.Shop.EntityFramework
{
    public class Article : DbRecord
    {
        public int ArticleId { get; set; }

        public int ArticleGroupId { get; set; }

        public string Name { get; set; }

        public virtual ArticleGroup ArticleGroup { get; set; }
    }
}

namespace Ingenico.Enterprise.Webshop.Domain
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public float Price { get; set; }
        public string Picture { get; set; }
        public string Mark { get; set; }
        public ArticleKind Kind { get; set; }
    }

    public enum ArticleKind
    {
        Virtual,
        Physical
    }
}
namespace Myweb.API.Models
{
    public class Blog
    {
        public Blog(int id, string blogName, string description)
        {
            this.id = id;
            this.blogName = blogName;
            this.description = description;
        }

        public int id { get; set; }
        public string blogName { get; set; }
        public string description { get; set; }
    }
}

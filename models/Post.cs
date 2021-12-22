namespace RestAPIExample
{
    public class Post
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }

        public Post(int _userId, int _id, string _title, string _body)
        {
            userId = _userId;
            id = _id;
            title = _title;
            body = _body;
        }
    }
}
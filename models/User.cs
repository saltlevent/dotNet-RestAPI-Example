namespace RestAPIExample
{
    public class User
    {
        public User(string name, string username, string email, Addr address)
        {
            this.name = name;
            this.username = username;
            this.email = email;
            this.address = address;
        }

        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Addr address { get; set; }

    }

    public class Addr
    {
        public string street { get; set; } = "";
        public string suite { get; set; } = "";

    }


}
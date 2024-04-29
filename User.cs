public class User
{
    private string Username { get; set; }
    private string Password { get; set; }

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public bool Authenticate(string username, string password)
    {
        return Username == username && Password == password;
    }
}

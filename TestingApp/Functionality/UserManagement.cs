public record User(string firstName, string lastName)
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public string Phone { get; set; }
    public bool IsEmailVerified { get; set; } = false;
}
public class UserManagement
{
    private List<User> _users = new List<User>();

    private int idCounter = 1;

    public IEnumerable<User> AllUsers => _users;

    public void Add(User user)
    {
        this._users.Add(user with {Id = idCounter++});
    }

    public void Update(User user)
    {
        var dbUsr = this._users.First(x => x.Id == user.Id);
        dbUsr.Phone = user.Phone;
        
    }

    public void VerifyEmail(int UserId)
    {
        var dbUser = this._users.First(x=> x.Id == UserId);
        dbUser.IsEmailVerified = true;
    }
}
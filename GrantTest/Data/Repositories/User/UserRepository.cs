using GrantTest.Models;

namespace GrantTest.Data.Repositories
{
  public class UserRepository: IUserRepository
  {
    private readonly ApplicationDbContext _dbContext;

    public UserRepository(ApplicationDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public User? GetByLoginAndPassword(String login, String password) {
      return _dbContext.Users.FirstOrDefault(user => user.Login == login && user.Password == password);
    }

  } 
}
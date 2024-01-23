using GrantTest.Models;

namespace GrantTest.Data.Repositories
{
  public interface IUserRepository
  {

    public User? GetByLoginAndPassword(String login, String password);

  } 
}
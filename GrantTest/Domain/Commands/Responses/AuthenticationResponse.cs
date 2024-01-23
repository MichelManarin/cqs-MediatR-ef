namespace GrantTest.Domain.Commands.Responses
{

  public class AuthenticationResponse
  {
    public string Token  { get; set; } = "";
    public string Name { get; set; } = "";
    public DateTime Creation { get; set; } = DateTime.Now;
    public DateTime ExpirationDate { get; set; } = DateTime.Now.AddHours(4);
  }
}
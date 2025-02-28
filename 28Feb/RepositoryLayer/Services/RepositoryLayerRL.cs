using ModelLayer.DTO;
namespace RepositoryLayer.Services
{
    public class RepositoryLayerRL
    {
        string username = "Root";
        string password = "Root";
        
        public string[] registrationRL()
        {
            string []arr = new string[2];
            arr[0] = username;
            arr[1] = password;
            return arr;
        }
        public LoginDTO logginging(LoginDTO login)
        {
            login.username = username;
            login.password=password;
            return login;
        }

    }
}

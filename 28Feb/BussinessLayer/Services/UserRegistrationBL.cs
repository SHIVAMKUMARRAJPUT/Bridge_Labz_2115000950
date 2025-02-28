using ModelLayer.DTO;
using RepositoryLayer.Services;
namespace BussinessLayer.Services{
    public class UserRegistrationBL
    {
        RepositoryLayerRL _regitration;
     
        public UserRegistrationBL(RepositoryLayerRL regitration)
        {
            _regitration = regitration;
        }

        public string  userRegistrationBL(string username, string password)
        {
           
            string []arr = _regitration.registrationRL();
            if (arr[0]==username && arr[1] == password)
            {
                return "Succes";
            }
            else
            {
                return "Invalid";
            }


        }
        public bool logging(LoginDTO login)
        {
            string frontentusername = login.username;
            string frontentpassword = login.password;
            LoginDTO log= _regitration.logginging(login);
            if(log!= null && log.username==frontentusername && log.password == frontentpassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

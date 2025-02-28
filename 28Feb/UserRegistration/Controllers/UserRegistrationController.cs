using Microsoft.AspNetCore.Mvc;
using BussinessLayer.Services;
using ModelLayer.DTO;

namespace UserRegistration.Controllers;

[ApiController]
[Route("[controller]")]
public class UserRegistrationController : ControllerBase
{
    UserRegistrationBL userRegistrationBL;
    ResponseModel<string> response;
    
    public UserRegistrationController(UserRegistrationBL _userRegistrationBL)
    {
        userRegistrationBL = _userRegistrationBL;
    }

    
    [HttpGet]

    public string registration()
    {
        return userRegistrationBL.userRegistrationBL("Root", "Root");
    }
    [HttpPost]
    public ResponseModel<string> PostData(LoginDTO login)
    {
        bool flag=userRegistrationBL.logging(login);
        if (flag)
        {

            response = new ResponseModel<string>();
            response.success = true;
            response.Message = "login Successfully";
            response.Data =" ";

            return response;
        }
        else
        {
            response = new ResponseModel<string>();
            response.success = false;
            response.Message = "Invalid  Credentials";
            response.Data = " ";

            return response;

        }
      

    }

}

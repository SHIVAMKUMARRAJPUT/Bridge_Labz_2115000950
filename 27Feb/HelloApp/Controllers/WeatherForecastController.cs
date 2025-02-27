using Microsoft.AspNetCore.Mvc;

namespace HelloApp.Controllers;
using BusinessLayer;
using BusinessLayer.Service;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    RegisterHelloBL _registerHelloBL;
    public WeatherForecastController(RegisterHelloBL registerHelloBL)
    {

        _registerHelloBL = registerHelloBL;
    }
    [HttpGet]
    public string Get()
    {
        return _registerHelloBL.registration("Value from controller");
    }




}

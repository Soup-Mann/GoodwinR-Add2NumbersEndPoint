//Reed Goodwin
//10-25-2022
//This is a console program that causes 
// Jacob Dekok - The code looks great and organized. The program runs as intended


using Microsoft.AspNetCore.Mvc;

namespace GoodwinR_Add2NumbersAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AddThatController : ControllerBase
{
    [HttpGet]
    [Route("add2num/{number1}/{number2}")]
    public int gayball(string number1, string number2){
    int convertNum1 = Convert.ToInt32(number1);
    int convertNum2 = Convert.ToInt32(number2);
    return convertNum1 + convertNum2;

}
}

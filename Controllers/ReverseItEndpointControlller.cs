//Kenneth Fujimura
//Last Revised: 10-27-2022
//Reverse it - Endpoint
//This is an API program that's designed to emulate the console project of the same name that we did during the coding combine. This program takes in a string input, and the reverses it for the user.
//Peer Reviewed By: Jasmine Leek - clean, simple code that ran perfectly against all conditions tested, including letters, numbers and special characters. great job!!

using Microsoft.AspNetCore.Mvc;

namespace KFujimuraReverseItEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseItEndpointController : ControllerBase
{
    [HttpGet]
    [Route("ReverseIt/{input}")]

    public string ReverseIt(string input){
        string output = "";
        for (int i = input.Length -1; i >= 0; i--) {
            output = output + input[i];
        }
        return $"The reverse of \"{input}\" is: \"{output}\"";
    }
}
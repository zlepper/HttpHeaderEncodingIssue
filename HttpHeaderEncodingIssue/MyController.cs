using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace HttpHeaderEncodingIssue;

[Route("api/my")]
public class MyController : ControllerBase
{
    public IActionResult Get()
    {

        var cd = new ContentDisposition()
        {
            FileName = @"jhff-90°_asdfgh-qwer-qwer_zxcvb asdfgh.jpg"
        };
        
        Response.Headers.ContentDisposition = cd.ToString();
        
        return Ok("Hello World");
    }
}
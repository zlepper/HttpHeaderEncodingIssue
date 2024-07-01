using HttpHeaderEncodingIssue;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyUnitTests;

public class Tests
{

    [Test]
    public void Test1()
    {
        var contrl = new MyController()
        {
            ControllerContext = new ControllerContext()
            {
                HttpContext = new DefaultHttpContext()
            }
        };

        var result = contrl.Get();
        
        Assert.That(contrl.Response.Headers.ContentDisposition.ToString(), Is.Not.Empty);
    }
}
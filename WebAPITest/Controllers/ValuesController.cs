using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITest.Controllers
{
    [Route("[controller]")]           // [ ] : C# Attribute, 메타 데이터를 기록
                                      // 라우트는 우리가 접속할 수 있는 길을 알려주는 것 -> Endpoint
    [ApiController]                   // 이게 붙어 있어야 MapController()가 인식됨
    [Produces("application/xml")]     // 이 API가 반환하는 데이터의 형식이 XML이라는 것을 명시
    public class TestController : ControllerBase
    {
        // Http verbs : Get, Post, Put, Delete
        [HttpGet]
        public List<string> GetString()
        {
            List<string> msg = new List<string>();
            msg.Add("Hello");
            msg.Add("Hello");
            msg.Add("Hello");

            return msg;             // json 형태로 반환됨 -> 클라이언트가 쉽게 파싱할 수 있음
        }
    }
}

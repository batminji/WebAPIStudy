namespace WebAPITest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers().AddXmlSerializerFormatters();
            // AddControllers() : 컨트롤러를 서비스로 등록하는 메서드
            // AddXmlSerializerFormatters() : Jsoon이 아닌 XML 형식으로 데이터를 반환할 수 있도록 설정하는 메서드

            var app = builder.Build();

            app.MapControllers();                  
            // MapControllers() : 컨트롤러를 라우팅 시스템에 등록하는 메서드

            app.Run();
        }
    }
}

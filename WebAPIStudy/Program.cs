
namespace WebAPIStudy
{
    public class Test
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);       // Web API를 만들기 위한 인스턴스를 생성

            // Add services to the container.

            builder.Services.AddControllers();                      // Controller 사용 여부를 설정
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            // builder.Services.AddEndpointsApiExplorer();
            // builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            // if (app.Environment.IsDevelopment())                  // 개발 환경에서만 Swagger UI를 사용
            // {
            //     app.UseSwagger();
            //     app.UseSwaggerUI();
            // }

            app.UseHttpsRedirection();                                // HTTPS 보완 연결 설정

            // app.UseAuthorization();                                // 보안 관련 인증

            app.MapControllers();                                     // 컨트롤러 엔드포인트와 같이 바인딩 시켜줌.

            app.Run();                                                // 웹 API 실행
        }
    }
}

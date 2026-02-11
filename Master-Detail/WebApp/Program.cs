namespace WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();//+
            builder.Services.AddSwaggerGen();//+
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddTransient<Data.IContext, Data.Context>();
            builder.Services.AddOpenApi();
            //builder.Services.AddSwaggerGen(c => c.SwaggerDoc("v1", new()
            //{ Title = "Master-Detail API", Version = "v1" }));
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                //app.UseSwagger();
                //app.UseSwaggerUI(c =>
                //{
                //    c.SwaggerEndpoint("/swagger/v1/swagger.json",
                //        "Master-Detail API Version 1");

                //    c.SupportedSubmitMethods(new[]
                //    {
                //        SubmitMethod.Get, SubmitMethod.Post,
                //        SubmitMethod.Put, SubmitMethod.Delete});
                //});
                app.UseSwagger();
                app.UseSwaggerUI(options => // UseSwaggerUI is called only in Development.
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                    options.RoutePrefix = string.Empty;
                });
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}

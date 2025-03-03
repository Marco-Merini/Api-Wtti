using ApiProdutosPessoas.Data;
using ApiProdutosPessoas.Repositories;
using ApiProdutosPessoas.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;

namespace SistemadeTarefas
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // M�todo para configurar os servi�os da aplica��o
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Configurando o Entity Framework com SQL Server
            services.AddDbContext<ProdutosPessoasdbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("Database")));

            // Inje��o de Depend�ncia dos Reposit�rios
            services.AddScoped<InterfacePessoa, PessoaRepositorio>();
            services.AddScoped<InterfaceProduto, ProdutoRepositorio>();
            services.AddScoped<InterfaceDependente, DependenteRepositorio>();
            //services.AddScoped<InterfaceMarca, MarcaRepositorio>();
            //services.AddScoped<InterfaceCidade, CidadeRepositorio>();

            // Configura��o do Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProdutosPessoas", Version = "v1" });
            });
        }

        // M�todo para configurar o pipeline de requisi��es HTTP
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProdutosPessoas v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

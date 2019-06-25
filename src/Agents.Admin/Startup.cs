using System;
using System.IO;
using Agents.Data;
using Agents.Data.UnitOfWorks.SqlServer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Util;
using Util.Datas.Ef;
using Util.Logs.Extensions;
using Util.Ui.Extensions;
using Util.Webs.Extensions;

namespace Agents {
    /// <summary>
    /// ��������
    /// </summary>
    public class Startup {
        /// <summary>
        /// ��ʼ����������
        /// </summary>
        /// <param name="configuration">����</param>
        public Startup( IConfiguration configuration ) {
            Configuration = configuration;
        }

        /// <summary>
        /// ����
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// ���÷���
        /// </summary>
        public IServiceProvider ConfigureServices( IServiceCollection services ) {
            //ע��Razor��ͼ����·��
            services.AddRazorViewLocationExpander();

            //���Mvc����
            services.AddMvc().SetCompatibilityVersion( CompatibilityVersion.Version_2_2 ).AddRazorPageConventions();

            //���NLog��־����
            services.AddNLog();

            //���EF������Ԫ
            services.AddUnitOfWork<IAgentsUnitOfWork, AgentsUnitOfWork>( Configuration.GetConnectionString( "DefaultConnection" ) );

            //���Swagger
            services.AddSwaggerGen( options => {
                options.SwaggerDoc( "v1", new Info { Title = "Agents Api", Version = "v1" } );
                options.IncludeXmlComments( Path.Combine( AppContext.BaseDirectory, "Agents.Admin.xml" ) );
            } );

            //���Util������ʩ����
            return services.AddUtil();
        }

        /// <summary>
        /// ���ÿ�����������ܵ�
        /// </summary>
        public void ConfigureDevelopment( IApplicationBuilder app ) {
            app.UseDeveloperExceptionPage();
            app.UseDatabaseErrorPage();
            app.UseWebpackDevMiddleware( new WebpackDevMiddlewareOptions {
                HotModuleReplacement = true
            } );
            app.UseSwaggerX();
            CommonConfig( app );
        }

        /// <summary>
        /// ����������������ܵ�
        /// </summary>
        public void ConfigureProduction( IApplicationBuilder app ) {
            app.UseExceptionHandler( "/Home/Error" );
            CommonConfig( app );
        }

        /// <summary>
        /// ��������
        /// </summary>
        private void CommonConfig( IApplicationBuilder app ) {
            app.UseErrorLog();
            app.UseStaticFiles();
            app.UseAuthentication();
            ConfigRoute( app );
        }

        /// <summary>
        /// ·������,֧������
        /// </summary>
        private void ConfigRoute( IApplicationBuilder app ) {
            app.UseMvc( routes => {
                routes.MapSpaFallbackRoute( "spa-fallback", new { controller = "Home", action = "Index" } );
            } );
        }
    }
}

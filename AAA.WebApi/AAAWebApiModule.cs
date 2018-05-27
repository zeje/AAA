using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace AAA
{
    [DependsOn(typeof(AbpWebApiModule), typeof(AAAApplicationModule))]
    public class AAAWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(AAAApplicationModule).Assembly, "app")
                .Build();
        }
    }
}

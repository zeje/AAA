using System.Reflection;
using Abp.Modules;

namespace AAA
{
    [DependsOn(typeof(AAACoreModule))]
    public class AAAApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

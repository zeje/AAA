using System.Reflection;
using Abp.Modules;

namespace AAA
{
    public class AAACoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

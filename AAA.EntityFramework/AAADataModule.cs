using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using AAA.EntityFramework;

namespace AAA
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(AAACoreModule))]
    public class AAADataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<AAADbContext>(null);
        }
    }
}

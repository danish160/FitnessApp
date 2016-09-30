using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using FitnessApp.EntityFramework;

namespace FitnessApp.Migrator
{
    [DependsOn(typeof(FitnessAppDataModule))]
    public class FitnessAppMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<FitnessAppDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
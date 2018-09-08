using Autofac;
using System.Reflection;
using Module = Autofac.Module;

namespace SaveMeSomeMoney.Services
{
    public class ServicesAutofacModule : Module
    {
        #region Protected Methods

        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces();
        }

        #endregion
    }
}

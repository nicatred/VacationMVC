

using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TokenManager>().As<ITokenService>().InstancePerLifetimeScope();
            builder.RegisterType<AuthManager>().As<IAuthService>().InstancePerLifetimeScope();

            builder.RegisterType<EfUserDal>().As<IUserDal>().InstancePerLifetimeScope();
            builder.RegisterType<UserManager>().As<IUserService>().InstancePerLifetimeScope();

            builder.RegisterType<VacationRequestManager>().As<IVacationRequestService>().InstancePerLifetimeScope();
            builder.RegisterType<EfVacationRequestDal>().As<IVacationRequestDal>().InstancePerLifetimeScope();

            builder.RegisterType<VacationTypeManager>().As<IVacationTypeService>().InstancePerLifetimeScope();
            builder.RegisterType<EfVacationTypeDal>().As<IVacationTypeDal>().InstancePerLifetimeScope();
        }
    }
}

using System.Data.Entity;
using System.Web.Http;
using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using OnlineBanking.Models.Contract.Repo;
using OnlineBanking.Models.Repo;
using OnlineBanking.Models;
using OnlineBanking.Models.Contract;

namespace OnlineBanking.Service
{
    public class AutofacConfig
    {
        protected DbContext mContext = new UserContext();
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
           

        builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //builder.RegisterType<CreateRepository<Client>>()
            //    .As<ICreateRepository<IEntity>>()
            //    .WithParameter("context", new UserContext());
            builder.RegisterGeneric(typeof (CreateRepository<>)).As(typeof (ICreateRepository<>))
                .WithParameter("context", new UserContext());

            builder.RegisterGeneric(typeof(ReadRepository<>)).As(typeof(IReadRepository<>))
            .WithParameter("context", new UserContext());

            //builder.RegisterGeneric(typeof(UpdateRepository)).As(typeof(UpdateRepository))
            //.WithParameter("context", new UserContext());

            //builder.RegisterGeneric(typeof(DeleteRepository<>)).As(typeof(IDeleteRepository<>))
            //.WithParameter("context", new UserContext());

            //     builder.RegisterAssemblyTypes(typeof (ICreateRepository<>).Assembly).AsClosedTypesOf(typeof(ICreateRepository<Status>))



            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
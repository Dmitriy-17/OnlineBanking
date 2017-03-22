using System.Data.Entity;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using OnlineBanking.Models;
using OnlineBanking.Models.Contract.Repo;
using OnlineBanking.Models.Repo;

namespace OnlineBanking.Service
{
    public class AutofacConfig
    {
        protected static DbContext mContext = new UserContext();
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
           

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            builder.RegisterGeneric(typeof (CreateRepository<>)).As(typeof (ICreateRepository<>))
                .WithParameter("context", mContext);

            builder.RegisterGeneric(typeof(ReadRepository<>)).As(typeof(IReadRepository<>))
            .WithParameter("context", mContext);

            builder.RegisterGeneric(typeof(UpdateRepository<>)).As(typeof(IUpdateRepository<>))
            .WithParameter("context", mContext);

            builder.RegisterGeneric(typeof(DeleteRepository<>)).As(typeof(IDeleteRepository<>))
            .WithParameter("context", mContext);

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver((IContainer)container); //Set the WebApi DependencyResolver
        }
    }
}
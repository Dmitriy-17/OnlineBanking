using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using OnlineBanking.Models;
using OnlineBanking.Models.Repo;
using Autofac;
using Autofac.Core;
using OnlineBanking.Models.Contract;
using  OnlineBanking.Service;
using OnlineBanking.Models.Contract.Repo;
using Filter = OnlineBanking.Models.Filter;



namespace OnlineBanking.Controllers
{
    public class HomeController : Controller
    {
        private IReadRepository<Status> mReadRepository;
        private ICreateRepository<Status> mCreateRepository;
        public HomeController(ICreateRepository<Status> createRepo, IReadRepository<Status> readRepo)
        {
            mCreateRepository = createRepo;
            mReadRepository = readRepo;
        }

        public Action HandleAjaxRequest(Action action)
        {
            try
            {
                var result = action();
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
      
        public ActionResult Index()
        {
            var status = new Status()
            {
                Name = "new"
            };

            var filter = new Filter()
            {
                Name = "new"
            };
  

           // var result = HandleAjaxRequest(mReadRepository.GetAll());




            var res = mReadRepository.GetAll(x => x.Name == "new");

            //var client = new Client()
            //{
            //    FirstName = "name1",
            //    DateOfBirth = DateTime.Now,
            //    LastName = "gfhj"
            //}}
            return View();
        }

        public ActionResult Login()
        {
           

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
using System;
using System.Web.Mvc;
using System.Web.Security;
using AutoMapper;
using OnlineBanking.Models;
using OnlineBanking.Models.Account;
using OnlineBanking.Models.Contract;
using OnlineBanking.Models.Contract.Repo;
using OnlineBanking.Models.Repo;
using OnlineBanking.Service;
using Filter = OnlineBanking.Models.Filter;

namespace OnlineBanking.Controllers
{
    public class HomeController : BaseController
    {
        private IReadRepository<User> mReadRepository;
        private ICreateRepository<User> mCreateRepository;
        private IUpdateRepository<User> mUpdateRepository;

        public HomeController(ICreateRepository<User> createRepo, IReadRepository<User> readRepo,
            IUpdateRepository<User> updateRepo)
        {

            mCreateRepository = createRepo;
            mReadRepository = readRepo;
            mUpdateRepository = updateRepo;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLogin user)
        {
            if (ModelState.IsValid)
            {
                var dbUser = TryAction(() => mReadRepository.GetFirstOfDefault(x => x.Login == user.Login)) ;

                if (dbUser == null)
                {
                    ModelState.AddModelError("", "User not found");
                    return View(user);
                }

                if (!dbUser.IsBlocked)
                {
                    if (dbUser.Password == user.Password)
                    {
                        FormsAuthentication.SetAuthCookie(dbUser.Name, true);
                        dbUser.CountAttemptsToAccess = 0;
                        PerformCall(() => mUpdateRepository.Update(dbUser));
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        dbUser.CountAttemptsToAccess ++;
                        if (dbUser.CountAttemptsToAccess == 5)
                        {
                            ModelState.AddModelError("", "User is blocked");
                            dbUser.IsBlocked = true;
                            PerformCall(() => mUpdateRepository.Update(dbUser));
                            ///TODO: go to inbloked 
                        }
                        else
                        {
                            PerformCall(() => mUpdateRepository.Update(dbUser));
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "User is blocked");
                    ///TODO: go to inbloked 
                }

            }
            return View(user);
        }


        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Registration()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Registration(UserRegister user)
        {
            if (user.IsValid())
            {
                var tempUser = Mapper.Map<UserRegister, User>(user);
                tempUser.RoleId = 2;
                PerformCall(() => mCreateRepository.Create(tempUser));
                return RedirectToAction("Index");
            }
            return View(user);
        }
    }
}
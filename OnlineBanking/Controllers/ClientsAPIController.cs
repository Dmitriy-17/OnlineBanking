using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Http;
using System.Web.Script.Serialization;
using OnlineBanking.Models;
using OnlineBanking.Models.Contract;
using OnlineBanking.Models.Contract.Repo;
using OnlineBanking.Models.Repo;

namespace OnlineBanking.Controllers
{

    public class ClientsController : BaseAPIController
    {
        private IReadRepository<Client> mReadRepository;
        private ICreateRepository<Client> mCreateRepository;
        private IUpdateRepository<Client> mUpdateRepository;
        private IDeleteRepository<Client> mDeleteRepository;

        public ClientsController(ICreateRepository<Client> createRepo, IReadRepository<Client> readRepo,
            IUpdateRepository<Client> updateRepo, IDeleteRepository<Client> deleteRepo)
        {
            mCreateRepository = createRepo;
            mReadRepository = readRepo;
            mUpdateRepository = updateRepo;
            mDeleteRepository = deleteRepo;
        }


        [HttpGet, Route("api/clients/{id:int}")]
        public IHttpActionResult Get(int Id)
        {
            var res = TryAction(() => mReadRepository.GetByIdAsync(Id));
            return Ok(res);
        }

        [HttpPut, Route("api/clients/")]
        public void Add(Client client)
        {
            if (client != null && client.IsValid())
            {
                PerformCall(() => mCreateRepository.Create(client));
            }
        }

        [HttpGet, Route("api/clients/")]
        public IHttpActionResult All([FromUri] Filter filter = null)
        {
            IEnumerable<Client> result;
            if (filter == null)
            {
                result = TryAction(() => mReadRepository.GetAll());
            }
            else
            {
                if (filter?.StatusId != null && filter?.StatusId > 0)
                {
                    var res = TryAction(() => mReadRepository.GetAll(x => x.StatusId == filter.StatusId));
                    result = res;
                }
                else
                {
                    result = null;
                }
            }


            return Ok(result);
        }

        [HttpPost, Route("api/clients/")]
        public void Update(Client client)
        {
            if (client != null && client.IsValid())
            {
              PerformCall(() =>  mUpdateRepository.Update(client));
            }
        }

        [HttpPost, Route("api/clients/remove/")]
        public void Delete(Client entity)
        {
            var clientExist = TryAction(() => mReadRepository.GetByIdAsync(entity.Id));
            if (clientExist != null)
            {
                PerformCall(() => mDeleteRepository.Delete(entity));
            }
        }
    }
}

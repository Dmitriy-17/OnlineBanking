using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OnlineBanking.Models.Contract
{
    public interface IDbContextContainer
    {
        DbContext GetDataContext();
        void Store(DbContext dbContext);
    }
}
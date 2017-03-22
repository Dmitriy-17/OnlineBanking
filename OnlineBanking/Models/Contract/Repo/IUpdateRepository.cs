﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBanking.Models.Contract.Repo
{
    public interface IUpdateRepository<IEntity>
    {
        void Update(IEntity entity);
    }
}

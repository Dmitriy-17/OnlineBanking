﻿using System;
using System.Data.Entity;

namespace OnlineBanking.Models.Repo
{
    public class BaseRepository
    {
        protected DbContext mContext;
        public BaseRepository(DbContext context)
        {
            mContext = context;
        }

        private bool disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    mContext.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
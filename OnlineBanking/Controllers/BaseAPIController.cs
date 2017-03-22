﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using OnlineBanking.Service;

namespace OnlineBanking.Controllers
{
    public class BaseAPIController : ApiController
    {
        protected void PerformCall(Action action)
        {
            try
            {
                action();
            }
            catch (ValidationException ex)
            {
                Logger.Log.Error(ex);
            }
            catch (HttpRequestValidationException ex)
            {
                Logger.Log.Error(ex);
            }
            catch (IndexOutOfRangeException ex)
            {
                Logger.Log.Error(ex);

            }
            catch (NotImplementedException ex)
            {
                Logger.Log.Error(ex);
            }
            catch (NullReferenceException ex)
            {
                Logger.Log.Error(ex);
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
            }
        }
        protected T TryAction<T>(Func<T> call)
        {
            try
            {
                return call();
            }
            catch (ValidationException ex)
            {
                Logger.Log.Error(ex);
            }
            catch (HttpRequestValidationException ex)
            {
                Logger.Log.Error(ex);
            }
            catch (IndexOutOfRangeException ex)
            {
                Logger.Log.Error(ex);

            }
            catch (NotImplementedException ex)
            {
                Logger.Log.Error(ex);
            }
            catch (NullReferenceException ex)
            {
                Logger.Log.Error(ex);
            }
            catch (Exception ex)
            {
                Logger.Log.Error(ex);
            }

            return default(T);
        }

    }
}
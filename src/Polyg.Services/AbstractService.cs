using Microsoft.AspNetCore.Routing.Template;
using Polyg.Common.Domain;
using Polyg.Contract.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Polyg.Services
{
    public abstract class AbstractService
    {
        public AbstractService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        protected ServiceResult<TResult> ResultFromSuccess<TResult>(TResult result)
        {
            return new ServiceResult<TResult>
            {
                Result = result
            };
        }

        protected ServiceResult<TResult> ResultFromError<TResult>(string errorMessage, TResult result = default)
        {
            return new ServiceResult<TResult>
            {
                Result = result,
                ErrorMessage = errorMessage,
                StatusCode = ServiceStatusCode.Error
            };
        }

        protected ServiceResult<TResult> ResultFromValidationError<TResult>(string errorMessage, TResult result = default)
        {
            return new ServiceResult<TResult>
            {
                Result = result,
                ErrorMessage = errorMessage,
                StatusCode = ServiceStatusCode.ValidationError
            };
        }

        protected IUnitOfWork UnitOfWork { get; }
    }
}

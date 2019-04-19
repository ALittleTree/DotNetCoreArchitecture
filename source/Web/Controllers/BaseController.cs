using DotNetCore.AspNetCore;
using DotNetCore.Extensions;
using DotNetCore.Objects;
using DotNetCoreArchitecture.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DotNetCoreArchitecture.Web
{
    public abstract class BaseController : ControllerBase
    {
        protected SignedInModel SignedInModel => new SignedInModel
        {
            UserId = User.Id(),
            Roles = (Roles)User.Roles<Roles>().Sum(value => Convert.ToInt64(value))
        };

        protected DefaultResult Result(IResult result)
        {
            return new DefaultResult(result);
        }
    }
}

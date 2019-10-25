﻿using System.Security.Claims;
using System.Threading.Tasks;
using Havit.AskMe.Web.Blazor.Shared;

namespace Havit.AskMe.Web.Blazor.Client.Services.Security
{
	public interface IAuthenticationClientFacade
	{
		Task<LoginVM> Login(LoginIM inputModel);
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;
using System.Web.SessionState;
using PartyInvities.Controllers;

namespace PartyInvities.Infrastructure
{
	public class CustomControllerFactory : IControllerFactory
	{
		public IController CreateController(RequestContext requestContext, string controllerName)
		{
			Type targetType = null;
			switch (controllerName)
			{
				case "Home":
					targetType = typeof(HomeController);
					break;

				case "OakGrove":
					targetType = typeof(OakGroveController);
					break;

				default:
					requestContext.RouteData.Values["controller"] = "Home";
					targetType = typeof(HomeController);
					break;
			}

			return targetType == null ? null :
				(IController)DependencyResolver.Current.GetService(targetType);
		}

		public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
		{
			return SessionStateBehavior.Default;
		}

		public void ReleaseController(IController controller)
		{
			IDisposable disposable = controller as IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}
	}
}
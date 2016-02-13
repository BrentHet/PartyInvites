using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvities.Extensions
{
    public static class HTMLExtensions
    {
        public static MvcHtmlString Widget(this HtmlHelper helper, string widgetZone, object additionalData = null, string area = null)
        {
            return new MvcHtmlString("This is text from my widget html helper.");
        }
    }
}
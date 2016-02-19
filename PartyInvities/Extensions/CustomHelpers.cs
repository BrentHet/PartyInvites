using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvities.Extensions
{
	public static class CustomHelpers
	{
		public static MvcHtmlString ExternalListArrayItems(this HtmlHelper html, string[] items)
		{
			TagBuilder tag = new TagBuilder("ul");

			foreach (string str in items)
			{
				TagBuilder liTag = new TagBuilder("li");
				liTag.SetInnerText(str);
				tag.InnerHtml += liTag.ToString();
			}

			return new MvcHtmlString(tag.ToString());
		}
	}
}
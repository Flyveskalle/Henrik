using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace Henrik.Web.Business.Extentions
{
    public static class PublishedContentExtentions
    {
        public static string GetImageUrl(this IPublishedContent content)
        {
            return content.GetPropertyValue<string>(Constants.UmbracoFile);
        }

        public static string GetImageUrl(this Media content)
        {
            return content.GetImageUrl();
        }

        public static string GetImageUrl(this IContent content)
        {
            return content.GetValue<string>(Constants.UmbracoFile);
        }
    }
}
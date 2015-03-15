using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Dml.BirdMap.Extensions
{
    public static class AppExtensions
    {
        public static string AppName(this HtmlHelper helper)
        {
            return (AppConstants.AppName);
        }
    }
}
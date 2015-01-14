using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDemo1.Helpers
{
    public static class ImageHelper
    {
        public static IHtmlString RenderImage()
        {
            return new HtmlString("<img src=\"/Images/bullet.png\" height='100' width='100' />");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CustomHelper
    {
        public static IHtmlString DisplayPriceStatic(decimal price)
        {
            //var result = string.Empty;
            //if (price == 0)
            //{
            //    result = "<span>Free!!!</span>";
            //}
            //else
            //{
            //    result = $"<span>{price}</span>";
            //}
            return new HtmlString(GetHtmlForPrice(price));
        }

        public static IHtmlString DisplayPriceExtension(this HtmlHelper helper, decimal price)
        {
            //var result = string.Empty;
            //if (price == 0)
            //{
            //    result = "<span>Free!!!</span>";
            //}
            //else
            //{
            //    result = $"<span>{price}</span>";
            //}
            return new HtmlString(GetHtmlForPrice(price));
        }

        public static IHtmlString DisplayDateOrNull (DateTime? createDate)
        {
            //var result = string.Empty;
            //if (createDate == null)
            //{
            //    result = "<span> No time </span>";
            //}
            //else
            //{
            //    result = $"<span>{createDate}</span>";
            //}
            return new HtmlString(GetDateHtml(createDate));
        }

        public static IHtmlString DisplayDateOrNullExtension(this HtmlHelper helper, DateTime? createDate)
        {
            //var result = string.Empty;
            //if (createDate == null)
            //{
            //    result = "<span> No time </span>";
            //}
            //else
            //{
            //    result = $"<span>{createDate}</span>";
            //}
            return new HtmlString(GetDateHtml(createDate));
        }

        private static string GetHtmlForPrice(decimal price)
        {
            return price == 0 ? "<span>Free!!!</span>" : $"<span>{price.ToString()}</span>";
        }

        private static string GetDateHtml(DateTime? date)
        {
            return date.HasValue ? $"<span>{date.Value.ToString("dd-mm-yyyy")}</span>";
        }
    }
}

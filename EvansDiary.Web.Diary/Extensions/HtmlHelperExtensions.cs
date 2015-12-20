using System;
using System.Linq.Expressions;
using System.Web.Mvc;
using System.Web.Routing;

namespace EvansDiary.Web.Diary.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static ScopedLink ScopedActionLink<TController>(
            this HtmlHelper htmlHelper,
            Expression<Action<TController>> expression,
            object htmlAttributes = null,
            object routeValues = null,
            bool show = true,
            string fragment = null)
            where TController : Controller
        {
            return ScopedActionLink(htmlHelper, expression, null, fragment, htmlAttributes, routeValues, show);
        }

        public static string GenerateUrl<TController>(
            Expression<Action<TController>> expression,
            string routeName,
            string fragment,
            object routeValues,
            RouteCollection routeCollection,
            RequestContext requestContext)
            where TController : Controller
        {
            var routeInfo = RouteCollectionExtensions.GetRouteInfo(expression);

            var routes = new RouteValueDictionary(routeValues);

            for (var parameterIndex = 0; parameterIndex < routeInfo.ActionArgumentParameters.Length; parameterIndex++)
            {
                if (!routes.ContainsKey(routeInfo.ActionArgumentParameters[parameterIndex].Name))
                {
                    routes.Add(routeInfo.ActionArgumentParameters[parameterIndex].Name,
                        routeInfo.ActionArguments[parameterIndex]);
                }
            }

            var routeHasName = routeCollection[routeName ?? routeInfo.RouteName] != null;

            return UrlHelper.GenerateUrl(
                routeHasName
                    ? routeName ?? routeInfo.RouteName
                    : null,
                routeInfo.ActionName,
                routeInfo.ControllerName,
                null,
                null,
                fragment,
                routes,
                routeCollection,
                requestContext,
                true);
        }

        public static ScopedLink ScopedActionLink<TController>(
            this HtmlHelper htmlHelper,
            Expression<Action<TController>> expression,
            string routeName,
            string fragment,
            object htmlAttributes = null,
            object routeValues = null,
            bool show = true)
            where TController : Controller
        {
            if (show)
            {
                var url = GenerateUrl(expression, routeName, fragment, routeValues, htmlHelper.RouteCollection,
                    htmlHelper.ViewContext.RequestContext);

                var tagBuilder = new TagBuilder("a");
                tagBuilder.MergeAttributes(HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes));
                tagBuilder.MergeAttribute("href", url);

                htmlHelper.ViewContext.Writer.Write(tagBuilder.ToString(TagRenderMode.StartTag));
            }

            var theForm = new ScopedLink(htmlHelper.ViewContext, show);

            return theForm;
        }

        public class ScopedLink : IDisposable
        {
            private readonly bool _show;

            private readonly ViewContext _viewContext;

            private bool _disposed;

            public ScopedLink(ViewContext viewContext, bool show)
            {
                _viewContext = viewContext;
                _show = show;
            }

            public void Dispose()
            {
                Dispose(true /* disposing */);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (_disposed)
                {
                    return;
                }

                _disposed = true;

                if (_show)
                {
                    _viewContext.Writer.Write("</a>");
                }
            }
        }
    }
}
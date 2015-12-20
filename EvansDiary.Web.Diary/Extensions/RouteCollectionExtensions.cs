using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web.Mvc;
using System.Web.Routing;

namespace EvansDiary.Web.Diary.Extensions
{
    public static class RouteCollectionExtensions
    {
        public static RouteInfo GetRouteInfo<TController>(
            Expression<Action<TController>> expression,
            string routeName = null)
            where TController : Controller
        {
            var controllerName = typeof(TController)
                .Name
                .Remove(
                    typeof(TController)
                        .Name
                        .LastIndexOf("Controller", StringComparison.Ordinal));

            var actionInfo = GetMemberInfo(expression) as MethodInfo;

            if (actionInfo == null)
            {
                throw new ArgumentException("Action not a method");
            }

            var arguments = GetArguments(expression) ?? new object[0];

            var parameters = actionInfo
                .GetParameters();

            var actionName = actionInfo.Name;

            var parameterTypes = parameters
                .Select(argument => argument.ParameterType.Name);

            routeName = routeName
                        ?? string.Format("{0}-{1}{2}", controllerName, actionName, string.Join("-", parameterTypes));

            return new RouteInfo
            {
                ControllerName = controllerName,
                ActionName = actionName,
                ActionArguments = arguments,
                ActionArgumentParameters = parameters,
                RouteName = routeName,
            };
        }

        public static Route MapRoute<TController>(
            this RouteCollection routes,
            Expression<Action<TController>> expression,
            string url,
            object defaults = null,
            object constraints = null,
            string routeName = null,
            bool useActionArgumentsAsDefaults = true)
            where TController : Controller
        {
            var routeInfo = GetRouteInfo(expression, routeName);

            dynamic dynamicDefaults = (defaults ?? new object()).ToExpando();

            if (useActionArgumentsAsDefaults)
            {
                AddParameterDefaults(dynamicDefaults, routeInfo);
            }

            dynamicDefaults.controller = routeInfo.ControllerName;

            dynamicDefaults.action = routeInfo.ActionName;

            var namespaces = new[] { typeof(TController).Namespace };

            return routes
                .MapRoute(routeInfo.RouteName, url, (ExpandoObject)dynamicDefaults, constraints, namespaces);
        }

        private static void AddParameterDefaults(dynamic defaults, RouteInfo routeInfo)
        {
            for (var parameterIndex = 0; parameterIndex < routeInfo.ActionArgumentParameters.Length; parameterIndex++)
            {
                var defaultsDictionary = (IDictionary<string, object>)defaults;

                var parameterName = routeInfo.ActionArgumentParameters[parameterIndex].Name;

                if (!defaultsDictionary.ContainsKey(parameterName))
                {
                    defaultsDictionary.Add(parameterName, routeInfo.ActionArguments[parameterIndex]);
                }
            }
        }

        private static object[] GetArguments<TController>(Expression<Action<TController>> expression)
        {
            var member = expression.Body as MethodCallExpression;
            if (member != null)
            {
                return member
                    .Arguments
                    .Select(
                        argument =>
                        {
                            if (argument == null)
                            {
                                return null;
                            }

                            var constantExpression = argument as ConstantExpression;
                            if (constantExpression != null)
                            {
                                return constantExpression.Value;
                            }

                            return Expression
                                .Lambda(Expression.Convert(argument, argument.Type))
                                .Compile()
                                .DynamicInvoke();
                        })
                    .ToArray();
            }

            throw new ArgumentException("Expression is not a member access", "expression");
        }

        private static MemberInfo GetMemberInfo<TController>(Expression<Action<TController>> expression)
        {
            var member = expression.Body as MethodCallExpression;
            if (member != null)
            {
                return member.Method;
            }

            throw new ArgumentException("Expression is not a member access", "expression");
        }

        public class RouteInfo
        {
            public ParameterInfo[] ActionArgumentParameters { get; set; }

            public object[] ActionArguments { get; set; }

            public string ActionName { get; set; }

            public string ControllerName { get; set; }

            public string RouteName { get; set; }
        }
    }
}
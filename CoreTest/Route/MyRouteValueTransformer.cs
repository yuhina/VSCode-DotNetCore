

using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;

namespace CoreTest.Route
{
    public class MyRouteValueTransformer : DynamicRouteValueTransformer
    {
        public override ValueTask<RouteValueDictionary> TransformAsync(HttpContext httpContext, RouteValueDictionary values)
        {
            //通过values可以拿到原始路由数据
            //可以替换或加入新的数据
            values.Add("controller", "Hello");
            values.Add("action", "Welcome");
            return new ValueTask<RouteValueDictionary>(values);
        }
    }
}

.net Core 路由https://www.cnblogs.com/jionsoft/p/12115417.html
1.特定路由 所有类及方法都标记 Route[""]
2.自动匹配路由  services.AddControllersWithViews();
endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}");
3.改变路由
 public override ValueTask<RouteValueDictionary> TransformAsync(HttpContext httpContext, RouteValueDictionary values)
        {
            //通过values可以拿到原始路由数据
            //可以替换或加入新的数据
            values.Add("controller", "Hello");
            values.Add("action", "Welcome");
            return new ValueTask<RouteValueDictionary>(values);
        }
services.AddSingleton<MyRouteValueTransformer>();



.net core 验证
1.登录用户验证
public class LoginAuthorzation : AuthorizeFilter
{
//重写验证方法
public override async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            
        }
}
services.AddMvc(options =>
            {
                options.Filters.Add<LoginAuthorzation>(); // 添加身份验证过滤器
            });
2.方法权限的验证
public class MyAttributeFilter:ActionFilterAttribute
options.Filters.Add<ActionFilterAttributeLogin>();

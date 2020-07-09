
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CoreTest.Filter
{
    public class AllowAnonymous : AuthorizeFilter, IAllowAnonymousFilter
    {

    }
    public class LoginAuthorzation : AuthorizeFilter
    {
        public override async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            //判断访问的conttroller 是否需要登录验证
            //如果需要则返回Authorization 的页面
             context.Result = new RedirectResult("/Home/Index");

            //如果不需要直接返回
            return ;
        }
    }
}
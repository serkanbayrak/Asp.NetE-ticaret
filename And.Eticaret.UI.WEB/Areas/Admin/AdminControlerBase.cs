using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace And.Eticaret.UI.WEB.Areas.Admin
{
    public class AdminControlerBase : Controller
    {
        protected override void Initialize(RequestContext requestContext)
        {
            var IsLogin = false;
            if (requestContext.HttpContext.Session["AdminLoginUser"]==null)
            {
                //Admin Giriş Yapılmamış
                requestContext.HttpContext.Response.Redirect("/Admin/AdminLogin");
             
            }
            else
            {
                //sorun Yok Admin içerde
                //sayfa çalıştır
                base.Initialize(requestContext);
            }
            base.Initialize(requestContext);
        }
    }
}
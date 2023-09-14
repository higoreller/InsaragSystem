using Microsoft.AspNetCore.Mvc;

namespace InsaragSystem.Dashboard.Controllers.Auth
{
    public class AuthController : Controller
    {
        //
        // GET: /Auth/
        [ActionName("login")]
        public ActionResult login()
        {
            return View();
        }

        [ActionName("register")]
        public ActionResult register()
        {
            return View();
        }

        [ActionName("recoverpassword")]
        public ActionResult recoverpassword()
        {
            return View();
        }

        [ActionName("lockscreen")]
        public ActionResult lockscreen()
        {
            return View();
        }
    }
}

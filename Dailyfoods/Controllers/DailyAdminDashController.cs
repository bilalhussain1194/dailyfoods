using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dailyfoods.Controllers
{
    public class DailyAdminDashController : Controller
    {
        [Authorize(Roles ="superadmin")]
        // GET: DailyAdminDash
        [Route("admin")]
        public ActionResult Index()
        {

            return View();
        }
    }
}
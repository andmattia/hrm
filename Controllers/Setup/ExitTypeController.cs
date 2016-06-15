using System.Web.Mvc;
using Frapid.Areas;
using Frapid.Areas.Authorization;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;

namespace MixERP.HRM.Controllers.Setup
{
    public class ExitTypeController : DashboardController
    {
        [Route("dashboard/hrm/setup/exit-types")]
        [RestrictAnonymous]
        [MenuPolicy]
        [ScrudFactory]
        public ActionResult Index()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Setup/ExitTypes/Index.cshtml", this.Tenant));
        }
    }
}
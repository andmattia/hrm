using System.Web.Mvc;
using Frapid.Areas;
using Frapid.Areas.Authorization;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;

namespace MixERP.HRM.Controllers.Verification
{
    public class ExitVerificationController : DashboardController
    {
        [Route("dashboard/hrm/verification/exits")]
        [RestrictAnonymous]
        [MenuPolicy]
        [ScrudFactory]
        public ActionResult Index()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Verification/Exits/Index.cshtml", this.Tenant));
        }
    }
}
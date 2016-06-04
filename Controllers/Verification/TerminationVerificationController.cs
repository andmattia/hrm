using System.Web.Mvc;
using Frapid.Areas.Authorization;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;

namespace MixERP.HRM.Controllers.Verification
{
    public class TerminationVerificationController : DashboardController
    {
        [Route("dashboard/hrm/verification/terminations")]
        [RestrictAnonymous]
        [MenuPolicy]
        public ActionResult Index()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Verification/Terminations/Index.cshtml"));
        }
    }
}
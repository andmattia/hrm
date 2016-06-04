using System.Web.Mvc;
using Frapid.Areas.Authorization;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;

namespace MixERP.HRM.Controllers.Verification
{
    public class LeaveApplicationVerificationController : DashboardController
    {
        [Route("dashboard/hrm/verification/leave-applications")]
        [RestrictAnonymous]
        [MenuPolicy]
        public ActionResult Index()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Verification/LeaveApplications/Index.cshtml"));
        }
    }
}
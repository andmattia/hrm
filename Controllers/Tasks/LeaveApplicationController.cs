using System.Web.Mvc;
using Frapid.Areas.Authorization;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;

namespace MixERP.HRM.Controllers.Tasks
{
    public class LeaveApplicationController : DashboardController
    {
        [Route("dashboard/hrm/tasks/leave-applications")]
        [RestrictAnonymous]
        [MenuPolicy]
        public ActionResult Index()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Tasks/LeaveApplications/Index.cshtml", this.Tenant));
        }
    }
}
using System.Web.Mvc;
using Frapid.Areas;
using Frapid.Areas.Authorization;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;

namespace MixERP.HRM.Controllers.Tasks
{
    public class TerminationController : DashboardController
    {
        [Route("dashboard/hrm/tasks/terminations")]
        [MenuPolicy]
        [ScrudFactory]
        public ActionResult Index()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Tasks/Terminations/Index.cshtml", this.Tenant));
        }
    }
}
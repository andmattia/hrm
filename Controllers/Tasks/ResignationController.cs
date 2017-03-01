using System.Web.Mvc;
using Frapid.Areas;
using Frapid.Areas.Authorization;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;

namespace MixERP.HRM.Controllers.Tasks
{
    public class ResignationController : DashboardController
    {
        [Route("dashboard/hrm/tasks/resignations")]
        [MenuPolicy]
        [ScrudFactory]
        public ActionResult Index()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Tasks/Resignations/Index.cshtml", this.Tenant));
        }
    }
}
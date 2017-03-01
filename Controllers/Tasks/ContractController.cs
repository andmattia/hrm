using System.Web.Mvc;
using Frapid.Areas;
using Frapid.Areas.Authorization;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;

namespace MixERP.HRM.Controllers.Tasks
{
    public class ContractController : DashboardController
    {
        [Route("dashboard/hrm/tasks/contracts")]
        [MenuPolicy]
        [ScrudFactory]
        public ActionResult Index()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Tasks/Contracts/Index.cshtml", this.Tenant));
        }
    }
}
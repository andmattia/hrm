using System.Web.Mvc;
using Frapid.Areas;
using Frapid.Areas.Authorization;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;

namespace MixERP.HRM.Controllers.Setup
{
    public class LeaveBenefitController : DashboardController
    {
        [Route("dashboard/hrm/setup/leave-benefits")]
        [MenuPolicy]
        [ScrudFactory]
        public ActionResult Index()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Setup/LeaveBenefits/Index.cshtml", this.Tenant));
        }
    }
}
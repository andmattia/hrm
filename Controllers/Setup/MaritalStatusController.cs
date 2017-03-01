using System.Web.Mvc;
using Frapid.Areas;
using Frapid.Areas.Authorization;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;

namespace MixERP.HRM.Controllers.Setup
{
    public class MaritalStatusController : DashboardController
    {
        [Route("dashboard/hrm/setup/marital-statuses")]
        [MenuPolicy]
        [ScrudFactory]
        public ActionResult Index()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Setup/MaritalStatuses/Index.cshtml", this.Tenant));
        }
    }
}
using System.Web.Mvc;
using Frapid.Areas;
using Frapid.Areas.Authorization;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;

namespace MixERP.HRM.Controllers.Setup
{
    public class PayGradeController : DashboardController
    {
        [Route("dashboard/hrm/setup/pay-grades")]
        [MenuPolicy]
        [ScrudFactory]
        public ActionResult Index()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Setup/PayGrades/Index.cshtml", this.Tenant));
        }
    }
}
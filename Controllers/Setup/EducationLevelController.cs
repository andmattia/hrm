using System.Web.Mvc;
using Frapid.Areas;
using Frapid.Areas.Authorization;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;

namespace MixERP.HRM.Controllers.Setup
{
    public class EducationLevelController : DashboardController
    {
        [MenuPolicy]
        [ScrudFactory]
        [Route("dashboard/hrm/setup/education-levels")]
        public ActionResult Index()
        {
            var result = this.FrapidView(this.GetRazorView<AreaRegistration>("Setup/EducationLevels/Index.cshtml", this.Tenant));
            return result;
        }
    }
}
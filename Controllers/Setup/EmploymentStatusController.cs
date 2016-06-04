using System.Web.Mvc;
using Frapid.Areas.Authorization;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;

namespace MixERP.HRM.Controllers.Setup
{
    public class EmploymentStatusController : DashboardController
    {
        [Route("dashboard/hrm/setup/employment-statuses")]
        [RestrictAnonymous]
        [MenuPolicy]
        public ActionResult Index()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Setup/EmploymentStatuses/Index.cshtml"));
        }
    }
}
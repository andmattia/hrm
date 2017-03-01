using System.Web.Mvc;
using Frapid.Areas;
using Frapid.Areas.Authorization;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;

namespace MixERP.HRM.Controllers.Setup
{
    public class SocialNetworkController : DashboardController
    {
        [Route("dashboard/hrm/setup/social-networks")]
        [MenuPolicy]
        [ScrudFactory]
        public ActionResult Index()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Setup/SocialNetworks/Index.cshtml", this.Tenant));
        }
    }
}
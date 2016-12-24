using System.Threading.Tasks;
using System.Web.Mvc;
using Frapid.ApplicationState.Cache;
using Frapid.Areas.Authorization;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;
using MixERP.HRM.DAL;

namespace MixERP.HRM.Controllers.Tasks
{
    public class AttendanceController : DashboardController
    {
        [Route("dashboard/hrm/tasks/attendance")]
        [RestrictAnonymous]
        [MenuPolicy]
        public async Task<ActionResult> IndexAsync()
        {
            var meta = await AppUsers.GetCurrentAsync().ConfigureAwait(true);
            var model = await Employees.GetEmployeesAsync(this.Tenant, meta.OfficeId).ConfigureAwait(true);

            return this.FrapidView(this.GetRazorView<AreaRegistration>("Tasks/Attendance/Index.cshtml", this.Tenant), model);
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;
using Frapid.ApplicationState.Cache;
using Frapid.Areas.Authorization;
using Frapid.Areas.CSRF;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;
using MixERP.HRM.DAL;
using MixERP.HRM.DTO;

namespace MixERP.HRM.Controllers.Tasks
{
    [AntiForgery]
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

        [Route("dashboard/hrm/tasks/attendance")]
        [MenuPolicy]
        [HttpPost]
        public async Task<ActionResult> PutAsync(List<Attendance> model)
        {
            await Attendances.PostAsync(this.Tenant, model).ConfigureAwait(true);
            return this.Ok();
        }
    }
}
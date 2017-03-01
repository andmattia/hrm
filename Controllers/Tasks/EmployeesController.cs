using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using Frapid.Areas;
using Frapid.Areas.Authorization;
using Frapid.Dashboard;
using Frapid.Dashboard.Controllers;
using MixERP.HRM.Models;

namespace MixERP.HRM.Controllers.Tasks
{
    public class EmployeeController: DashboardController
    {
        [Route("dashboard/hrm/tasks/employees")]
        [MenuPolicy]
        [ScrudFactory]
        public ActionResult Index()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Tasks/Employees/Index.cshtml", this.Tenant));
        }

        [Route("dashboard/hrm/tasks/employees/experiences")]
        [MenuPolicy(OverridePath = "/dashboard/hrm/tasks/employees")]
        [ScrudFactory]
        public ActionResult DisplayExpriences()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Tasks/Employees/Experiences.cshtml", this.Tenant));
        }

        [Route("dashboard/hrm/tasks/employees/identification-details")]
        [MenuPolicy(OverridePath = "/dashboard/hrm/tasks/employees")]
        [ScrudFactory]
        public ActionResult DisplayIdentificationDetails()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Tasks/Employees/IdentificationDetails.cshtml", this.Tenant));
        }

        [Route("dashboard/hrm/tasks/employees/leave-application")]
        [MenuPolicy(OverridePath = "/dashboard/hrm/tasks/employees")]
        [ScrudFactory]
        public ActionResult DisplayLeaveApplication()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Tasks/Employees/LeaveApplication.cshtml", this.Tenant));
        }

        [Route("dashboard/hrm/tasks/employees/qualifications")]
        [MenuPolicy(OverridePath = "/dashboard/hrm/tasks/employees")]
        [ScrudFactory]
        public ActionResult DisplayQualifications()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Tasks/Employees/Qualifications.cshtml", this.Tenant));
        }

        [Route("dashboard/hrm/tasks/employees/social-networks")]
        [MenuPolicy(OverridePath = "/dashboard/hrm/tasks/employees")]
        [ScrudFactory]
        public ActionResult DisplaySocialNetworks()
        {
            return this.FrapidView(this.GetRazorView<AreaRegistration>("Tasks/Employees/SocialNetworks.cshtml", this.Tenant));
        }

        [Route("dashboard/hrm/tasks/employee-info/{employeeId}")]
        [MenuPolicy(OverridePath = "/dashboard/hrm/tasks/employees")]
        public async Task<ActionResult> EmployeeInfoAsync(int employeeId)
        {
            var model = await EmployeeInfoModel.GetAsync(this.Tenant, employeeId).ConfigureAwait(true);

            if (model == null)
            {
                return this.Failed("Employee not found", HttpStatusCode.Gone);
            }

            return this.FrapidView(this.GetRazorView<AreaRegistration>("Tasks/Employees/Info.cshtml", this.Tenant), model);
        }
    }
}
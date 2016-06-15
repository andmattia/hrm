using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frapid.DataAccess;
using MixERP.HRM.DTO;

namespace MixERP.HRM.DAL
{
    public static class EmployeeExperiences
    {
        public static async Task<IEnumerable<EmployeeExperienceScrudView>> GetEmployeeExperiencesAsync(string tenant, int employeeId)
        {
            const string sql = "SELECT * FROM hrm.employee_experience_scrud_view WHERE employee_id=@0";
            return await Factory.GetAsync<EmployeeExperienceScrudView>(tenant, sql, employeeId).ConfigureAwait(false);
        }
    }
    public static class EmployeeIdentificationDetails
    {
        public static async Task<IEnumerable<EmployeeIdentificationDetailScrudView>> GetEmployeeIdentificationsAsync(string tenant, int employeeId)
        {
            const string sql = "SELECT * FROM hrm.employee_identification_detail_scrud_view WHERE employee_id=@0";
            return await Factory.GetAsync<EmployeeIdentificationDetailScrudView>(tenant, sql, employeeId).ConfigureAwait(false);
        }
    }
    public static class EmployeeQualifications
    {
        public static async Task<IEnumerable<EmployeeQualificationScrudView>> GetQualificationsAsync(string tenant, int employeeId)
        {
            const string sql = "SELECT * FROM hrm.employee_qualification_scrud_view WHERE employee_id=@0";
            return await Factory.GetAsync<EmployeeQualificationScrudView>(tenant, sql, employeeId).ConfigureAwait(false);
        }
    }
    public static class EmployeeSocialNetworks
    {
        public static async Task<IEnumerable<EmployeeSocialNetworkDetailScrudView>> GetSocialNetworksAsync(string tenant, int employeeId)
        {
            const string sql = "SELECT * FROM hrm.employee_social_network_detail_scrud_view WHERE employee_id=@0";
            return await Factory.GetAsync<EmployeeSocialNetworkDetailScrudView>(tenant, sql, employeeId).ConfigureAwait(false);
        }
    }
    public static class Employees
    {
        public static async Task<EmployeeView> GetEmployeeViewAsync(string tenant, int employeeId)
        {
            const string sql = "SELECT * FROM hrm.employee_view WHERE employee_id=@0";
            return (await Factory.GetAsync<EmployeeView>(tenant, sql, employeeId).ConfigureAwait(false)).FirstOrDefault();
        }
    }
}
using Frapid.Configuration;
using Frapid.i18n;

namespace MixERP.HRM
{
    public static class I18N
    {
        static I18N()
        {
            ResourceDirectory = PathMapper.MapPath("/Areas/MixERP.HRM/i18n");
        }

        private static string ResourceDirectory { get; }

        /// <summary>
        ///     Update Attendance Record
        /// </summary>
        public static string UpdateAttendanceRecord => I18NResource.GetString(ResourceDirectory, "UpdateAttendanceRecord");

        /// <summary>
        ///     For Date
        /// </summary>
        public static string ForDate => I18NResource.GetString(ResourceDirectory, "ForDate");

        /// <summary>
        ///     Employee Id
        /// </summary>
        public static string EmployeeId => I18NResource.GetString(ResourceDirectory, "EmployeeId");

        /// <summary>
        ///     Employee Name
        /// </summary>
        public static string EmployeeName => I18NResource.GetString(ResourceDirectory, "EmployeeName");

        /// <summary>
        ///     Was Present
        /// </summary>
        public static string WasPresent => I18NResource.GetString(ResourceDirectory, "WasPresent");

        /// <summary>
        ///     CheckInTime
        /// </summary>
        public static string CheckInTime => I18NResource.GetString(ResourceDirectory, "CheckInTime");

        /// <summary>
        ///     CheckOutTime
        /// </summary>
        public static string CheckOutTime => I18NResource.GetString(ResourceDirectory, "CheckOutTime");

        /// <summary>
        ///     Overtime Hours
        /// </summary>
        public static string OvertimeHours => I18NResource.GetString(ResourceDirectory, "OvertimeHours");

        /// <summary>
        ///     Absenteeism Reason
        /// </summary>
        public static string AbsenteeismReason => I18NResource.GetString(ResourceDirectory, "AbsenteeismReason");

        /// <summary>
        ///     Update
        /// </summary>
        public static string Update => I18NResource.GetString(ResourceDirectory, "Update");

        /// <summary>
        ///     Update All
        /// </summary>
        public static string UpdateAll => I18NResource.GetString(ResourceDirectory, "UpdateAll");

        /// <summary>
        ///     Show
        /// </summary>
        public static string Show => I18NResource.GetString(ResourceDirectory, "Show");
    }
}
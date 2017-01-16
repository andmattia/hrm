DELETE FROM auth.menu_access_policy
WHERE menu_id IN
(
    SELECT menu_id FROM core.menus
    WHERE app_name = 'HRM'
);

DELETE FROM auth.group_menu_access_policy
WHERE menu_id IN
(
    SELECT menu_id FROM core.menus
    WHERE app_name = 'HRM'
);

DELETE FROM core.menus
WHERE app_name = 'HRM';


EXECUTE core.create_app 'HRM', 'HRM', '1.0', 'MixERP Inc.', 'December 1, 2015', 'user yellow', '/dashboard/hrm/tasks/employees', NULL;

EXECUTE core.create_menu 'HRM', 'Tasks', '', 'tasks icon', '';
EXECUTE core.create_menu 'HRM', 'Attendance', '/dashboard/hrm/tasks/attendance', 'check square', 'Tasks';
EXECUTE core.create_menu 'HRM', 'Employees', '/dashboard/hrm/tasks/employees', 'users', 'Tasks';
EXECUTE core.create_menu 'HRM', 'Contracts', '/dashboard/hrm/tasks/contracts', 'write', 'Tasks';
EXECUTE core.create_menu 'HRM', 'Leave Applications', '/dashboard/hrm/tasks/leave-applications', 'share square', 'Tasks';
EXECUTE core.create_menu 'HRM', 'Resignations', '/dashboard/hrm/tasks/resignations', 'remove user', 'Tasks';
EXECUTE core.create_menu 'HRM', 'Terminations', '/dashboard/hrm/tasks/terminations', 'remove circle', 'Tasks';
EXECUTE core.create_menu 'HRM', 'Exits', '/dashboard/hrm/tasks/exits', 'remove circle outline', 'Tasks';

EXECUTE core.create_menu 'HRM', 'Verification', '', 'check circle', '';
EXECUTE core.create_menu 'HRM', 'Verify Contracts', '/dashboard/hrm/verification/contracts', 'write square', 'Verification';
EXECUTE core.create_menu 'HRM', 'Verify Leave Applications', '/dashboard/hrm/verification/leave-applications', 'checked calendar', 'Verification';
EXECUTE core.create_menu 'HRM', 'Verify Resignations', '/dashboard/hrm/verification/resignations', 'mail forward', 'Verification';
EXECUTE core.create_menu 'HRM', 'Verify Terminations', '/dashboard/hrm/verification/terminations', 'erase', 'Verification';
EXECUTE core.create_menu 'HRM', 'Verify Exits', '/dashboard/hrm/verification/exits', 'send', 'Verification';

EXECUTE core.create_menu 'HRM', 'Setup & Configuration', '', 'configure', '';
EXECUTE core.create_menu 'HRM', 'Employment Statuses', '/dashboard/hrm/setup/employment-statuses', 'info', 'Setup & Configuration';
EXECUTE core.create_menu 'HRM', 'Employee Types', '/dashboard/hrm/setup/employee-types', 'child', 'Setup & Configuration';
EXECUTE core.create_menu 'HRM', 'Identification Types', '/dashboard/hrm/setup/identification-types', 'child', 'Setup & Configuration';
EXECUTE core.create_menu 'HRM', 'Education Levels', '/dashboard/hrm/setup/education-levels', 'student', 'Setup & Configuration';
EXECUTE core.create_menu 'HRM', 'Job Titles', '/dashboard/hrm/setup/job-titles', 'suitcase', 'Setup & Configuration';
EXECUTE core.create_menu 'HRM', 'Pay Grades', '/dashboard/hrm/setup/pay-grades', 'payment', 'Setup & Configuration';
EXECUTE core.create_menu 'HRM', 'Shifts', '/dashboard/hrm/setup/shifts', 'paw', 'Setup & Configuration';
EXECUTE core.create_menu 'HRM', 'Office Hours', '/dashboard/hrm/setup/office-hours', 'alarm outline', 'Setup & Configuration';
EXECUTE core.create_menu 'HRM', 'Leave Types', '/dashboard/hrm/setup/leave-types', 'hotel', 'Setup & Configuration';
EXECUTE core.create_menu 'HRM', 'Leave Benefits', '/dashboard/hrm/setup/leave-benefits', 'car', 'Setup & Configuration';
EXECUTE core.create_menu 'HRM', 'Exit Types', '/dashboard/hrm/setup/exit-types', 'remove', 'Setup & Configuration';
EXECUTE core.create_menu 'HRM', 'Social Networks', '/dashboard/hrm/setup/social-networks', 'users', 'Setup & Configuration';
EXECUTE core.create_menu 'HRM', 'Nationalities', '/dashboard/hrm/setup/nationalities', 'flag', 'Setup & Configuration';
EXECUTE core.create_menu 'HRM', 'Marital Statuses', '/dashboard/hrm/setup/marital-statuses', 'smile', 'Setup & Configuration';

EXECUTE core.create_menu 'HRM', 'Reports', '', 'block layout', '';
EXECUTE core.create_menu 'HRM', 'Attendances', '/dashboard/hrm/reports/attendances', 'bullseye', 'Reports';




DECLARE @office_id integer = core.get_office_id_by_office_name('Default');
EXECUTE auth.create_app_menu_policy
'Admin', 
@office_id, 
'HRM',
'{*}';

GO

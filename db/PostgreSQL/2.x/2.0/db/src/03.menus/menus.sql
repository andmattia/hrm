SELECT * FROM core.create_app('MixERP.HRM', 'HRM', '1.0', 'MixERP Inc.', 'December 1, 2015', 'user yellow', '/dashboard/hrm/tasks/employees', null);

SELECT * FROM core.create_menu('MixERP.HRM', 'Tasks', '', 'tasks icon', '');
SELECT * FROM core.create_menu('MixERP.HRM', 'Attendance', '/dashboard/hrm/tasks/attendance', 'barcode', 'Tasks');
SELECT * FROM core.create_menu('MixERP.HRM', 'Employees', '/dashboard/hrm/tasks/employees', 'users', 'Tasks');
SELECT * FROM core.create_menu('MixERP.HRM', 'Contracts', '/dashboard/hrm/tasks/contracts', 'book', 'Tasks');
SELECT * FROM core.create_menu('MixERP.HRM', 'Leave Applications', '/dashboard/hrm/tasks/leave-applications', 'car', 'Tasks');
SELECT * FROM core.create_menu('MixERP.HRM', 'Resignations', '/dashboard/hrm/tasks/resignations', 'remove user', 'Tasks');
SELECT * FROM core.create_menu('MixERP.HRM', 'Terminations', '/dashboard/hrm/tasks/terminations', 'remove circle', 'Tasks');
SELECT * FROM core.create_menu('MixERP.HRM', 'Exits', '/dashboard/hrm/tasks/exits', 'remove circle outline', 'Tasks');
SELECT * FROM core.create_menu('MixERP.HRM', 'Verification', '', 'check circle', '');
SELECT * FROM core.create_menu('MixERP.HRM', 'Verify Contracts', '/dashboard/hrm/verification/contracts', 'book', 'Verification');
SELECT * FROM core.create_menu('MixERP.HRM', 'Verify Leave Applications', '/dashboard/hrm/verification/leave-applications', 'car', 'Verification');
SELECT * FROM core.create_menu('MixERP.HRM', 'Verify Resignations', '/dashboard/hrm/verification/resignations', 'remove user', 'Verification');
SELECT * FROM core.create_menu('MixERP.HRM', 'Verify Terminations', '/dashboard/hrm/verification/terminations', 'remove circle', 'Verification');
SELECT * FROM core.create_menu('MixERP.HRM', 'Verify Exits', '/dashboard/hrm/verification/exits', 'remove circle outline', 'Verification');
SELECT * FROM core.create_menu('MixERP.HRM', 'Setup & Configuration', '', 'configure', '');
SELECT * FROM core.create_menu('MixERP.HRM', 'Employment Statuses', '/dashboard/hrm/setup/employment-statuses', 'plug', 'Setup & Configuration');
SELECT * FROM core.create_menu('MixERP.HRM', 'Employee Types', '/dashboard/hrm/setup/employee-types', 'sound', 'Setup & Configuration');
SELECT * FROM core.create_menu('MixERP.HRM', 'Education Levels', '/dashboard/hrm/setup/education-levels', 'student', 'Setup & Configuration');
SELECT * FROM core.create_menu('MixERP.HRM', 'Job Titles', '/dashboard/hrm/setup/job-titles', 'play', 'Setup & Configuration');
SELECT * FROM core.create_menu('MixERP.HRM', 'Pay Grades', '/dashboard/hrm/setup/pay-grades', 'money', 'Setup & Configuration');
SELECT * FROM core.create_menu('MixERP.HRM', 'Shifts', '/dashboard/hrm/setup/shifts', 'alarm', 'Setup & Configuration');
SELECT * FROM core.create_menu('MixERP.HRM', 'Office Hours', '/dashboard/hrm/setup/office-hours', 'alarm', 'Setup & Configuration');
SELECT * FROM core.create_menu('MixERP.HRM', 'Leave Types', '/dashboard/hrm/setup/leave-types', 'car', 'Setup & Configuration');
SELECT * FROM core.create_menu('MixERP.HRM', 'Leave Benefits', '/dashboard/hrm/setup/leave-benefits', 'car', 'Setup & Configuration');
SELECT * FROM core.create_menu('MixERP.HRM', 'Exit Types', '/dashboard/hrm/setup/exit-types', 'remove circle', 'Setup & Configuration');
SELECT * FROM core.create_menu('MixERP.HRM', 'Reports', '', 'barcode', '');
SELECT * FROM core.create_menu('MixERP.HRM', 'Attendances', '/dashboard/hrm/reports/attendances', 'barcode', 'Reports');



SELECT * FROM auth.create_app_menu_policy
(
    'Admin', 
    core.get_office_id_by_office_name('Default'), 
    'MixERP.HRM',
    '{*}'::text[]
);

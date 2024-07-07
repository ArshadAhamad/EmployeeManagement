using System;

namespace EmployeeManagement.DTO
{
    public class EmployeeDTO
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? DatetOfBirth { get; set; }
        public string Salary { get; set; }
        public string DepartmentId { get; set; }
        public string Department { get; set; }
        public string Dob { get; set; }

    }
}

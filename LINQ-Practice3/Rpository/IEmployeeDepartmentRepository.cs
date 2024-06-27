using LINQ_Practice3.Dto;

namespace LINQ_Practice3.Rpository
{
    public interface IEmployeeDepartmentRepository
    {
        List<EmployeeDepartmentDto> GetEmployeeDepartment();
    }
}

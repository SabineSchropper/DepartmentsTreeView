using DepartmentData;
using System;
using System.Collections.Generic;

namespace DepartmentLogic
{
   
    public class DepartmentController
    {
        List<Department> existingDepartments = new List<Department>();
        DepartmentRepository departmentRepository = new DepartmentRepository();
        public void HandleNewDepartment(string department)
        {
            departmentRepository.AddNewDepartmentInDatabase(department);
        }
        public List<Department> GetDepartmentsFromDatabase()
        {
            List<Department> deps = departmentRepository.GetDepartmentsFromDatabase();
            existingDepartments = deps;

            return deps;
        }
        public void HandleDepartmentWithParent(Department parent, string dep)
        {
            departmentRepository.AddNewDepartmentWithParentInDatabase(parent, dep);
        }
    }
}

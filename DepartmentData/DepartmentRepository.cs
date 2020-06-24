using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentData
{

    public class DepartmentRepository
    {
        tree_view_departmentEntities depEntities = new tree_view_departmentEntities();
        public void AddNewDepartmentInDatabase(string department)
        {
            Department department1 = new Department();
            department1.name = department;
            depEntities.Department.Add(department1);
            depEntities.SaveChanges();
        }
        public List<Department> GetDepartmentsFromDatabase()
        {
            List<Department> deps = depEntities.Department.Where(x=> x.name != null).ToList();
            return deps;
        }
        public void AddNewDepartmentWithParentInDatabase(Department parent, string dep)
        {
            Department department = new Department();
            department.name = dep;
            department.parent_id = parent.id;
            depEntities.Department.Add(department);
            depEntities.SaveChanges();

        }
    }
}

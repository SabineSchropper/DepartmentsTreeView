using DepartmentData;
using DepartmentLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TreeViewControl
{
    public partial class Form1 : Form
    {
        List<Department> departments;
        DepartmentController controller = new DepartmentController();
        public Form1()
        {
            InitializeComponent();
            List<Department> departments = controller.GetDepartmentsFromDatabase();
            this.departments = departments;
            MakeTreeView();
            SetComboBox();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {

            string depString = tbDep.Text;

            Department parent = (Department)comBoParents.SelectedItem;

            if (parent == null)
            {
                controller.HandleNewDepartment(depString);
            }
            if(parent != null && !string.IsNullOrEmpty(depString))
            {
                controller.HandleDepartmentWithParent(parent, depString);
            }
            UpdateTreeView();

        }
        public void UpdateTreeView()
        {
            List<Department> departments = controller.GetDepartmentsFromDatabase();
            this.departments = departments;
            treeViewDep.Nodes.Clear();
            MakeTreeView();

        }
        public void MakeTreeView()
        {
            List<Department> depsWithNoParent = departments.Where(x => x.parent_id == null).ToList();
            foreach (var item in depsWithNoParent)
            {             
                    TreeNode parentNode = treeViewDep.Nodes.Add(item.name);
                    MakeMoreNodes(parentNode);              
            }                  

        }
        public void MakeMoreNodes(TreeNode parentNode)
        {
            Department parentDep = departments.FirstOrDefault(x => x.name.Equals(parentNode.Text));

            foreach (var item in departments)
            {
                if (item.parent_id == parentDep.id)
                {
                    parentNode = parentNode.Nodes.Add(item.name);
                    MakeMoreNodes(parentNode);
                }
            }
            
        }
                
           

        public void SetComboBox()
        {
            foreach(var item in departments)
            {
                comBoParents.Items.Add(item);
            }         
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAAQ_IMS
{
    public partial class MDIParent : Form
    {
        public MDIParent()
        {
            InitializeComponent();
        }

        private void meterialPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("mpo", new Report.mpo());
        }

        private void gRNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("rptGRN", new MasterEntry.rptGRN());
        }

        private void empSalaryIncrementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                 GlobalInfo.GlobalInfo.isFormOpened("SalaryIncrement", new MasterEntry.SalaryIncrement());
        }

        private void newBrandInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("FrmBrandcs", new MasterEntry.FrmBrandcs());
        }

        private void gRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("GRN", new Purchase.GRN());
        }

        private void firstApprovalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("GRNApproval1", new Purchase.GRNApproval1("1"));
        }

        private void secondApprovalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("GRNApproval1", new Purchase.GRNApproval1("2"));
        }

        private void materialPurchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                 GlobalInfo.GlobalInfo.isFormOpened("Material_Purchase_Order", new Purchase.Material_Purchase_Order());

        }

        private void newItemEntryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
                 GlobalInfo.GlobalInfo.isFormOpened("New_Item_Entry", new MasterEntry.New_Item_Entry());
        }

        private void newItemGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("frmItemGroup", new MasterEntry.frmItemGroup());
        }

        private void newItemExpenseCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("FrmItemExpenseCatagory", new MasterEntry.FrmItemExpenseCatagory());
        }

        private void newColorInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("New_Color_Info", new MasterEntry.New_Color_Info());
        }

        private void newUnitGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("New_Unit_Info", new MasterEntry.New_Unit_Info());
        }

        private void itemCatagoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("frmItemCatagory", new MasterEntry.frmItemCatagory());
        }

        private void newItemSubGroupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("frmSubGroup", new MasterEntry.frmSubGroup());
        }

        private void supplierEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("SupplierEntry", new MasterEntry.SupplierEntry());
        }

        private void loanManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("NewLoanEntry", new MasterEntry.NewLoanEntry());
        }

        private void firstApprovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("POApproval1", new Purchase.POApproval1("1"));
        }

        private void secondApprovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("POApproval1", new Purchase.POApproval1("2"));
        }

        private void employeeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("EmployeeEntry", new MasterEntry.EmployeeEntry());
        }

        private void itemIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("Item_Issue", new Purchase.Item_Issue());
        }

        private void itemStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("ItemStockrpt", new Reports.ItemStockrpt());
        }

        private void allReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("AllReport", new Reports.AllReport());
        }

        

        private void crossTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("frmCrossTab", new Reports.frmCrossTab());
        }

        private void dataDownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("Time_Attendance", new MasterEntry.Time_Attendance());
        }

        private void dataProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("Daily_Attendance", new MasterEntry.Daily_Attendance());
        }

        private void employeeJobCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("Emp_Job_Card", new Purchase.Emp_Job_Card());
        }

        private void dailyAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("EmpJobCardReport", new Reports.EmpJobCardReport());
        }

        private void leaveModiuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("Leave_Module", new MasterEntry.Leave_Module());
        }
        private void salaryProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalInfo.GlobalInfo.isFormOpened("SalaryProcess", new MasterEntry.SalaryProcess());
        }
    }
    
}

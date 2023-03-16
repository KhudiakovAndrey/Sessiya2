using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sessiya2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }        
        private void MainForm_Load(object sender, EventArgs e)
        {
            FillRequestList();
            DivisionComboBox.MouseClick += (s, eMC) => { DivisionComboBox.Text = ""; FIOWorkerkComboBox.Text = ""; };
            IDReqComboBox.SelectionChangeCommitted += (s, eSC) => { };

        }

        void FillRequestList()
        {
            this.typeRequestTableAdapter.Fill(this.dataSet1.TypeRequest);
            this.statusTableAdapter.Fill(this.dataSet1.Status);
            this.visitorsTableAdapter.Fill(this.dataSet1.Visitors);
            this.workersTableAdapter.Fill(this.dataSet1.Workers);
            this.divisionTableAdapter.Fill(this.dataSet1.Division);
            this.groupVisitorsTableAdapter.Fill(this.dataSet1.GroupVisitors);
            this.requestTableAdapter.Fill(this.dataSet1.Request);
            this.usersTableAdapter.Fill(this.dataSet1.Users);
            this.departmentTableAdapter.Fill(this.dataSet1.Department);
            this.purposeVisitTableAdapter.Fill(this.dataSet1.PurposeVisit);

            RequestListView.Items.Clear();
            string[] items = new string[12];
            DataRow TempRow;
            foreach (DataRow RowCB in dataSet1.Request.Rows) { IDReqComboBox.Items.Add(RowCB["ID"].ToString()); }
            foreach (DataRow RowCB in dataSet1.Division.Rows) { DivisionComboBox.Items.Add(RowCB["Title"].ToString()); }
            foreach (DataRow RowCB in dataSet1.Workers.Rows) { FIOWorkerkComboBox.Items.Add(RowCB["FIO"].ToString()); }
            foreach (DataRow Row in dataSet1.Visitors.Rows)
            {
                fioClass.space_FIO(Row["FIO"].ToString());
                fioClass.space_Pass(Row["DataPass"].ToString());
                items[1] = fioClass.Surname;
                items[2] = fioClass.Name;
                items[3] = fioClass.LastName;
                items[4] = Row["Phone"].ToString();
                TempRow = Row.GetParentRow("FK_Visitors_Users1");
                items[5] = TempRow["Email"].ToString();
                items[6] = Row["Organization"].ToString();
                items[7] = Row["Note"].ToString();
                items[8] = Row["Birthday"].ToString();
                items[9] = fioClass.series;
                items[10] = fioClass.number;
                ListViewItem it = new ListViewItem();
                it.Text = Row["ID"].ToString();
                it.SubItems.AddRange(items);
                RequestListView.Items.Add(it);
            }

        }

        private void DivisionComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FIOWorkerkComboBox.Items.Clear();
            FIOWorkerkComboBox.Enabled = true;
            ulong ID_Division;
            DataRow Rows = dataSet1.Division.Select("Title = '" + DivisionComboBox.SelectedItem + "'")[0];
            ID_Division = Convert.ToUInt16(Rows["ID"]);
            foreach (DataRow RowsD in dataSet1.Workers.Select("ID_Division= '" + ID_Division + "'"))
            {
                FIOWorkerkComboBox.Items.Add(RowsD["FIO"]);
            }

        }

        private void RequestListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //ulong ID_Visitor, ID_Division, ID_InfoPermit;
            //DataRow[] UserRow = dataSet1.Visitors.Select("ID = '" + e.Item.SubItems[0].Text + "'");
            //ID_Visitor = Convert.ToUInt16(UserRow[0]["ID_User"]);
            //DataRow[] ReqRow = dataSet1.Request.Select("IDUser = '" + ID_Visitor + "'");
            //ID_Division = Convert.ToUInt16(ReqRow[0]["IDDivision"]);
            //ID_InfoPermit = Convert.ToUInt16(ReqRow[0]["ID_InfoPermit"]);
        }

        void Msg(string line)
        {
            MessageBox.Show(line, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }

}


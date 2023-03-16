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
            DivisionFilterComboBox.Click += (s, eDFC) => { DivisionFilterComboBox.Text = ""; };
            TypeFilterComboBox.Click += (s, eTFC) => { TypeFilterComboBox.Text = ""; };
            StatusFilterComboBox.Click += (s, eSFC) => { StatusFilterComboBox.Text = ""; };

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
            string[] items = new string[6];
            DataRow TempRow;
            //foreach(Data)
            foreach (DataRow RowCB in dataSet1.Division.Rows) { DivisionComboBox.Items.Add(RowCB["Title"].ToString()); }
            foreach (DataRow RowCB in dataSet1.Workers.Rows) { FIOWorkerkComboBox.Items.Add(RowCB["FIO"].ToString()); }
            foreach (DataRow Row in dataSet1.Request.Rows)
            {
                TempRow = Row.GetParentRow("FK_Request_TypeRequest");
                items[1] = TempRow["Title"].ToString();
                items[2] = Row["Date"].ToString();
                items[3] = Row["Time"].ToString();
                TempRow = Row.GetParentRow("FK_Request_Users");
                items[4] = TempRow["Login"].ToString();
                TempRow = Row.GetParentRow("FK_Request_Status");
                items[5] = TempRow["Title"].ToString();
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

        void Msg(string line)
        {
            MessageBox.Show(line, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RequestListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            DataRow ReqRow = dataSet1.Request.Select("ID = '" + e.Item.SubItems[0].Text + "'")[0];
            ulong ID_Visitor = Convert.ToUInt16(ReqRow["ID_Visitor"]);
            DataRow VisitorRow = dataSet1.Visitors.Select("ID = '" + ID_Visitor + "'")[0];
            fioClass.space_FIO(VisitorRow["FIO"].ToString());
            SurnameTextBox.Text = fioClass.Surname;
            NameTextBox.Text = fioClass.Name;
            LastNameTextBox.Text = fioClass.LastName;
            PhoneTextBox.Text = VisitorRow["Phone"].ToString();
            DataRow UserRow = dataSet1.Users.Select("ID = '" + VisitorRow["ID_User"].ToString() + "'")[0];
            EmailTextBox.Text = UserRow["Email"].ToString();
            OrgTextBox.Text = VisitorRow["Organization"].ToString();
            NoteTextBox.Text = VisitorRow["Note"].ToString();
            BirthdayDateTimePicker.Value = Convert.ToDateTime(VisitorRow["Birthday"].ToString());
            fioClass.space_Pass(VisitorRow["DataPass"].ToString());
            SeriesTextBox.Text = fioClass.series;
            NumberTextBox.Text = fioClass.number;
        }
    }

}


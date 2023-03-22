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
        ListViewItem LastSelectedItem;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.BlackList". При необходимости она может быть перемещена или удалена.
            this.blackListTableAdapter.Fill(this.dataSet1.BlackList);
            FillRequestList();
            DivisionComboBox.MouseClick += (s, eMC) => { DivisionComboBox.Text = ""; FIOWorkerkComboBox.Text = ""; };
            DivisionFilterComboBox.Click += (s, eDFC) => { DivisionFilterComboBox.Text = ""; };
            TypeFilterComboBox.Click += (s, eTFC) => { TypeFilterComboBox.Text = ""; };
            StatusFilterComboBox.Click += (s, eSFC) => { StatusFilterComboBox.Text = ""; };

        }

        void FillRequestList()
        {
            this.infoPermitTableAdapter.Fill(this.dataSet1.InfoPermit);
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
            DataRow TempRow = null;
            foreach (DataRow RowCB in dataSet1.Division.Rows) { DivisionFilterComboBox.Items.Add(RowCB["Title"].ToString()); }
            foreach (DataRow RowCB in dataSet1.TypeRequest.Rows) { TypeFilterComboBox.Items.Add(RowCB["Title"].ToString()); }
            foreach (DataRow RowCB in dataSet1.Status.Rows) { StatusFilterComboBox.Items.Add(RowCB["Title"].ToString()); }

            foreach (DataRow Row in dataSet1.Request.Rows)
            {
                FillListView(TempRow, Row, items);        
            }

        }
        void FillListView(DataRow TempRow, DataRow Row, string[] items) //Метод для заполнения ListView
        {
                TempRow = Row.GetParentRow("FK_Request_TypeRequest");
                items[1] = TempRow["Title"].ToString();
                items[2] = Convert.ToDateTime(Row["DateTime"]).ToString("dd.MM.yyyy HH.mm.ss");
                TempRow = Row.GetParentRow("FK_Request_Users");
                items[3] = TempRow["Login"].ToString();
                TempRow = Row.GetParentRow("FK_Request_Status");
                items[4] = TempRow["Title"].ToString();
                items[5] = Row["Reason"].ToString();
                ListViewItem it = new ListViewItem();
                it.Text = Row["ID"].ToString();
                it.SubItems.AddRange(items);
                RequestListView.Items.Add(it);
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

        void Msg(string line) // Метод для быстрого вывода MessageBox
        {
            MessageBox.Show(line, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RequestListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            LastSelectedItem = e.Item;
            DataRow ReqRow = dataSet1.Request.Select("ID = '" + e.Item.SubItems[0].Text + "'")[0];
            DataRow TempRow;
            ulong ID_Visitor = Convert.ToUInt16(ReqRow["ID_Visitor"]);
            ulong ID_InfoPermit = Convert.ToUInt16(ReqRow["ID_InfoPermit"]);

            //Заполнение блока полей Информация о посетителе
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
            //Заполнение блока полей Информация для пропуска
            DataRow InfoPermitRow = dataSet1.InfoPermit.Select($"ID = '{ID_InfoPermit}'")[0];
            DateStartTextBox.Text = Convert.ToDateTime(InfoPermitRow["StartReq"]).ToString("dd.MM.yyyy");
            DataFinishTextBox.Text = Convert.ToDateTime(InfoPermitRow["EndReq"]).ToString("dd.MM.yyyy");
            TempRow = InfoPermitRow.GetParentRow("FK_InfoPermit_PurposeVisit");
            PurposeVisitTextBox.Text = TempRow["Title"].ToString();
            //Заполнение блока полей Принимающая сторона
            ulong ID_Division = Convert.ToUInt16(ReqRow["IDDivision"].ToString());
            DataRow DivisionRow = dataSet1.Division.Select("ID = '" + ID_Division + "'")[0];
            DataRow WorkerRow = dataSet1.Workers.Select("ID = '" + ID_Division + "'")[0];
            DivisionComboBox.Text = DivisionRow["Title"].ToString();
            TempRow = DivisionRow.GetParentRow("FK_Workers_Division");
            FIOWorkerkComboBox.Text = WorkerRow["FIO"].ToString();
        }

        private void DivisionFilterComboBox_SelectionChangeCommitted(object sender, EventArgs e) //Фильтр по Подразделениям
        {
            RequestListView.Items.Clear();
            string[] items = new string[6];
            DataRow TempRow = null;
            DataRow RowFilterDivision = dataSet1.Division.Select("Title ='" + DivisionFilterComboBox.SelectedItem + "'")[0];
            ulong RowID_Division;
            RowID_Division = Convert.ToUInt16(RowFilterDivision["ID"]);
            foreach (DataRow RowDivision in dataSet1.Request.Select("IDDivision= '" + RowID_Division + "'"))
            {
                FillListView(TempRow, RowDivision, items);
            }
            if (RequestListView.Items.Count >= 1) RequestListView.Items[0].Selected = true;
        }

        private void TypeFilterComboBox_SelectionChangeCommitted(object sender, EventArgs e) //Фильтр по Типу
        {
            RequestListView.Items.Clear();
            string[] items = new string[6];
            DataRow TempRow = null;
            DataRow RowFilterType = dataSet1.TypeRequest.Select("Title ='" + TypeFilterComboBox.SelectedItem + "'")[0];
            ulong RowID_Type;
            RowID_Type = Convert.ToUInt16(RowFilterType["ID"]);
            foreach (DataRow RowsType in dataSet1.Request.Select("IDType= '" + RowID_Type + "'"))
            {
                FillListView(TempRow, RowsType, items);
            }
            if (RequestListView.Items.Count >= 1) RequestListView.Items[0].Selected = true;
        }

        private void StatusFilterComboBox_SelectionChangeCommitted(object sender, EventArgs e) //Фильтр по Статусу
        {             
            RequestListView.Items.Clear();
            string[] items = new string[6];
            DataRow TempRow = null;
            DataRow RowFilterStatus = dataSet1.Status.Select("Title ='" + StatusFilterComboBox.SelectedItem + "'")[0];
            ulong RowID_Status;
            RowID_Status = Convert.ToUInt16(RowFilterStatus["ID"]);
            foreach (DataRow RowStatus in dataSet1.Request.Select("ID_Status= '" + RowID_Status + "'"))
            {
                FillListView(TempRow, RowStatus, items);
            }
            if (RequestListView.Items.Count >= 1) RequestListView.Items[0].Selected = true;
        }

        private void CheckVisitorButton_Click(object sender, EventArgs e)
        {
            if (RequestListView.SelectedItems.Count > 0)
            {
                DataRow ReqRow = dataSet1.Request.Select("ID = '" + LastSelectedItem.SubItems[0].Text + "'")[0];
                ulong ID_User = Convert.ToUInt64(ReqRow["IDUser"]);
                DataRow[] BlackListRow = dataSet1.BlackList.Select("ID_User = '" + ID_User + "'");
                ChechReqDialog Dialog = new ChechReqDialog(ReqRow, dataSet1, requestTableAdapter);
                if (BlackListRow.Length == 0)
                {
                    Dialog.ShowDialog();                
                    if (Dialog.DialogResult == DialogResult.OK) FillRequestList();

                }
                else
                {
                    Dialog.BlackList = true;
                    Msg("Посетитель находится в чёрном списке. Его статус заявки будет автоматически отклонён, и вы не сможете его изменить");
                    Dialog.ShowDialog();
                    if (Dialog.DialogResult == DialogResult.OK) FillRequestList();
                }
            }
            else Msg("Не была выбрана ни одна заявка. Пожалуйства, выберите заявку");
        }

    }
}


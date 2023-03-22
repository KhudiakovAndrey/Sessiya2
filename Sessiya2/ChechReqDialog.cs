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
    public partial class ChechReqDialog : Form
    {
        public Boolean BlackList;
        DataRow reqRow;
        int IDType, IDDivision, IDUser, ID_InfoPermit, ID_Status, ID_Visitor;
        int? ID_GroupVisitor; 
        DateTime DateTime;
        DataSet1 dataSetNew;
        DataSet1TableAdapters.RequestTableAdapter reqTA;
        public ChechReqDialog(DataRow oldReqRow, DataSet1 dataSet, DataSet1TableAdapters.RequestTableAdapter reqOldTA)
        {
            InitializeComponent();
            reqRow = oldReqRow;
            dataSetNew = dataSet;
            reqTA = reqOldTA;
        }
        void Msg(string line) // Метод для быстрого вывода MessageBox
        {
            MessageBox.Show(line, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Reason = $"Заявка на посещение объекта КИИ одобрена,  дата посещения: {DateStartTextBox.Text}";
            if (ReasonComboBox.Visible && ReasonComboBox.Text == "") { Msg("Пожалуйства, выберите причину отклонения заявки"); return; }
            IDType = Convert.ToInt32(reqRow["IDType"]);
            IDDivision = Convert.ToInt32(reqRow["IDDivision"]);
            DateTime = Convert.ToDateTime(reqRow["DateTime"]);
            IDUser = Convert.ToInt32(reqRow["IDUser"]);
            ID_InfoPermit = Convert.ToInt32(reqRow["ID_InfoPermit"]);
            DataRow StatusRow = dataSetNew.Status.Select("Title = '" + StatusComboBox.Text + "'")[0];
            ID_Status = Convert.ToInt32(StatusRow["ID"]);
            ID_GroupVisitor = null;
            ID_Visitor = Convert.ToInt32(reqRow["ID_Visitor"]);
            DataRow NewReqRow = reqRow;
            NewReqRow.SetField<int>("IDType", IDType);
            NewReqRow.SetField<int>("IDDivision", IDDivision);
            NewReqRow.SetField<DateTime>("DateTime", Convert.ToDateTime(DateTime));
            NewReqRow.SetField<int>("IDUser", IDUser);
            NewReqRow.SetField<int>("ID_InfoPermit", ID_InfoPermit);
            NewReqRow.SetField<int>("ID_Status", ID_Status);
            NewReqRow.SetField<int?>("ID_GroupVisitor", ID_GroupVisitor);
            NewReqRow.SetField<int>("ID_Visitor", ID_Visitor);
            NewReqRow.SetField<string>("Reason", ReasonComboBox.Text);

            try
            {
                int updateRows = requestTableAdapter.Update(NewReqRow);
                Msg(updateRows == 0 ? "Не удалось обновить запись" : "Успех");
            }
            catch(Exception)
            {
                Msg("База данных сообщила об ошибке!");
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ChechReqDialog_Load(object sender, EventArgs e)
        {

            DataRow TempRow;
            
            IDType = Convert.ToInt32(reqRow["IDType"]);
            IDDivision = Convert.ToInt32(reqRow["IDDivision"]);
            IDUser = Convert.ToInt32(reqRow["IDUser"]);
            ID_InfoPermit = Convert.ToInt32(reqRow["ID_InfoPermit"]);
            ID_Visitor = Convert.ToInt32(reqRow["ID_Visitor"]);

            //Заполнение блока полей Информация о посетителе
            DataRow VisitorRow = dataSetNew.Visitors.Select("ID = '" + ID_Visitor + "'")[0];
            fioClass.space_FIO(VisitorRow["FIO"].ToString());
            SurnameTextBox.Text = fioClass.Surname;
            NameTextBox.Text = fioClass.Name;
            LastNameTextBox.Text = fioClass.LastName;
            PhoneTextBox.Text = VisitorRow["Phone"].ToString();
            DataRow UserRow = dataSetNew.Users.Select("ID = '" + VisitorRow["ID_User"].ToString() + "'")[0];
            EmailTextBox.Text = UserRow["Email"].ToString();
            OrgTextBox.Text = VisitorRow["Organization"].ToString();
            NoteTextBox.Text = VisitorRow["Note"].ToString();
            BirthdayDateTimePicker.Value = Convert.ToDateTime(VisitorRow["Birthday"].ToString());
            fioClass.space_Pass(VisitorRow["DataPass"].ToString());
            SeriesTextBox.Text = fioClass.series;
            NumberTextBox.Text = fioClass.number;
            TempRow = reqRow.GetParentRow("FK_Request_Status");
            StatusComboBox.Text = TempRow["Title"].ToString();
            foreach(DataRow Row in dataSetNew.Status.Rows) { StatusComboBox.Items.Add(Row["Title"]); }

            DataRow DivRow = dataSetNew.Division.Select("ID = '" + IDDivision + "'")[0];
            DivisionTextBox.Text = DivRow["Title"].ToString();
            DataRow WorkerRow = dataSetNew.Workers.Select("ID = '" + IDDivision + "'")[0];
            TempRow = DivRow.GetParentRow("FK_Workers_Division");
            WorkerTextBox.Text = WorkerRow["FIO"].ToString();

            DataRow InfoRow = dataSetNew.InfoPermit.Select("ID = '" + ID_InfoPermit + "'")[0];
            DateStartTextBox.Text = Convert.ToDateTime(InfoRow["StartReq"]).ToString("dd.mm.yyyy");
            DateFinishTextBox.Text = Convert.ToDateTime(InfoRow["EndReq"]).ToString("dd.mm.yyyy");
            TempRow = InfoRow.GetParentRow("FK_InfoPermit_PurposeVisit");
            PurposVisitTextBox.Text = TempRow["Title"].ToString();
            StatusComboBox.SelectionChangeCommitted += (s, a) => { ReasonPanel.Visible = StatusComboBox.SelectedItem.ToString() == "Не одобрена" ? true : false; };
                string[] Reason = { "Посетитель находится в чёрном списке", "Посетитель ввёл некоректные данные", "Низкое качество прикреплённых файлов или их отсуствие"};
            ReasonComboBox.Items.AddRange(Reason);

            if (BlackList)
            {
                StatusComboBox.Text = "Не одобрена"; StatusComboBox.Enabled = false; DateStartTextBox.Enabled = false; DateFinishTextBox.Enabled = false;
                ReasonPanel.Visible = true; ReasonComboBox.Text = Reason[0];
            }


        }

    }

}

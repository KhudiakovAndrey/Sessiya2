
namespace Sessiya2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FIOWorkerkComboBox = new System.Windows.Forms.ComboBox();
            this.DivisionComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RequestListView = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataSet1 = new Sessiya2.DataSet1();
            this.departmentTableAdapter = new Sessiya2.DataSet1TableAdapters.DepartmentTableAdapter();
            this.tableAdapterManager = new Sessiya2.DataSet1TableAdapters.TableAdapterManager();
            this.divisionTableAdapter = new Sessiya2.DataSet1TableAdapters.DivisionTableAdapter();
            this.groupVisitorsTableAdapter = new Sessiya2.DataSet1TableAdapters.GroupVisitorsTableAdapter();
            this.purposeVisitTableAdapter = new Sessiya2.DataSet1TableAdapters.PurposeVisitTableAdapter();
            this.requestTableAdapter = new Sessiya2.DataSet1TableAdapters.RequestTableAdapter();
            this.statusTableAdapter = new Sessiya2.DataSet1TableAdapters.StatusTableAdapter();
            this.typeRequestTableAdapter = new Sessiya2.DataSet1TableAdapters.TypeRequestTableAdapter();
            this.usersTableAdapter = new Sessiya2.DataSet1TableAdapters.UsersTableAdapter();
            this.visitorsTableAdapter = new Sessiya2.DataSet1TableAdapters.VisitorsTableAdapter();
            this.workersTableAdapter = new Sessiya2.DataSet1TableAdapters.WorkersTableAdapter();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.idReqLabel = new System.Windows.Forms.Label();
            this.IDReqComboBox = new System.Windows.Forms.ComboBox();
            this.typeReqLabel = new System.Windows.Forms.Label();
            this.dateTimeReqLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.statusReqLabel = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // FIOWorkerkComboBox
            // 
            this.FIOWorkerkComboBox.Enabled = false;
            this.FIOWorkerkComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.FIOWorkerkComboBox.FormattingEnabled = true;
            this.FIOWorkerkComboBox.Location = new System.Drawing.Point(12, 68);
            this.FIOWorkerkComboBox.Name = "FIOWorkerkComboBox";
            this.FIOWorkerkComboBox.Size = new System.Drawing.Size(330, 24);
            this.FIOWorkerkComboBox.TabIndex = 7;
            // 
            // DivisionComboBox
            // 
            this.DivisionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DivisionComboBox.FormattingEnabled = true;
            this.DivisionComboBox.Location = new System.Drawing.Point(12, 29);
            this.DivisionComboBox.Name = "DivisionComboBox";
            this.DivisionComboBox.Size = new System.Drawing.Size(330, 24);
            this.DivisionComboBox.TabIndex = 6;
            this.DivisionComboBox.Text = "Выберите нужное подразделение";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(9, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "ФИО:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Подразделение:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.FIOWorkerkComboBox);
            this.panel3.Controls.Add(this.DivisionComboBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel3.Location = new System.Drawing.Point(6, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 111);
            this.panel3.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Enabled = false;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(715, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 136);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Принимающая сторона";
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox3.Location = new System.Drawing.Point(6, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(253, 22);
            this.textBox3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(70, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Цель посещения:";
            // 
            // RequestListView
            // 
            this.RequestListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.RequestListView.FullRowSelect = true;
            this.RequestListView.GridLines = true;
            this.RequestListView.HideSelection = false;
            this.RequestListView.Location = new System.Drawing.Point(3, 3);
            this.RequestListView.Name = "RequestListView";
            this.RequestListView.Size = new System.Drawing.Size(883, 312);
            this.RequestListView.TabIndex = 0;
            this.RequestListView.UseCompatibleStateImageBehavior = false;
            this.RequestListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "ID";
            this.columnHeader11.Width = 26;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Фамилия";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 72;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Отчество";
            this.columnHeader3.Width = 94;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Телефон";
            this.columnHeader4.Width = 76;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "E-mail";
            this.columnHeader5.Width = 101;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Организация";
            this.columnHeader6.Width = 108;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Примечание";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Дата рождения";
            this.columnHeader8.Width = 101;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Серия";
            this.columnHeader9.Width = 71;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Номер";
            this.columnHeader10.Width = 62;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel2.Location = new System.Drawing.Point(3, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 111);
            this.panel2.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox2.Location = new System.Drawing.Point(163, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(133, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "по";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(27, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "c";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(10, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 350);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о посетителе";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.RequestListView);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 323);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(901, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(423, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 136);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация для пропуска";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentTableAdapter = this.departmentTableAdapter;
            this.tableAdapterManager.DivisionTableAdapter = this.divisionTableAdapter;
            this.tableAdapterManager.GroupVisitorsTableAdapter = this.groupVisitorsTableAdapter;
            this.tableAdapterManager.InfoPermitTableAdapter = null;
            this.tableAdapterManager.PurposeVisitTableAdapter = this.purposeVisitTableAdapter;
            this.tableAdapterManager.RequestTableAdapter = this.requestTableAdapter;
            this.tableAdapterManager.StatusTableAdapter = this.statusTableAdapter;
            this.tableAdapterManager.TypeRequestTableAdapter = this.typeRequestTableAdapter;
            this.tableAdapterManager.UpdateOrder = Sessiya2.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            this.tableAdapterManager.VisitorsTableAdapter = this.visitorsTableAdapter;
            this.tableAdapterManager.WorkersTableAdapter = this.workersTableAdapter;
            // 
            // divisionTableAdapter
            // 
            this.divisionTableAdapter.ClearBeforeFill = true;
            // 
            // groupVisitorsTableAdapter
            // 
            this.groupVisitorsTableAdapter.ClearBeforeFill = true;
            // 
            // purposeVisitTableAdapter
            // 
            this.purposeVisitTableAdapter.ClearBeforeFill = true;
            // 
            // requestTableAdapter
            // 
            this.requestTableAdapter.ClearBeforeFill = true;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // typeRequestTableAdapter
            // 
            this.typeRequestTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // visitorsTableAdapter
            // 
            this.visitorsTableAdapter.ClearBeforeFill = true;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(10, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(407, 136);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Заявка";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.statusReqLabel);
            this.panel4.Controls.Add(this.UserLabel);
            this.panel4.Controls.Add(this.dateTimeReqLabel);
            this.panel4.Controls.Add(this.typeReqLabel);
            this.panel4.Controls.Add(this.IDReqComboBox);
            this.panel4.Controls.Add(this.idReqLabel);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.panel4.Location = new System.Drawing.Point(6, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(395, 111);
            this.panel4.TabIndex = 0;
            // 
            // idReqLabel
            // 
            this.idReqLabel.AutoSize = true;
            this.idReqLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idReqLabel.Location = new System.Drawing.Point(3, 0);
            this.idReqLabel.Name = "idReqLabel";
            this.idReqLabel.Size = new System.Drawing.Size(104, 17);
            this.idReqLabel.TabIndex = 0;
            this.idReqLabel.Text = "Номер заявки:";
            // 
            // IDReqComboBox
            // 
            this.IDReqComboBox.FormattingEnabled = true;
            this.IDReqComboBox.Location = new System.Drawing.Point(6, 21);
            this.IDReqComboBox.Name = "IDReqComboBox";
            this.IDReqComboBox.Size = new System.Drawing.Size(101, 24);
            this.IDReqComboBox.TabIndex = 1;
            // 
            // typeReqLabel
            // 
            this.typeReqLabel.AutoSize = true;
            this.typeReqLabel.Location = new System.Drawing.Point(6, 49);
            this.typeReqLabel.Name = "typeReqLabel";
            this.typeReqLabel.Size = new System.Drawing.Size(86, 17);
            this.typeReqLabel.TabIndex = 2;
            this.typeReqLabel.Text = "Тип заявки:";
            // 
            // dateTimeReqLabel
            // 
            this.dateTimeReqLabel.AutoSize = true;
            this.dateTimeReqLabel.Location = new System.Drawing.Point(6, 71);
            this.dateTimeReqLabel.Name = "dateTimeReqLabel";
            this.dateTimeReqLabel.Size = new System.Drawing.Size(102, 17);
            this.dateTimeReqLabel.TabIndex = 3;
            this.dateTimeReqLabel.Text = "Дата и время:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(175, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(100, 17);
            this.UserLabel.TabIndex = 4;
            this.UserLabel.Text = "Кто составил:";
            // 
            // statusReqLabel
            // 
            this.statusReqLabel.AutoSize = true;
            this.statusReqLabel.Location = new System.Drawing.Point(175, 28);
            this.statusReqLabel.Name = "statusReqLabel";
            this.statusReqLabel.Size = new System.Drawing.Size(117, 17);
            this.statusReqLabel.TabIndex = 5;
            this.statusReqLabel.Text = "Текущий статус:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 514);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox FIOWorkerkComboBox;
        private System.Windows.Forms.ComboBox DivisionComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView RequestListView;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DataSet1TableAdapters.DivisionTableAdapter divisionTableAdapter;
        private DataSet1TableAdapters.GroupVisitorsTableAdapter groupVisitorsTableAdapter;
        private DataSet1TableAdapters.PurposeVisitTableAdapter purposeVisitTableAdapter;
        private DataSet1TableAdapters.RequestTableAdapter requestTableAdapter;
        private DataSet1TableAdapters.StatusTableAdapter statusTableAdapter;
        private DataSet1TableAdapters.TypeRequestTableAdapter typeRequestTableAdapter;
        private DataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private DataSet1TableAdapters.VisitorsTableAdapter visitorsTableAdapter;
        private DataSet1TableAdapters.WorkersTableAdapter workersTableAdapter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label statusReqLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label dateTimeReqLabel;
        private System.Windows.Forms.Label typeReqLabel;
        private System.Windows.Forms.ComboBox IDReqComboBox;
        private System.Windows.Forms.Label idReqLabel;
    }
}
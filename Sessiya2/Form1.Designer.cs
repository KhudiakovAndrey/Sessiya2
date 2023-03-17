
namespace Sessiya2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitButton = new System.Windows.Forms.Button();
            this.textBoxCodeWorker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginbuttonWorker = new System.Windows.Forms.Button();
            this.dataSet1 = new Sessiya2.DataSet1();
            this.workersTableAdapter = new Sessiya2.DataSet1TableAdapters.WorkersTableAdapter();
            this.tableAdapterManager = new Sessiya2.DataSet1TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.ForeColor = System.Drawing.Color.Red;
            this.ExitButton.Location = new System.Drawing.Point(223, 146);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(77, 31);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Отмена";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // textBoxCodeWorker
            // 
            this.textBoxCodeWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.textBoxCodeWorker.Location = new System.Drawing.Point(87, 108);
            this.textBoxCodeWorker.Name = "textBoxCodeWorker";
            this.textBoxCodeWorker.Size = new System.Drawing.Size(213, 32);
            this.textBoxCodeWorker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(575, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите код сотрудника, чтобы войти под его аккаунтом.";
            // 
            // loginbuttonWorker
            // 
            this.loginbuttonWorker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbuttonWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.loginbuttonWorker.ForeColor = System.Drawing.Color.DarkGreen;
            this.loginbuttonWorker.Location = new System.Drawing.Point(87, 146);
            this.loginbuttonWorker.Name = "loginbuttonWorker";
            this.loginbuttonWorker.Size = new System.Drawing.Size(129, 31);
            this.loginbuttonWorker.TabIndex = 2;
            this.loginbuttonWorker.Text = "Авторизоваться";
            this.loginbuttonWorker.UseVisualStyleBackColor = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BlackListTableAdapter = null;
            this.tableAdapterManager.DepartmentTableAdapter = null;
            this.tableAdapterManager.DivisionTableAdapter = null;
            this.tableAdapterManager.GroupVisitorsTableAdapter = null;
            this.tableAdapterManager.InfoPermitTableAdapter = null;
            this.tableAdapterManager.PurposeVisitTableAdapter = null;
            this.tableAdapterManager.RequestTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.TypeRequestTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Sessiya2.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.VisitorsTableAdapter = null;
            this.tableAdapterManager.WorkersTableAdapter = this.workersTableAdapter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 192);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.textBoxCodeWorker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginbuttonWorker);
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox textBoxCodeWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginbuttonWorker;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.WorkersTableAdapter workersTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
    }
}


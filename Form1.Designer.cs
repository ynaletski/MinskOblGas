
namespace Database_reader_for_MinskOblGas
{
    partial class DatabaseReader
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
            this.GridForViewData = new System.Windows.Forms.DataGridView();
            this.labelExistExcel = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.SplitContainer();
            this.buttonTable = new System.Windows.Forms.Button();
            this.checkBoxPeriod = new System.Windows.Forms.CheckBox();
            this.checkBoxData = new System.Windows.Forms.CheckBox();
            this.checkBoxObject = new System.Windows.Forms.CheckBox();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.panelPeriod = new System.Windows.Forms.Panel();
            this.dateTimePeriodTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePeriodFrom = new System.Windows.Forms.DateTimePicker();
            this.labelObject = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.panelObject = new System.Windows.Forms.Panel();
            this.comboBoxObject = new System.Windows.Forms.ComboBox();
            this.labelSetting = new System.Windows.Forms.Label();
            this.buttonSertificate = new System.Windows.Forms.Button();
            this.buttonProtocol = new System.Windows.Forms.Button();
            this.labelSensorNumber = new System.Windows.Forms.Label();
            this.labelexcel = new System.Windows.Forms.Label();
            this.panelSensorNumber = new System.Windows.Forms.Panel();
            this.comboBoxSensorNumber = new System.Windows.Forms.ComboBox();
            this.labelError = new System.Windows.Forms.Label();
            this.labelErrorDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridForViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            this.settings.Panel1.SuspendLayout();
            this.settings.Panel2.SuspendLayout();
            this.settings.SuspendLayout();
            this.panelPeriod.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelObject.SuspendLayout();
            this.panelSensorNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridForViewData
            // 
            this.GridForViewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridForViewData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridForViewData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridForViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridForViewData.Location = new System.Drawing.Point(309, 55);
            this.GridForViewData.MultiSelect = false;
            this.GridForViewData.Name = "GridForViewData";
            this.GridForViewData.ReadOnly = true;
            this.GridForViewData.RowHeadersWidth = 30;
            this.GridForViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridForViewData.Size = new System.Drawing.Size(847, 682);
            this.GridForViewData.TabIndex = 0;
            this.GridForViewData.VirtualMode = true;
            this.GridForViewData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridForViewData_CellClick);
            // 
            // labelExistExcel
            // 
            this.labelExistExcel.AutoSize = true;
            this.labelExistExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExistExcel.Location = new System.Drawing.Point(44, 19);
            this.labelExistExcel.Name = "labelExistExcel";
            this.labelExistExcel.Size = new System.Drawing.Size(204, 20);
            this.labelExistExcel.TabIndex = 2;
            this.labelExistExcel.Text = "Доступ к Microsoft Excel16";
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(26, 55);
            this.settings.Name = "settings";
            this.settings.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // settings.Panel1
            // 
            this.settings.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.settings.Panel1.Controls.Add(this.buttonTable);
            this.settings.Panel1.Controls.Add(this.checkBoxPeriod);
            this.settings.Panel1.Controls.Add(this.checkBoxData);
            this.settings.Panel1.Controls.Add(this.checkBoxObject);
            this.settings.Panel1.Controls.Add(this.labelPeriod);
            this.settings.Panel1.Controls.Add(this.labelData);
            this.settings.Panel1.Controls.Add(this.panelPeriod);
            this.settings.Panel1.Controls.Add(this.labelObject);
            this.settings.Panel1.Controls.Add(this.panel1);
            this.settings.Panel1.Controls.Add(this.panelObject);
            this.settings.Panel1.Controls.Add(this.labelSetting);
            this.settings.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // settings.Panel2
            // 
            this.settings.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.settings.Panel2.Controls.Add(this.buttonSertificate);
            this.settings.Panel2.Controls.Add(this.buttonProtocol);
            this.settings.Panel2.Controls.Add(this.labelSensorNumber);
            this.settings.Panel2.Controls.Add(this.labelexcel);
            this.settings.Panel2.Controls.Add(this.panelSensorNumber);
            this.settings.Size = new System.Drawing.Size(256, 682);
            this.settings.SplitterDistance = 447;
            this.settings.SplitterWidth = 10;
            this.settings.TabIndex = 3;
            // 
            // buttonTable
            // 
            this.buttonTable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTable.Location = new System.Drawing.Point(22, 384);
            this.buttonTable.Name = "buttonTable";
            this.buttonTable.Size = new System.Drawing.Size(210, 43);
            this.buttonTable.TabIndex = 10;
            this.buttonTable.Text = "Сформировать таблицу";
            this.buttonTable.UseVisualStyleBackColor = false;
            this.buttonTable.Click += new System.EventHandler(this.buttonTable_Click);
            // 
            // checkBoxPeriod
            // 
            this.checkBoxPeriod.AutoSize = true;
            this.checkBoxPeriod.Location = new System.Drawing.Point(217, 311);
            this.checkBoxPeriod.Name = "checkBoxPeriod";
            this.checkBoxPeriod.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPeriod.TabIndex = 9;
            this.checkBoxPeriod.UseVisualStyleBackColor = true;
            this.checkBoxPeriod.CheckedChanged += new System.EventHandler(this.checkBoxPeriod_CheckedChanged);
            // 
            // checkBoxData
            // 
            this.checkBoxData.AutoSize = true;
            this.checkBoxData.Location = new System.Drawing.Point(217, 196);
            this.checkBoxData.Name = "checkBoxData";
            this.checkBoxData.Size = new System.Drawing.Size(15, 14);
            this.checkBoxData.TabIndex = 8;
            this.checkBoxData.UseVisualStyleBackColor = true;
            this.checkBoxData.CheckedChanged += new System.EventHandler(this.checkBoxData_CheckedChanged);
            // 
            // checkBoxObject
            // 
            this.checkBoxObject.AutoSize = true;
            this.checkBoxObject.Checked = true;
            this.checkBoxObject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxObject.Location = new System.Drawing.Point(217, 94);
            this.checkBoxObject.Name = "checkBoxObject";
            this.checkBoxObject.Size = new System.Drawing.Size(15, 14);
            this.checkBoxObject.TabIndex = 7;
            this.checkBoxObject.UseVisualStyleBackColor = true;
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.BackColor = System.Drawing.SystemColors.Control;
            this.labelPeriod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPeriod.Location = new System.Drawing.Point(36, 257);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(60, 19);
            this.labelPeriod.TabIndex = 6;
            this.labelPeriod.Text = "Период";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.SystemColors.Control;
            this.labelData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelData.Location = new System.Drawing.Point(36, 156);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(44, 19);
            this.labelData.TabIndex = 4;
            this.labelData.Text = "Дата";
            // 
            // panelPeriod
            // 
            this.panelPeriod.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelPeriod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPeriod.Controls.Add(this.dateTimePeriodTo);
            this.panelPeriod.Controls.Add(this.dateTimePeriodFrom);
            this.panelPeriod.Location = new System.Drawing.Point(22, 266);
            this.panelPeriod.Name = "panelPeriod";
            this.panelPeriod.Size = new System.Drawing.Size(173, 102);
            this.panelPeriod.TabIndex = 5;
            // 
            // dateTimePeriodTo
            // 
            this.dateTimePeriodTo.CustomFormat = "dd.mm.yy";
            this.dateTimePeriodTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePeriodTo.Location = new System.Drawing.Point(12, 53);
            this.dateTimePeriodTo.Name = "dateTimePeriodTo";
            this.dateTimePeriodTo.Size = new System.Drawing.Size(145, 23);
            this.dateTimePeriodTo.TabIndex = 6;
            // 
            // dateTimePeriodFrom
            // 
            this.dateTimePeriodFrom.CustomFormat = "dd.mm.yy";
            this.dateTimePeriodFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePeriodFrom.Location = new System.Drawing.Point(12, 24);
            this.dateTimePeriodFrom.Name = "dateTimePeriodFrom";
            this.dateTimePeriodFrom.Size = new System.Drawing.Size(145, 23);
            this.dateTimePeriodFrom.TabIndex = 5;
            // 
            // labelObject
            // 
            this.labelObject.AutoSize = true;
            this.labelObject.BackColor = System.Drawing.SystemColors.Control;
            this.labelObject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelObject.Location = new System.Drawing.Point(36, 54);
            this.labelObject.Name = "labelObject";
            this.labelObject.Size = new System.Drawing.Size(60, 19);
            this.labelObject.TabIndex = 2;
            this.labelObject.Text = "Объект";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dateTime);
            this.panel1.Location = new System.Drawing.Point(22, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 74);
            this.panel1.TabIndex = 3;
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "dd.mm.yy";
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTime.Location = new System.Drawing.Point(12, 24);
            this.dateTime.Name = "dateTime";
            this.dateTime.RightToLeftLayout = true;
            this.dateTime.Size = new System.Drawing.Size(145, 23);
            this.dateTime.TabIndex = 4;
            // 
            // panelObject
            // 
            this.panelObject.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelObject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelObject.Controls.Add(this.comboBoxObject);
            this.panelObject.Location = new System.Drawing.Point(22, 63);
            this.panelObject.Name = "panelObject";
            this.panelObject.Size = new System.Drawing.Size(173, 74);
            this.panelObject.TabIndex = 1;
            // 
            // comboBoxObject
            // 
            this.comboBoxObject.DisplayMember = "павпав";
            this.comboBoxObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxObject.FormattingEnabled = true;
            this.comboBoxObject.Items.AddRange(new object[] {
            "Березино",
            "Бобровичи",
            "Борисов",
            "Вилейка",
            "Воложин",
            "Дзержинск",
            "Клецк",
            "Княгинин",
            "Копыль",
            "Крупки",
            "Логойск",
            "Любань",
            "Минское_РПУ",
            "Молодечно",
            "Мядель",
            "Несвиж",
            "Пуховичи",
            "Руденск",
            "Слуцк",
            "Смолевичи",
            "Солигорск",
            "Стародороги",
            "Столбцы",
            "ТП_Березин",
            "Узда",
            "Червень"});
            this.comboBoxObject.Location = new System.Drawing.Point(12, 24);
            this.comboBoxObject.Name = "comboBoxObject";
            this.comboBoxObject.Size = new System.Drawing.Size(145, 24);
            this.comboBoxObject.TabIndex = 0;
            this.comboBoxObject.Tag = "";
            // 
            // labelSetting
            // 
            this.labelSetting.AutoSize = true;
            this.labelSetting.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSetting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSetting.Location = new System.Drawing.Point(22, 12);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelSetting.Size = new System.Drawing.Size(102, 22);
            this.labelSetting.TabIndex = 0;
            this.labelSetting.Text = "Настройка";
            // 
            // buttonSertificate
            // 
            this.buttonSertificate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSertificate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSertificate.Location = new System.Drawing.Point(22, 178);
            this.buttonSertificate.Name = "buttonSertificate";
            this.buttonSertificate.Size = new System.Drawing.Size(142, 36);
            this.buttonSertificate.TabIndex = 13;
            this.buttonSertificate.Text = "Свидетельство";
            this.buttonSertificate.UseVisualStyleBackColor = false;
            this.buttonSertificate.Click += new System.EventHandler(this.buttonSertificate_Click);
            // 
            // buttonProtocol
            // 
            this.buttonProtocol.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonProtocol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProtocol.Location = new System.Drawing.Point(22, 136);
            this.buttonProtocol.Name = "buttonProtocol";
            this.buttonProtocol.Size = new System.Drawing.Size(102, 36);
            this.buttonProtocol.TabIndex = 12;
            this.buttonProtocol.Text = "Протокол";
            this.buttonProtocol.UseVisualStyleBackColor = false;
            this.buttonProtocol.Click += new System.EventHandler(this.buttonProtocol_Click);
            // 
            // labelSensorNumber
            // 
            this.labelSensorNumber.AutoSize = true;
            this.labelSensorNumber.BackColor = System.Drawing.SystemColors.Control;
            this.labelSensorNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSensorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSensorNumber.Location = new System.Drawing.Point(36, 49);
            this.labelSensorNumber.Name = "labelSensorNumber";
            this.labelSensorNumber.Size = new System.Drawing.Size(111, 19);
            this.labelSensorNumber.TabIndex = 11;
            this.labelSensorNumber.Text = "Номер датчика";
            // 
            // labelexcel
            // 
            this.labelexcel.AutoSize = true;
            this.labelexcel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelexcel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelexcel.Location = new System.Drawing.Point(22, 11);
            this.labelexcel.Name = "labelexcel";
            this.labelexcel.Size = new System.Drawing.Size(133, 22);
            this.labelexcel.TabIndex = 0;
            this.labelexcel.Text = "Microsoft Excel";
            // 
            // panelSensorNumber
            // 
            this.panelSensorNumber.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelSensorNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSensorNumber.Controls.Add(this.comboBoxSensorNumber);
            this.panelSensorNumber.Location = new System.Drawing.Point(22, 58);
            this.panelSensorNumber.Name = "panelSensorNumber";
            this.panelSensorNumber.Size = new System.Drawing.Size(210, 72);
            this.panelSensorNumber.TabIndex = 10;
            // 
            // comboBoxSensorNumber
            // 
            this.comboBoxSensorNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSensorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSensorNumber.FormattingEnabled = true;
            this.comboBoxSensorNumber.Location = new System.Drawing.Point(12, 25);
            this.comboBoxSensorNumber.Name = "comboBoxSensorNumber";
            this.comboBoxSensorNumber.Size = new System.Drawing.Size(159, 24);
            this.comboBoxSensorNumber.TabIndex = 1;
            this.comboBoxSensorNumber.Tag = "";
            this.comboBoxSensorNumber.SelectedIndexChanged += new System.EventHandler(this.comboBoxSensorNumber_SelectedIndexChanged);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.Location = new System.Drawing.Point(305, 19);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(85, 20);
            this.labelError.TabIndex = 4;
            this.labelError.Text = "Ошибки: ";
            // 
            // labelErrorDescription
            // 
            this.labelErrorDescription.AutoSize = true;
            this.labelErrorDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelErrorDescription.Location = new System.Drawing.Point(396, 19);
            this.labelErrorDescription.Name = "labelErrorDescription";
            this.labelErrorDescription.Size = new System.Drawing.Size(108, 20);
            this.labelErrorDescription.TabIndex = 5;
            this.labelErrorDescription.Text = "Отсутствуют";
            // 
            // DatabaseReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.labelErrorDescription);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.labelExistExcel);
            this.Controls.Add(this.GridForViewData);
            this.Name = "DatabaseReader";
            this.Text = "Database reader for MinskOblGas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DatabaseReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridForViewData)).EndInit();
            this.settings.Panel1.ResumeLayout(false);
            this.settings.Panel1.PerformLayout();
            this.settings.Panel2.ResumeLayout(false);
            this.settings.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            this.settings.ResumeLayout(false);
            this.panelPeriod.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelObject.ResumeLayout(false);
            this.panelSensorNumber.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridForViewData;
        private System.Windows.Forms.Label labelExistExcel;
        private System.Windows.Forms.SplitContainer settings;
        private System.Windows.Forms.Label labelSetting;
        private System.Windows.Forms.Label labelexcel;
        private System.Windows.Forms.Label labelObject;
        private System.Windows.Forms.Panel panelObject;
        private System.Windows.Forms.ComboBox comboBoxObject;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Panel panelPeriod;
        private System.Windows.Forms.CheckBox checkBoxPeriod;
        private System.Windows.Forms.CheckBox checkBoxData;
        private System.Windows.Forms.CheckBox checkBoxObject;
        private System.Windows.Forms.DateTimePicker dateTimePeriodTo;
        private System.Windows.Forms.DateTimePicker dateTimePeriodFrom;
        private System.Windows.Forms.Label labelSensorNumber;
        private System.Windows.Forms.Panel panelSensorNumber;
        private System.Windows.Forms.ComboBox comboBoxSensorNumber;
        private System.Windows.Forms.Button buttonProtocol;
        private System.Windows.Forms.Button buttonSertificate;
        private System.Windows.Forms.Button buttonTable;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelErrorDescription;
    }
}


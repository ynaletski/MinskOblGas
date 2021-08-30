﻿
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
            this.ExistExcel = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.SplitContainer();
            this.labelData = new System.Windows.Forms.Label();
            this.labelObject = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.panelObject = new System.Windows.Forms.Panel();
            this.comboBoxObject = new System.Windows.Forms.ComboBox();
            this.Setting = new System.Windows.Forms.Label();
            this.excel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPeriod = new System.Windows.Forms.Panel();
            this.dateTimePeriodFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePeriodTo = new System.Windows.Forms.DateTimePicker();
            this.checkBoxObject = new System.Windows.Forms.CheckBox();
            this.checkBoxData = new System.Windows.Forms.CheckBox();
            this.checkBoxPeriod = new System.Windows.Forms.CheckBox();
            this.labelSensorNumber = new System.Windows.Forms.Label();
            this.panelSensorNumber = new System.Windows.Forms.Panel();
            this.comboBoxSensorNumber = new System.Windows.Forms.ComboBox();
            this.buttonProtocol = new System.Windows.Forms.Button();
            this.buttonSertificate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridForViewData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            this.settings.Panel1.SuspendLayout();
            this.settings.Panel2.SuspendLayout();
            this.settings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelObject.SuspendLayout();
            this.panelPeriod.SuspendLayout();
            this.panelSensorNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridForViewData
            // 
            this.GridForViewData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridForViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridForViewData.Location = new System.Drawing.Point(309, 12);
            this.GridForViewData.Name = "GridForViewData";
            this.GridForViewData.Size = new System.Drawing.Size(847, 687);
            this.GridForViewData.TabIndex = 0;
            // 
            // ExistExcel
            // 
            this.ExistExcel.AutoSize = true;
            this.ExistExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExistExcel.Location = new System.Drawing.Point(44, 26);
            this.ExistExcel.Name = "ExistExcel";
            this.ExistExcel.Size = new System.Drawing.Size(204, 20);
            this.ExistExcel.TabIndex = 2;
            this.ExistExcel.Text = "Доступ к Microsoft Excel16";
            // 
            // settings
            // 
            this.settings.Location = new System.Drawing.Point(26, 67);
            this.settings.Name = "settings";
            this.settings.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // settings.Panel1
            // 
            this.settings.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.settings.Panel1.Controls.Add(this.checkBoxPeriod);
            this.settings.Panel1.Controls.Add(this.checkBoxData);
            this.settings.Panel1.Controls.Add(this.checkBoxObject);
            this.settings.Panel1.Controls.Add(this.label1);
            this.settings.Panel1.Controls.Add(this.labelData);
            this.settings.Panel1.Controls.Add(this.panelPeriod);
            this.settings.Panel1.Controls.Add(this.labelObject);
            this.settings.Panel1.Controls.Add(this.panel1);
            this.settings.Panel1.Controls.Add(this.panelObject);
            this.settings.Panel1.Controls.Add(this.Setting);
            this.settings.Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // settings.Panel2
            // 
            this.settings.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.settings.Panel2.Controls.Add(this.buttonSertificate);
            this.settings.Panel2.Controls.Add(this.buttonProtocol);
            this.settings.Panel2.Controls.Add(this.labelSensorNumber);
            this.settings.Panel2.Controls.Add(this.excel);
            this.settings.Panel2.Controls.Add(this.panelSensorNumber);
            this.settings.Size = new System.Drawing.Size(256, 632);
            this.settings.SplitterDistance = 396;
            this.settings.SplitterWidth = 10;
            this.settings.TabIndex = 3;
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
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTime.Location = new System.Drawing.Point(12, 24);
            this.dateTime.Name = "dateTime";
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
            "Борисов",
            "Вилейка",
            "Воложин",
            "Держинск",
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
            // Setting
            // 
            this.Setting.AutoSize = true;
            this.Setting.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Setting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Setting.Location = new System.Drawing.Point(22, 12);
            this.Setting.Name = "Setting";
            this.Setting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Setting.Size = new System.Drawing.Size(102, 22);
            this.Setting.TabIndex = 0;
            this.Setting.Text = "Настройка";
            // 
            // excel
            // 
            this.excel.AutoSize = true;
            this.excel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.excel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.excel.Location = new System.Drawing.Point(22, 11);
            this.excel.Name = "excel";
            this.excel.Size = new System.Drawing.Size(133, 22);
            this.excel.TabIndex = 0;
            this.excel.Text = "Microsoft Excel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Период";
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
            // dateTimePeriodFrom
            // 
            this.dateTimePeriodFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePeriodFrom.Location = new System.Drawing.Point(12, 24);
            this.dateTimePeriodFrom.Name = "dateTimePeriodFrom";
            this.dateTimePeriodFrom.Size = new System.Drawing.Size(145, 23);
            this.dateTimePeriodFrom.TabIndex = 5;
            // 
            // dateTimePeriodTo
            // 
            this.dateTimePeriodTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePeriodTo.Location = new System.Drawing.Point(12, 53);
            this.dateTimePeriodTo.Name = "dateTimePeriodTo";
            this.dateTimePeriodTo.Size = new System.Drawing.Size(145, 23);
            this.dateTimePeriodTo.TabIndex = 6;
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
            // checkBoxData
            // 
            this.checkBoxData.AutoSize = true;
            this.checkBoxData.Location = new System.Drawing.Point(217, 196);
            this.checkBoxData.Name = "checkBoxData";
            this.checkBoxData.Size = new System.Drawing.Size(15, 14);
            this.checkBoxData.TabIndex = 8;
            this.checkBoxData.UseVisualStyleBackColor = true;
            // 
            // checkBoxPeriod
            // 
            this.checkBoxPeriod.AutoSize = true;
            this.checkBoxPeriod.Location = new System.Drawing.Point(217, 311);
            this.checkBoxPeriod.Name = "checkBoxPeriod";
            this.checkBoxPeriod.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPeriod.TabIndex = 9;
            this.checkBoxPeriod.UseVisualStyleBackColor = true;
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
            this.comboBoxSensorNumber.DisplayMember = "павпав";
            this.comboBoxSensorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSensorNumber.FormattingEnabled = true;
            this.comboBoxSensorNumber.Items.AddRange(new object[] {
            "NULL"});
            this.comboBoxSensorNumber.Location = new System.Drawing.Point(12, 25);
            this.comboBoxSensorNumber.Name = "comboBoxSensorNumber";
            this.comboBoxSensorNumber.Size = new System.Drawing.Size(159, 24);
            this.comboBoxSensorNumber.TabIndex = 1;
            this.comboBoxSensorNumber.Tag = "";
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
            // 
            // DatabaseReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.ExistExcel);
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
            this.panel1.ResumeLayout(false);
            this.panelObject.ResumeLayout(false);
            this.panelPeriod.ResumeLayout(false);
            this.panelSensorNumber.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridForViewData;
        private System.Windows.Forms.Label ExistExcel;
        private System.Windows.Forms.SplitContainer settings;
        private System.Windows.Forms.Label Setting;
        private System.Windows.Forms.Label excel;
        private System.Windows.Forms.Label labelObject;
        private System.Windows.Forms.Panel panelObject;
        private System.Windows.Forms.ComboBox comboBoxObject;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label1;
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
    }
}

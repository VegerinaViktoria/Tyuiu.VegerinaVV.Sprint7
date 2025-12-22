namespace Tyuiu.VegerinaVV.Sprint7.Project.V12
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelLabel_VVV = new Panel();
            buttonAbout_VVV = new Button();
            labelData_VVV = new Label();
            menuStripProject_VVV = new MenuStrip();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            поддержкаToolStripMenuItem = new ToolStripMenuItem();
            руководствоПользователяToolStripMenuItem = new ToolStripMenuItem();
            tabControlData_VVV = new TabControl();
            tabPageBase_VVV = new TabPage();
            groupBoxWork_VVV = new GroupBox();
            buttonFilter_VVV = new Button();
            labelFilter_VVV = new Label();
            labelName_VVV = new Label();
            labelSearch_VVV = new Label();
            textBoxFilter_VVV = new TextBox();
            comboBoxName_VVV = new ComboBox();
            textBoxSearch_VVV = new TextBox();
            labelFilterSearch_VVV = new Label();
            labelAddRemove_VVV = new Label();
            labelOpenSave_VVV = new Label();
            buttonRemove_VVV = new Button();
            buttonAdd_VVV = new Button();
            buttonSave_VVV = new Button();
            buttonOpen_VVV = new Button();
            splitterData_VVV = new Splitter();
            dataGridViewData_VVV = new DataGridView();
            Firms = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Frequency = new DataGridViewTextBoxColumn();
            Ram = new DataGridViewTextBoxColumn();
            Disk = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Cost = new DataGridViewTextBoxColumn();
            tabPageFirms_VVV = new TabPage();
            buttonRemoveFirms_VVV = new Button();
            buttonAddFirms_VVV = new Button();
            buttonSaveFirms_VVV = new Button();
            buttonDoneStatistic_VVV = new Button();
            buttonChartMoney_VVV = new Button();
            textBoxAverage_VVV = new TextBox();
            textBoxMin_VVV = new TextBox();
            textBoxMax_VVV = new TextBox();
            labelAverage_VVV = new Label();
            labelMin_VVV = new Label();
            labelMax_VVV = new Label();
            chartMoney_VVV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonDownload_VVV = new Button();
            labelDownload_VVV = new Label();
            splitterFirm_VVV = new Splitter();
            dataGridViewFirms_VVV = new DataGridView();
            Number = new DataGridViewTextBoxColumn();
            Firm = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Money = new DataGridViewTextBoxColumn();
            groupBoxData_VVV = new GroupBox();
            saveFileDialog_VVV = new SaveFileDialog();
            openFileDialog_VVV = new OpenFileDialog();
            openFileDialogFirms_VVV = new OpenFileDialog();
            saveFileDialogFirms_VVV = new SaveFileDialog();
            panelLabel_VVV.SuspendLayout();
            menuStripProject_VVV.SuspendLayout();
            tabControlData_VVV.SuspendLayout();
            tabPageBase_VVV.SuspendLayout();
            groupBoxWork_VVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_VVV).BeginInit();
            tabPageFirms_VVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartMoney_VVV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFirms_VVV).BeginInit();
            groupBoxData_VVV.SuspendLayout();
            SuspendLayout();
            // 
            // panelLabel_VVV
            // 
            panelLabel_VVV.BackColor = Color.Lavender;
            panelLabel_VVV.Controls.Add(buttonAbout_VVV);
            panelLabel_VVV.Controls.Add(labelData_VVV);
            panelLabel_VVV.Controls.Add(menuStripProject_VVV);
            panelLabel_VVV.Dock = DockStyle.Top;
            panelLabel_VVV.Location = new Point(0, 0);
            panelLabel_VVV.Name = "panelLabel_VVV";
            panelLabel_VVV.Size = new Size(1277, 85);
            panelLabel_VVV.TabIndex = 0;
            // 
            // buttonAbout_VVV
            // 
            buttonAbout_VVV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_VVV.Image = Properties.Resources.information;
            buttonAbout_VVV.Location = new Point(1187, 14);
            buttonAbout_VVV.Name = "buttonAbout_VVV";
            buttonAbout_VVV.Size = new Size(60, 54);
            buttonAbout_VVV.TabIndex = 2;
            buttonAbout_VVV.UseVisualStyleBackColor = true;
            buttonAbout_VVV.Click += buttonAbout_VVV_Click;
            // 
            // labelData_VVV
            // 
            labelData_VVV.AutoSize = true;
            labelData_VVV.BackColor = Color.Transparent;
            labelData_VVV.Font = new Font("Microsoft YaHei", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelData_VVV.ForeColor = Color.Indigo;
            labelData_VVV.Location = new Point(437, 31);
            labelData_VVV.Name = "labelData_VVV";
            labelData_VVV.Size = new Size(342, 37);
            labelData_VVV.TabIndex = 1;
            labelData_VVV.Text = "ПЕРСОНАЛЬНЫЕ ЭВМ";
            // 
            // menuStripProject_VVV
            // 
            menuStripProject_VVV.BackColor = Color.Lavender;
            menuStripProject_VVV.BackgroundImageLayout = ImageLayout.Stretch;
            menuStripProject_VVV.ImageScalingSize = new Size(20, 20);
            menuStripProject_VVV.Items.AddRange(new ToolStripItem[] { справкаToolStripMenuItem });
            menuStripProject_VVV.Location = new Point(0, 0);
            menuStripProject_VVV.Name = "menuStripProject_VVV";
            menuStripProject_VVV.Size = new Size(1277, 32);
            menuStripProject_VVV.TabIndex = 3;
            menuStripProject_VVV.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.BackColor = Color.White;
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поддержкаToolStripMenuItem, руководствоПользователяToolStripMenuItem });
            справкаToolStripMenuItem.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            справкаToolStripMenuItem.ForeColor = Color.Indigo;
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(98, 28);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // поддержкаToolStripMenuItem
            // 
            поддержкаToolStripMenuItem.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            поддержкаToolStripMenuItem.ForeColor = Color.Indigo;
            поддержкаToolStripMenuItem.Name = "поддержкаToolStripMenuItem";
            поддержкаToolStripMenuItem.Size = new Size(336, 28);
            поддержкаToolStripMenuItem.Text = "Поддержка";
            поддержкаToolStripMenuItem.Click += поддержкаToolStripMenuItem_Click;
            // 
            // руководствоПользователяToolStripMenuItem
            // 
            руководствоПользователяToolStripMenuItem.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            руководствоПользователяToolStripMenuItem.ForeColor = Color.Indigo;
            руководствоПользователяToolStripMenuItem.Name = "руководствоПользователяToolStripMenuItem";
            руководствоПользователяToolStripMenuItem.Size = new Size(336, 28);
            руководствоПользователяToolStripMenuItem.Text = "Руководство пользователя";
            руководствоПользователяToolStripMenuItem.Click += руководствоПользователяToolStripMenuItem_Click;
            // 
            // tabControlData_VVV
            // 
            tabControlData_VVV.Controls.Add(tabPageBase_VVV);
            tabControlData_VVV.Controls.Add(tabPageFirms_VVV);
            tabControlData_VVV.Dock = DockStyle.Fill;
            tabControlData_VVV.Location = new Point(3, 25);
            tabControlData_VVV.Name = "tabControlData_VVV";
            tabControlData_VVV.SelectedIndex = 0;
            tabControlData_VVV.Size = new Size(1271, 602);
            tabControlData_VVV.TabIndex = 0;
            // 
            // tabPageBase_VVV
            // 
            tabPageBase_VVV.BackColor = Color.White;
            tabPageBase_VVV.Controls.Add(groupBoxWork_VVV);
            tabPageBase_VVV.Controls.Add(splitterData_VVV);
            tabPageBase_VVV.Controls.Add(dataGridViewData_VVV);
            tabPageBase_VVV.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            tabPageBase_VVV.Location = new Point(4, 32);
            tabPageBase_VVV.Name = "tabPageBase_VVV";
            tabPageBase_VVV.Padding = new Padding(3);
            tabPageBase_VVV.Size = new Size(1263, 566);
            tabPageBase_VVV.TabIndex = 0;
            tabPageBase_VVV.Text = "База данных";
            // 
            // groupBoxWork_VVV
            // 
            groupBoxWork_VVV.BackColor = Color.White;
            groupBoxWork_VVV.Controls.Add(buttonFilter_VVV);
            groupBoxWork_VVV.Controls.Add(labelFilter_VVV);
            groupBoxWork_VVV.Controls.Add(labelName_VVV);
            groupBoxWork_VVV.Controls.Add(labelSearch_VVV);
            groupBoxWork_VVV.Controls.Add(textBoxFilter_VVV);
            groupBoxWork_VVV.Controls.Add(comboBoxName_VVV);
            groupBoxWork_VVV.Controls.Add(textBoxSearch_VVV);
            groupBoxWork_VVV.Controls.Add(labelFilterSearch_VVV);
            groupBoxWork_VVV.Controls.Add(labelAddRemove_VVV);
            groupBoxWork_VVV.Controls.Add(labelOpenSave_VVV);
            groupBoxWork_VVV.Controls.Add(buttonRemove_VVV);
            groupBoxWork_VVV.Controls.Add(buttonAdd_VVV);
            groupBoxWork_VVV.Controls.Add(buttonSave_VVV);
            groupBoxWork_VVV.Controls.Add(buttonOpen_VVV);
            groupBoxWork_VVV.Dock = DockStyle.Fill;
            groupBoxWork_VVV.Location = new Point(952, 3);
            groupBoxWork_VVV.Name = "groupBoxWork_VVV";
            groupBoxWork_VVV.Size = new Size(308, 560);
            groupBoxWork_VVV.TabIndex = 2;
            groupBoxWork_VVV.TabStop = false;
            // 
            // buttonFilter_VVV
            // 
            buttonFilter_VVV.BackColor = Color.FromArgb(192, 192, 255);
            buttonFilter_VVV.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonFilter_VVV.ForeColor = Color.Indigo;
            buttonFilter_VVV.Location = new Point(74, 505);
            buttonFilter_VVV.Name = "buttonFilter_VVV";
            buttonFilter_VVV.Size = new Size(169, 54);
            buttonFilter_VVV.TabIndex = 3;
            buttonFilter_VVV.Text = "Отфильтровать";
            buttonFilter_VVV.UseVisualStyleBackColor = false;
            buttonFilter_VVV.Click += buttonFilter_VVV_Click;
            // 
            // labelFilter_VVV
            // 
            labelFilter_VVV.AutoSize = true;
            labelFilter_VVV.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelFilter_VVV.ForeColor = Color.BlueViolet;
            labelFilter_VVV.Location = new Point(86, 434);
            labelFilter_VVV.Name = "labelFilter_VVV";
            labelFilter_VVV.Size = new Size(141, 19);
            labelFilter_VVV.TabIndex = 12;
            labelFilter_VVV.Text = "Ключевое слово";
            // 
            // labelName_VVV
            // 
            labelName_VVV.AutoSize = true;
            labelName_VVV.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelName_VVV.ForeColor = Color.BlueViolet;
            labelName_VVV.Location = new Point(120, 369);
            labelName_VVV.Name = "labelName_VVV";
            labelName_VVV.Size = new Size(75, 19);
            labelName_VVV.TabIndex = 11;
            labelName_VVV.Text = "Столбец";
            // 
            // labelSearch_VVV
            // 
            labelSearch_VVV.AutoSize = true;
            labelSearch_VVV.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelSearch_VVV.ForeColor = Color.BlueViolet;
            labelSearch_VVV.Location = new Point(120, 307);
            labelSearch_VVV.Name = "labelSearch_VVV";
            labelSearch_VVV.Size = new Size(58, 19);
            labelSearch_VVV.TabIndex = 10;
            labelSearch_VVV.Text = "Поиск";
            // 
            // textBoxFilter_VVV
            // 
            textBoxFilter_VVV.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFilter_VVV.Location = new Point(61, 457);
            textBoxFilter_VVV.Name = "textBoxFilter_VVV";
            textBoxFilter_VVV.Size = new Size(182, 30);
            textBoxFilter_VVV.TabIndex = 9;
            // 
            // comboBoxName_VVV
            // 
            comboBoxName_VVV.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxName_VVV.FormattingEnabled = true;
            comboBoxName_VVV.Items.AddRange(new object[] { "Фирма-изготовитель", "Тип процессора", "Тактовая частота", "Объем ОЗУ", "Объем жесткого диска", "Дата выпуска" });
            comboBoxName_VVV.Location = new Point(64, 391);
            comboBoxName_VVV.Name = "comboBoxName_VVV";
            comboBoxName_VVV.Size = new Size(182, 31);
            comboBoxName_VVV.TabIndex = 8;
            comboBoxName_VVV.SelectedIndexChanged += comboBoxName_VVV_SelectedIndexChanged;
            // 
            // textBoxSearch_VVV
            // 
            textBoxSearch_VVV.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSearch_VVV.Location = new Point(61, 329);
            textBoxSearch_VVV.Name = "textBoxSearch_VVV";
            textBoxSearch_VVV.Size = new Size(185, 30);
            textBoxSearch_VVV.TabIndex = 7;
            textBoxSearch_VVV.TextChanged += textBoxSearch_VVV_TextChanged;
            // 
            // labelFilterSearch_VVV
            // 
            labelFilterSearch_VVV.AutoSize = true;
            labelFilterSearch_VVV.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 204);
            labelFilterSearch_VVV.ForeColor = Color.Indigo;
            labelFilterSearch_VVV.Location = new Point(61, 267);
            labelFilterSearch_VVV.Name = "labelFilterSearch_VVV";
            labelFilterSearch_VVV.Size = new Size(175, 19);
            labelFilterSearch_VVV.TabIndex = 6;
            labelFilterSearch_VVV.Text = "Фильтрация и поиск ";
            // 
            // labelAddRemove_VVV
            // 
            labelAddRemove_VVV.AutoSize = true;
            labelAddRemove_VVV.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelAddRemove_VVV.ForeColor = Color.Indigo;
            labelAddRemove_VVV.Location = new Point(21, 140);
            labelAddRemove_VVV.Name = "labelAddRemove_VVV";
            labelAddRemove_VVV.Size = new Size(264, 19);
            labelAddRemove_VVV.TabIndex = 5;
            labelAddRemove_VVV.Text = "Добавление \\ Удаление данных";
            // 
            // labelOpenSave_VVV
            // 
            labelOpenSave_VVV.AutoSize = true;
            labelOpenSave_VVV.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelOpenSave_VVV.ForeColor = Color.Indigo;
            labelOpenSave_VVV.Location = new Point(21, 23);
            labelOpenSave_VVV.Name = "labelOpenSave_VVV";
            labelOpenSave_VVV.Size = new Size(245, 19);
            labelOpenSave_VVV.TabIndex = 4;
            labelOpenSave_VVV.Text = "Загрузка \\ Сохранение файла";
            // 
            // buttonRemove_VVV
            // 
            buttonRemove_VVV.BackColor = Color.FromArgb(192, 192, 255);
            buttonRemove_VVV.Enabled = false;
            buttonRemove_VVV.Image = (Image)resources.GetObject("buttonRemove_VVV.Image");
            buttonRemove_VVV.Location = new Point(173, 188);
            buttonRemove_VVV.Name = "buttonRemove_VVV";
            buttonRemove_VVV.Size = new Size(63, 60);
            buttonRemove_VVV.TabIndex = 3;
            buttonRemove_VVV.UseVisualStyleBackColor = false;
            buttonRemove_VVV.Click += buttonRemove_VVV_Click;
            // 
            // buttonAdd_VVV
            // 
            buttonAdd_VVV.BackColor = Color.FromArgb(192, 192, 255);
            buttonAdd_VVV.Image = (Image)resources.GetObject("buttonAdd_VVV.Image");
            buttonAdd_VVV.Location = new Point(42, 188);
            buttonAdd_VVV.Name = "buttonAdd_VVV";
            buttonAdd_VVV.Size = new Size(63, 60);
            buttonAdd_VVV.TabIndex = 2;
            buttonAdd_VVV.UseVisualStyleBackColor = false;
            buttonAdd_VVV.Click += buttonAdd_VVV_Click;
            // 
            // buttonSave_VVV
            // 
            buttonSave_VVV.BackColor = Color.FromArgb(192, 192, 255);
            buttonSave_VVV.Enabled = false;
            buttonSave_VVV.Image = Properties.Resources.database_save;
            buttonSave_VVV.Location = new Point(173, 59);
            buttonSave_VVV.Name = "buttonSave_VVV";
            buttonSave_VVV.Size = new Size(63, 60);
            buttonSave_VVV.TabIndex = 1;
            buttonSave_VVV.UseVisualStyleBackColor = false;
            buttonSave_VVV.Click += buttonSave_VVV_Click;
            // 
            // buttonOpen_VVV
            // 
            buttonOpen_VVV.BackColor = Color.FromArgb(192, 192, 255);
            buttonOpen_VVV.Image = Properties.Resources.folder_database;
            buttonOpen_VVV.Location = new Point(42, 59);
            buttonOpen_VVV.Name = "buttonOpen_VVV";
            buttonOpen_VVV.Size = new Size(63, 60);
            buttonOpen_VVV.TabIndex = 0;
            buttonOpen_VVV.UseVisualStyleBackColor = false;
            buttonOpen_VVV.Click += buttonOpen_VVV_Click;
            // 
            // splitterData_VVV
            // 
            splitterData_VVV.Location = new Point(942, 3);
            splitterData_VVV.Name = "splitterData_VVV";
            splitterData_VVV.Size = new Size(10, 560);
            splitterData_VVV.TabIndex = 1;
            splitterData_VVV.TabStop = false;
            // 
            // dataGridViewData_VVV
            // 
            dataGridViewData_VVV.AllowUserToAddRows = false;
            dataGridViewData_VVV.BackgroundColor = Color.Lavender;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewData_VVV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewData_VVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData_VVV.Columns.AddRange(new DataGridViewColumn[] { Firms, Type, Frequency, Ram, Disk, Date, Cost });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewData_VVV.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewData_VVV.Dock = DockStyle.Left;
            dataGridViewData_VVV.Location = new Point(3, 3);
            dataGridViewData_VVV.Name = "dataGridViewData_VVV";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft YaHei", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewData_VVV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewData_VVV.RowHeadersVisible = false;
            dataGridViewData_VVV.RowHeadersWidth = 51;
            dataGridViewData_VVV.Size = new Size(939, 560);
            dataGridViewData_VVV.TabIndex = 0;
            // 
            // Firms
            // 
            Firms.HeaderText = "Фирма изготовитель";
            Firms.MinimumWidth = 6;
            Firms.Name = "Firms";
            Firms.Width = 130;
            // 
            // Type
            // 
            Type.HeaderText = "Тип процессора";
            Type.MinimumWidth = 6;
            Type.Name = "Type";
            Type.Width = 155;
            // 
            // Frequency
            // 
            Frequency.HeaderText = "Тактовая частота";
            Frequency.MinimumWidth = 6;
            Frequency.Name = "Frequency";
            Frequency.Width = 110;
            // 
            // Ram
            // 
            Ram.HeaderText = "Объем ОЗУ";
            Ram.MinimumWidth = 6;
            Ram.Name = "Ram";
            Ram.Width = 110;
            // 
            // Disk
            // 
            Disk.HeaderText = "Объем жесткого диска";
            Disk.MinimumWidth = 6;
            Disk.Name = "Disk";
            Disk.Width = 145;
            // 
            // Date
            // 
            Date.HeaderText = "Дата выпуска";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 145;
            // 
            // Cost
            // 
            Cost.HeaderText = "Стоимость";
            Cost.MinimumWidth = 6;
            Cost.Name = "Cost";
            Cost.Width = 140;
            // 
            // tabPageFirms_VVV
            // 
            tabPageFirms_VVV.BackColor = Color.FromArgb(192, 192, 255);
            tabPageFirms_VVV.Controls.Add(buttonRemoveFirms_VVV);
            tabPageFirms_VVV.Controls.Add(buttonAddFirms_VVV);
            tabPageFirms_VVV.Controls.Add(buttonSaveFirms_VVV);
            tabPageFirms_VVV.Controls.Add(buttonDoneStatistic_VVV);
            tabPageFirms_VVV.Controls.Add(buttonChartMoney_VVV);
            tabPageFirms_VVV.Controls.Add(textBoxAverage_VVV);
            tabPageFirms_VVV.Controls.Add(textBoxMin_VVV);
            tabPageFirms_VVV.Controls.Add(textBoxMax_VVV);
            tabPageFirms_VVV.Controls.Add(labelAverage_VVV);
            tabPageFirms_VVV.Controls.Add(labelMin_VVV);
            tabPageFirms_VVV.Controls.Add(labelMax_VVV);
            tabPageFirms_VVV.Controls.Add(chartMoney_VVV);
            tabPageFirms_VVV.Controls.Add(buttonDownload_VVV);
            tabPageFirms_VVV.Controls.Add(labelDownload_VVV);
            tabPageFirms_VVV.Controls.Add(splitterFirm_VVV);
            tabPageFirms_VVV.Controls.Add(dataGridViewFirms_VVV);
            tabPageFirms_VVV.Location = new Point(4, 32);
            tabPageFirms_VVV.Name = "tabPageFirms_VVV";
            tabPageFirms_VVV.Padding = new Padding(3);
            tabPageFirms_VVV.Size = new Size(1263, 566);
            tabPageFirms_VVV.TabIndex = 1;
            tabPageFirms_VVV.Text = "Фирмы-реализаторы";
            // 
            // buttonRemoveFirms_VVV
            // 
            buttonRemoveFirms_VVV.Enabled = false;
            buttonRemoveFirms_VVV.Image = Properties.Resources.cross;
            buttonRemoveFirms_VVV.Location = new Point(854, 407);
            buttonRemoveFirms_VVV.Name = "buttonRemoveFirms_VVV";
            buttonRemoveFirms_VVV.Size = new Size(72, 59);
            buttonRemoveFirms_VVV.TabIndex = 15;
            buttonRemoveFirms_VVV.UseVisualStyleBackColor = true;
            buttonRemoveFirms_VVV.Click += buttonRemoveFirms_VVV_Click;
            // 
            // buttonAddFirms_VVV
            // 
            buttonAddFirms_VVV.Image = Properties.Resources.add;
            buttonAddFirms_VVV.Location = new Point(766, 407);
            buttonAddFirms_VVV.Name = "buttonAddFirms_VVV";
            buttonAddFirms_VVV.Size = new Size(72, 59);
            buttonAddFirms_VVV.TabIndex = 14;
            buttonAddFirms_VVV.UseVisualStyleBackColor = true;
            buttonAddFirms_VVV.Click += buttonAddFirms_VVV_Click;
            // 
            // buttonSaveFirms_VVV
            // 
            buttonSaveFirms_VVV.Enabled = false;
            buttonSaveFirms_VVV.Image = Properties.Resources.database_save;
            buttonSaveFirms_VVV.Location = new Point(854, 335);
            buttonSaveFirms_VVV.Name = "buttonSaveFirms_VVV";
            buttonSaveFirms_VVV.Size = new Size(72, 66);
            buttonSaveFirms_VVV.TabIndex = 13;
            buttonSaveFirms_VVV.UseVisualStyleBackColor = true;
            buttonSaveFirms_VVV.Click += buttonSaveFirms_VVV_Click;
            // 
            // buttonDoneStatistic_VVV
            // 
            buttonDoneStatistic_VVV.Image = Properties.Resources.tick;
            buttonDoneStatistic_VVV.Location = new Point(1058, 484);
            buttonDoneStatistic_VVV.Name = "buttonDoneStatistic_VVV";
            buttonDoneStatistic_VVV.Size = new Size(145, 48);
            buttonDoneStatistic_VVV.TabIndex = 12;
            buttonDoneStatistic_VVV.UseVisualStyleBackColor = true;
            buttonDoneStatistic_VVV.Click += buttonDoneStatistic_VVV_Click;
            // 
            // buttonChartMoney_VVV
            // 
            buttonChartMoney_VVV.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonChartMoney_VVV.ForeColor = Color.Indigo;
            buttonChartMoney_VVV.Image = Properties.Resources.chart_pie;
            buttonChartMoney_VVV.ImageAlign = ContentAlignment.MiddleRight;
            buttonChartMoney_VVV.Location = new Point(737, 478);
            buttonChartMoney_VVV.Name = "buttonChartMoney_VVV";
            buttonChartMoney_VVV.Size = new Size(234, 62);
            buttonChartMoney_VVV.TabIndex = 11;
            buttonChartMoney_VVV.Text = "Построить диаграмму";
            buttonChartMoney_VVV.TextAlign = ContentAlignment.MiddleLeft;
            buttonChartMoney_VVV.UseVisualStyleBackColor = true;
            buttonChartMoney_VVV.Click += buttonChartMoney_VVV_Click;
            // 
            // textBoxAverage_VVV
            // 
            textBoxAverage_VVV.Location = new Point(1070, 439);
            textBoxAverage_VVV.Name = "textBoxAverage_VVV";
            textBoxAverage_VVV.Size = new Size(123, 29);
            textBoxAverage_VVV.TabIndex = 10;
            // 
            // textBoxMin_VVV
            // 
            textBoxMin_VVV.Location = new Point(1070, 385);
            textBoxMin_VVV.Name = "textBoxMin_VVV";
            textBoxMin_VVV.Size = new Size(123, 29);
            textBoxMin_VVV.TabIndex = 9;
            // 
            // textBoxMax_VVV
            // 
            textBoxMax_VVV.Location = new Point(1070, 327);
            textBoxMax_VVV.Name = "textBoxMax_VVV";
            textBoxMax_VVV.Size = new Size(123, 29);
            textBoxMax_VVV.TabIndex = 8;
            // 
            // labelAverage_VVV
            // 
            labelAverage_VVV.AutoSize = true;
            labelAverage_VVV.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelAverage_VVV.ForeColor = Color.Indigo;
            labelAverage_VVV.Location = new Point(1048, 417);
            labelAverage_VVV.Name = "labelAverage_VVV";
            labelAverage_VVV.Size = new Size(161, 19);
            labelAverage_VVV.TabIndex = 7;
            labelAverage_VVV.Text = "Средняя стоимость";
            // 
            // labelMin_VVV
            // 
            labelMin_VVV.AutoSize = true;
            labelMin_VVV.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelMin_VVV.ForeColor = Color.Indigo;
            labelMin_VVV.Location = new Point(1070, 360);
            labelMin_VVV.Name = "labelMin_VVV";
            labelMin_VVV.Size = new Size(133, 19);
            labelMin_VVV.TabIndex = 6;
            labelMin_VVV.Text = "Мин. стоимость";
            // 
            // labelMax_VVV
            // 
            labelMax_VVV.AutoSize = true;
            labelMax_VVV.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelMax_VVV.ForeColor = Color.Indigo;
            labelMax_VVV.Location = new Point(1064, 305);
            labelMax_VVV.Name = "labelMax_VVV";
            labelMax_VVV.Size = new Size(139, 19);
            labelMax_VVV.TabIndex = 5;
            labelMax_VVV.Text = "Макс. стоимость\r\n";
            // 
            // chartMoney_VVV
            // 
            chartArea1.Name = "ChartArea1";
            chartMoney_VVV.ChartAreas.Add(chartArea1);
            chartMoney_VVV.Dock = DockStyle.Top;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "Legend1";
            chartMoney_VVV.Legends.Add(legend1);
            chartMoney_VVV.Location = new Point(687, 3);
            chartMoney_VVV.Name = "chartMoney_VVV";
            chartMoney_VVV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            chartMoney_VVV.Series.Add(series1);
            chartMoney_VVV.Size = new Size(573, 300);
            chartMoney_VVV.TabIndex = 4;
            title1.Font = new Font("Microsoft YaHei", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.Indigo;
            title1.Name = "TitleChart";
            title1.Text = "Стартовые цены";
            chartMoney_VVV.Titles.Add(title1);
            chartMoney_VVV.Click += chartMoney_VVV_Click;
            // 
            // buttonDownload_VVV
            // 
            buttonDownload_VVV.Image = Properties.Resources.folder_database;
            buttonDownload_VVV.Location = new Point(766, 335);
            buttonDownload_VVV.Name = "buttonDownload_VVV";
            buttonDownload_VVV.Size = new Size(72, 66);
            buttonDownload_VVV.TabIndex = 3;
            buttonDownload_VVV.UseVisualStyleBackColor = true;
            buttonDownload_VVV.Click += buttonDownload_VVV_Click;
            // 
            // labelDownload_VVV
            // 
            labelDownload_VVV.AutoSize = true;
            labelDownload_VVV.Font = new Font("Microsoft YaHei", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 204);
            labelDownload_VVV.ForeColor = Color.Indigo;
            labelDownload_VVV.Location = new Point(737, 313);
            labelDownload_VVV.Name = "labelDownload_VVV";
            labelDownload_VVV.Size = new Size(232, 19);
            labelDownload_VVV.TabIndex = 2;
            labelDownload_VVV.Text = "Редактировать базу данных\r\n";
            // 
            // splitterFirm_VVV
            // 
            splitterFirm_VVV.Location = new Point(677, 3);
            splitterFirm_VVV.Name = "splitterFirm_VVV";
            splitterFirm_VVV.Size = new Size(10, 560);
            splitterFirm_VVV.TabIndex = 1;
            splitterFirm_VVV.TabStop = false;
            // 
            // dataGridViewFirms_VVV
            // 
            dataGridViewFirms_VVV.AllowUserToAddRows = false;
            dataGridViewFirms_VVV.BackgroundColor = Color.Lavender;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewFirms_VVV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewFirms_VVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFirms_VVV.Columns.AddRange(new DataGridViewColumn[] { Number, Firm, Address, Phone, Money });
            dataGridViewFirms_VVV.Dock = DockStyle.Left;
            dataGridViewFirms_VVV.Location = new Point(3, 3);
            dataGridViewFirms_VVV.Name = "dataGridViewFirms_VVV";
            dataGridViewFirms_VVV.RowHeadersVisible = false;
            dataGridViewFirms_VVV.RowHeadersWidth = 51;
            dataGridViewFirms_VVV.Size = new Size(674, 560);
            dataGridViewFirms_VVV.TabIndex = 0;
            // 
            // Number
            // 
            Number.HeaderText = "Номер";
            Number.MinimumWidth = 3;
            Number.Name = "Number";
            Number.Width = 80;
            // 
            // Firm
            // 
            Firm.HeaderText = "Наименование";
            Firm.MinimumWidth = 6;
            Firm.Name = "Firm";
            Firm.Width = 150;
            // 
            // Address
            // 
            Address.HeaderText = "Адрес";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 155;
            // 
            // Phone
            // 
            Phone.HeaderText = "Телефон";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.Width = 140;
            // 
            // Money
            // 
            Money.HeaderText = "Стартовая цена";
            Money.MinimumWidth = 6;
            Money.Name = "Money";
            Money.Width = 130;
            // 
            // groupBoxData_VVV
            // 
            groupBoxData_VVV.Controls.Add(tabControlData_VVV);
            groupBoxData_VVV.Dock = DockStyle.Fill;
            groupBoxData_VVV.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxData_VVV.Location = new Point(0, 85);
            groupBoxData_VVV.Name = "groupBoxData_VVV";
            groupBoxData_VVV.Size = new Size(1277, 630);
            groupBoxData_VVV.TabIndex = 1;
            groupBoxData_VVV.TabStop = false;
            groupBoxData_VVV.Text = "Главная";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1277, 715);
            Controls.Add(groupBoxData_VVV);
            Controls.Add(panelLabel_VVV);
            MainMenuStrip = menuStripProject_VVV;
            MinimumSize = new Size(1295, 762);
            Name = "FormMain";
            Text = "Персональные ЭВМ | Выполнила: Вегерина В. В.";
            panelLabel_VVV.ResumeLayout(false);
            panelLabel_VVV.PerformLayout();
            menuStripProject_VVV.ResumeLayout(false);
            menuStripProject_VVV.PerformLayout();
            tabControlData_VVV.ResumeLayout(false);
            tabPageBase_VVV.ResumeLayout(false);
            groupBoxWork_VVV.ResumeLayout(false);
            groupBoxWork_VVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_VVV).EndInit();
            tabPageFirms_VVV.ResumeLayout(false);
            tabPageFirms_VVV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartMoney_VVV).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFirms_VVV).EndInit();
            groupBoxData_VVV.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLabel_VVV;
        private TabControl tabControlData_VVV;
        private TabPage tabPageBase_VVV;
        private TabPage tabPageFirms_VVV;
        private Label labelData_VVV;
        private GroupBox groupBoxData_VVV;
        private GroupBox groupBoxWork_VVV;
        private Splitter splitterData_VVV;
        private DataGridView dataGridViewData_VVV;
        private Button buttonRemove_VVV;
        private Button buttonAdd_VVV;
        private Button buttonSave_VVV;
        private Button buttonOpen_VVV;
        private Label labelAddRemove_VVV;
        private Label labelOpenSave_VVV;
        private Label labelFilterSearch_VVV;
        private TextBox textBoxSearch_VVV;
        private Label labelFilter_VVV;
        private Label labelName_VVV;
        private Label labelSearch_VVV;
        private TextBox textBoxFilter_VVV;
        private ComboBox comboBoxName_VVV;
        private DataGridView dataGridViewFirms_VVV;
        private Splitter splitterFirm_VVV;
        private Button buttonDownload_VVV;
        private Label labelDownload_VVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMoney_VVV;
        private TextBox textBoxAverage_VVV;
        private TextBox textBoxMin_VVV;
        private TextBox textBoxMax_VVV;
        private Label labelAverage_VVV;
        private Label labelMin_VVV;
        private Label labelMax_VVV;
        private Button buttonAbout_VVV;
        private Button buttonFilter_VVV;
        private SaveFileDialog saveFileDialog_VVV;
        private OpenFileDialog openFileDialog_VVV;
        private Button buttonChartMoney_VVV;
        private OpenFileDialog openFileDialogFirms_VVV;
        private Button buttonDoneStatistic_VVV;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn Firm;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Money;
        private Button buttonSaveFirms_VVV;
        private SaveFileDialog saveFileDialogFirms_VVV;
        private Button buttonRemoveFirms_VVV;
        private Button buttonAddFirms_VVV;
        private DataGridViewTextBoxColumn Firms;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Frequency;
        private DataGridViewTextBoxColumn Ram;
        private DataGridViewTextBoxColumn Disk;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Cost;
        private MenuStrip menuStripProject_VVV;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem поддержкаToolStripMenuItem;
        private ToolStripMenuItem руководствоПользователяToolStripMenuItem;
    }
}

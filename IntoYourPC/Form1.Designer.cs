namespace IntoYourPC
{
    partial class MainForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.memoryTabPage = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.diskDriveProperitiesListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.physicalMemoryProperitiesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processorTabPage = new System.Windows.Forms.TabPage();
            this.tempGraphicsPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.processorTempProgressBar = new System.Windows.Forms.ProgressBar();
            this.currentProcessorTempLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.processorProperitiesListView = new System.Windows.Forms.ListView();
            this.properityColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valueColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.processorNameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clockSpeedProgressBar = new System.Windows.Forms.ProgressBar();
            this.currentProcessorClockSpeedLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maxProcessorClockSpeedLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.hardvareInfoTabControl = new System.Windows.Forms.TabControl();
            this.memoryTabPage.SuspendLayout();
            this.processorTabPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.hardvareInfoTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // memoryTabPage
            // 
            this.memoryTabPage.AutoScroll = true;
            this.memoryTabPage.Controls.Add(this.label11);
            this.memoryTabPage.Controls.Add(this.label10);
            this.memoryTabPage.Controls.Add(this.label7);
            this.memoryTabPage.Controls.Add(this.diskDriveProperitiesListView);
            this.memoryTabPage.Controls.Add(this.physicalMemoryProperitiesListView);
            this.memoryTabPage.Location = new System.Drawing.Point(4, 29);
            this.memoryTabPage.Name = "memoryTabPage";
            this.memoryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.memoryTabPage.Size = new System.Drawing.Size(788, 668);
            this.memoryTabPage.TabIndex = 1;
            this.memoryTabPage.Text = "Пам\'ять";
            this.memoryTabPage.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(26, 424);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(730, 25);
            this.label11.TabIndex = 18;
            this.label11.Text = "Фізичні накопичувачі";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(26, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(730, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Оперативна пам\'ять";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(182, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(394, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "ІНФОРМАЦІЯ ПРО ПАМ\'ЯТЬ";
            // 
            // diskDriveProperitiesListView
            // 
            this.diskDriveProperitiesListView.AllowColumnReorder = true;
            this.diskDriveProperitiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.diskDriveProperitiesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diskDriveProperitiesListView.FullRowSelect = true;
            this.diskDriveProperitiesListView.GridLines = true;
            this.diskDriveProperitiesListView.Location = new System.Drawing.Point(17, 456);
            this.diskDriveProperitiesListView.Name = "diskDriveProperitiesListView";
            this.diskDriveProperitiesListView.Size = new System.Drawing.Size(730, 305);
            this.diskDriveProperitiesListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.diskDriveProperitiesListView.TabIndex = 15;
            this.diskDriveProperitiesListView.UseCompatibleStateImageBehavior = false;
            this.diskDriveProperitiesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Властивість";
            this.columnHeader3.Width = 180;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Значення";
            this.columnHeader4.Width = 362;
            // 
            // physicalMemoryProperitiesListView
            // 
            this.physicalMemoryProperitiesListView.AllowColumnReorder = true;
            this.physicalMemoryProperitiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.physicalMemoryProperitiesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.physicalMemoryProperitiesListView.FullRowSelect = true;
            this.physicalMemoryProperitiesListView.GridLines = true;
            this.physicalMemoryProperitiesListView.Location = new System.Drawing.Point(17, 103);
            this.physicalMemoryProperitiesListView.Name = "physicalMemoryProperitiesListView";
            this.physicalMemoryProperitiesListView.Size = new System.Drawing.Size(730, 305);
            this.physicalMemoryProperitiesListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.physicalMemoryProperitiesListView.TabIndex = 14;
            this.physicalMemoryProperitiesListView.UseCompatibleStateImageBehavior = false;
            this.physicalMemoryProperitiesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Властивість";
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Значення";
            this.columnHeader2.Width = 362;
            // 
            // processorTabPage
            // 
            this.processorTabPage.AutoScroll = true;
            this.processorTabPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.processorTabPage.Controls.Add(this.tempGraphicsPanel);
            this.processorTabPage.Controls.Add(this.label5);
            this.processorTabPage.Controls.Add(this.panel1);
            this.processorTabPage.Controls.Add(this.processorProperitiesListView);
            this.processorTabPage.Controls.Add(this.processorNameLabel);
            this.processorTabPage.Controls.Add(this.label3);
            this.processorTabPage.Controls.Add(this.label2);
            this.processorTabPage.Controls.Add(this.label1);
            this.processorTabPage.Controls.Add(this.panel3);
            this.processorTabPage.Controls.Add(this.panel5);
            this.processorTabPage.Location = new System.Drawing.Point(4, 29);
            this.processorTabPage.Name = "processorTabPage";
            this.processorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.processorTabPage.Size = new System.Drawing.Size(788, 668);
            this.processorTabPage.TabIndex = 0;
            this.processorTabPage.Text = "Процесор";
            this.processorTabPage.UseVisualStyleBackColor = true;
            // 
            // tempGraphicsPanel
            // 
            this.tempGraphicsPanel.BackColor = System.Drawing.Color.White;
            this.tempGraphicsPanel.Location = new System.Drawing.Point(33, 288);
            this.tempGraphicsPanel.Name = "tempGraphicsPanel";
            this.tempGraphicsPanel.Size = new System.Drawing.Size(696, 230);
            this.tempGraphicsPanel.TabIndex = 18;
            this.tempGraphicsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tempGraphicsPanel_Paint);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(36, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(355, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Графік температури процесора від часу:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.processorTempProgressBar);
            this.panel1.Controls.Add(this.currentProcessorTempLabel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(45, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 108);
            this.panel1.TabIndex = 14;
            // 
            // processorTempProgressBar
            // 
            this.processorTempProgressBar.Location = new System.Drawing.Point(11, 58);
            this.processorTempProgressBar.Name = "processorTempProgressBar";
            this.processorTempProgressBar.Size = new System.Drawing.Size(292, 32);
            this.processorTempProgressBar.TabIndex = 11;
            // 
            // currentProcessorTempLabel
            // 
            this.currentProcessorTempLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentProcessorTempLabel.AutoSize = true;
            this.currentProcessorTempLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.currentProcessorTempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentProcessorTempLabel.Location = new System.Drawing.Point(134, 33);
            this.currentProcessorTempLabel.Name = "currentProcessorTempLabel";
            this.currentProcessorTempLabel.Size = new System.Drawing.Size(18, 20);
            this.currentProcessorTempLabel.TabIndex = 4;
            this.currentProcessorTempLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gainsboro;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(92, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Температура (C):";
            // 
            // processorProperitiesListView
            // 
            this.processorProperitiesListView.AllowColumnReorder = true;
            this.processorProperitiesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.properityColumnHeader,
            this.valueColumnHeader});
            this.processorProperitiesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.processorProperitiesListView.FullRowSelect = true;
            this.processorProperitiesListView.GridLines = true;
            this.processorProperitiesListView.Location = new System.Drawing.Point(16, 572);
            this.processorProperitiesListView.Name = "processorProperitiesListView";
            this.processorProperitiesListView.Size = new System.Drawing.Size(730, 336);
            this.processorProperitiesListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.processorProperitiesListView.TabIndex = 13;
            this.processorProperitiesListView.UseCompatibleStateImageBehavior = false;
            this.processorProperitiesListView.View = System.Windows.Forms.View.Details;
            // 
            // properityColumnHeader
            // 
            this.properityColumnHeader.Text = "Властивість";
            this.properityColumnHeader.Width = 180;
            // 
            // valueColumnHeader
            // 
            this.valueColumnHeader.Text = "Значення";
            this.valueColumnHeader.Width = 362;
            // 
            // processorNameLabel
            // 
            this.processorNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.processorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.processorNameLabel.Location = new System.Drawing.Point(16, 48);
            this.processorNameLabel.Name = "processorNameLabel";
            this.processorNameLabel.Size = new System.Drawing.Size(730, 25);
            this.processorNameLabel.TabIndex = 10;
            this.processorNameLabel.Text = "Поточний статус роботи:";
            this.processorNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Додаткова інформація:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(151, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(434, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "ІНФОРМАЦІЯ ПРО ПРОЦЕСОР";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поточний статус роботи:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(16, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(730, 157);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.clockSpeedProgressBar);
            this.panel2.Controls.Add(this.currentProcessorClockSpeedLabel);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.maxProcessorClockSpeedLabel);
            this.panel2.Location = new System.Drawing.Point(375, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 108);
            this.panel2.TabIndex = 15;
            // 
            // clockSpeedProgressBar
            // 
            this.clockSpeedProgressBar.Location = new System.Drawing.Point(16, 58);
            this.clockSpeedProgressBar.Name = "clockSpeedProgressBar";
            this.clockSpeedProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clockSpeedProgressBar.Size = new System.Drawing.Size(292, 32);
            this.clockSpeedProgressBar.TabIndex = 12;
            this.clockSpeedProgressBar.Value = 49;
            // 
            // currentProcessorClockSpeedLabel
            // 
            this.currentProcessorClockSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentProcessorClockSpeedLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.currentProcessorClockSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentProcessorClockSpeedLabel.Location = new System.Drawing.Point(96, 33);
            this.currentProcessorClockSpeedLabel.Name = "currentProcessorClockSpeedLabel";
            this.currentProcessorClockSpeedLabel.Size = new System.Drawing.Size(53, 20);
            this.currentProcessorClockSpeedLabel.TabIndex = 3;
            this.currentProcessorClockSpeedLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gainsboro;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(59, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Частота роботи (MHz):";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gainsboro;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(155, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "/";
            // 
            // maxProcessorClockSpeedLabel
            // 
            this.maxProcessorClockSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maxProcessorClockSpeedLabel.AutoSize = true;
            this.maxProcessorClockSpeedLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.maxProcessorClockSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxProcessorClockSpeedLabel.Location = new System.Drawing.Point(175, 33);
            this.maxProcessorClockSpeedLabel.Name = "maxProcessorClockSpeedLabel";
            this.maxProcessorClockSpeedLabel.Size = new System.Drawing.Size(18, 20);
            this.maxProcessorClockSpeedLabel.TabIndex = 2;
            this.maxProcessorClockSpeedLabel.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(16, 274);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(730, 260);
            this.panel5.TabIndex = 19;
            // 
            // hardvareInfoTabControl
            // 
            this.hardvareInfoTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hardvareInfoTabControl.Controls.Add(this.processorTabPage);
            this.hardvareInfoTabControl.Controls.Add(this.memoryTabPage);
            this.hardvareInfoTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hardvareInfoTabControl.Location = new System.Drawing.Point(4, 4);
            this.hardvareInfoTabControl.Name = "hardvareInfoTabControl";
            this.hardvareInfoTabControl.SelectedIndex = 0;
            this.hardvareInfoTabControl.Size = new System.Drawing.Size(796, 701);
            this.hardvareInfoTabControl.TabIndex = 0;
            this.hardvareInfoTabControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.hardvareInfoTabControl_Selecting);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 717);
            this.Controls.Add(this.hardvareInfoTabControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IntoYourPC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.memoryTabPage.ResumeLayout(false);
            this.memoryTabPage.PerformLayout();
            this.processorTabPage.ResumeLayout(false);
            this.processorTabPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.hardvareInfoTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage memoryTabPage;
        private System.Windows.Forms.TabPage processorTabPage;
        private System.Windows.Forms.Panel tempGraphicsPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar processorTempProgressBar;
        private System.Windows.Forms.Label currentProcessorTempLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView processorProperitiesListView;
        private System.Windows.Forms.ColumnHeader properityColumnHeader;
        private System.Windows.Forms.ColumnHeader valueColumnHeader;
        private System.Windows.Forms.Label processorNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar clockSpeedProgressBar;
        private System.Windows.Forms.Label currentProcessorClockSpeedLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label maxProcessorClockSpeedLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TabControl hardvareInfoTabControl;
        private System.Windows.Forms.ListView diskDriveProperitiesListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView physicalMemoryProperitiesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}


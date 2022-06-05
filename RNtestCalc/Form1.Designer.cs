namespace RNtestCalc
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonCalculate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExport = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelWm = new System.Windows.Forms.Label();
            this.labelWtot = new System.Windows.Forms.Label();
            this.labelItot = new System.Windows.Forms.Label();
            this.labelDsal = new System.Windows.Forms.Label();
            this.labelZG = new System.Windows.Forms.Label();
            this.labelTG = new System.Windows.Forms.Label();
            this.textBoxWm = new System.Windows.Forms.TextBox();
            this.textBoxWtot = new System.Windows.Forms.TextBox();
            this.textBoxItot = new System.Windows.Forms.TextBox();
            this.comboBoxZG = new System.Windows.Forms.ComboBox();
            this.comboBoxTG = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "Загрузить";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.dataToolStripMenuItem.Text = "Результат";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculateToolStripMenuItem.Text = "Рассчитать";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.calculateToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Выгрузить все";
            this.exportToolStripMenuItem.ToolTipText = "Экспортировать результат";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonCalculate,
            this.toolStripSeparator1,
            this.toolStripButtonSave,
            this.toolStripButtonLoad,
            this.toolStripSeparator2,
            this.toolStripButtonExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1010, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonCalculate
            // 
            this.toolStripButtonCalculate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCalculate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCalculate.Image")));
            this.toolStripButtonCalculate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCalculate.Name = "toolStripButtonCalculate";
            this.toolStripButtonCalculate.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCalculate.Text = "C";
            this.toolStripButtonCalculate.ToolTipText = "Рассчитать";
            this.toolStripButtonCalculate.Click += new System.EventHandler(this.toolStripButtonCalculate_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "S";
            this.toolStripButtonSave.ToolTipText = "Сохранить данные";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonLoad
            // 
            this.toolStripButtonLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoad.Image")));
            this.toolStripButtonLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoad.Name = "toolStripButtonLoad";
            this.toolStripButtonLoad.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLoad.Text = "L";
            this.toolStripButtonLoad.ToolTipText = "Загрузить данные";
            this.toolStripButtonLoad.Click += new System.EventHandler(this.toolStripButtonLoad_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonExport
            // 
            this.toolStripButtonExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExport.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExport.Image")));
            this.toolStripButtonExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExport.Name = "toolStripButtonExport";
            this.toolStripButtonExport.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExport.Text = "E";
            this.toolStripButtonExport.ToolTipText = "Экспортировать результат";
            this.toolStripButtonExport.Click += new System.EventHandler(this.toolStripButtonExport_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDown1);
            this.splitContainer1.Panel1.Controls.Add(this.labelWm);
            this.splitContainer1.Panel1.Controls.Add(this.labelWtot);
            this.splitContainer1.Panel1.Controls.Add(this.labelItot);
            this.splitContainer1.Panel1.Controls.Add(this.labelDsal);
            this.splitContainer1.Panel1.Controls.Add(this.labelZG);
            this.splitContainer1.Panel1.Controls.Add(this.labelTG);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxWm);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxWtot);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxItot);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxZG);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxTG);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1010, 489);
            this.splitContainer1.SplitterDistance = 167;
            this.splitContainer1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(3, 122);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(134, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelWm
            // 
            this.labelWm.AutoSize = true;
            this.labelWm.Location = new System.Drawing.Point(0, 230);
            this.labelWm.Name = "labelWm";
            this.labelWm.Size = new System.Drawing.Size(173, 13);
            this.labelWm.TabIndex = 11;
            this.labelWm.Text = "Влажность мерзлого грунта Wm";
            // 
            // labelWtot
            // 
            this.labelWtot.AutoSize = true;
            this.labelWtot.Location = new System.Drawing.Point(0, 187);
            this.labelWtot.Name = "labelWtot";
            this.labelWtot.Size = new System.Drawing.Size(149, 13);
            this.labelWtot.TabIndex = 10;
            this.labelWtot.Text = "Суммарная влажность Wtot";
            // 
            // labelItot
            // 
            this.labelItot.AutoSize = true;
            this.labelItot.Location = new System.Drawing.Point(0, 145);
            this.labelItot.Name = "labelItot";
            this.labelItot.Size = new System.Drawing.Size(85, 13);
            this.labelItot.TabIndex = 9;
            this.labelItot.Text = "Льдистость Itot";
            // 
            // labelDsal
            // 
            this.labelDsal.AutoSize = true;
            this.labelDsal.Location = new System.Drawing.Point(0, 106);
            this.labelDsal.Name = "labelDsal";
            this.labelDsal.Size = new System.Drawing.Size(158, 13);
            this.labelDsal.TabIndex = 8;
            this.labelDsal.Text = "Степень засоленности Dsal %";
            // 
            // labelZG
            // 
            this.labelZG.AutoSize = true;
            this.labelZG.Location = new System.Drawing.Point(0, 58);
            this.labelZG.Name = "labelZG";
            this.labelZG.Size = new System.Drawing.Size(118, 13);
            this.labelZG.TabIndex = 7;
            this.labelZG.Text = "Засоленность грунта:";
            // 
            // labelTG
            // 
            this.labelTG.AutoSize = true;
            this.labelTG.Location = new System.Drawing.Point(0, 13);
            this.labelTG.Name = "labelTG";
            this.labelTG.Size = new System.Drawing.Size(65, 13);
            this.labelTG.TabIndex = 6;
            this.labelTG.Text = "Тип грунта:";
            // 
            // textBoxWm
            // 
            this.textBoxWm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWm.Location = new System.Drawing.Point(3, 246);
            this.textBoxWm.Name = "textBoxWm";
            this.textBoxWm.Size = new System.Drawing.Size(137, 20);
            this.textBoxWm.TabIndex = 5;
            this.textBoxWm.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxWm_Validating);
            this.textBoxWm.Validated += new System.EventHandler(this.textBoxWm_Validated);
            // 
            // textBoxWtot
            // 
            this.textBoxWtot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWtot.Location = new System.Drawing.Point(3, 203);
            this.textBoxWtot.Name = "textBoxWtot";
            this.textBoxWtot.Size = new System.Drawing.Size(137, 20);
            this.textBoxWtot.TabIndex = 4;
            this.textBoxWtot.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxWtot_Validating);
            this.textBoxWtot.Validated += new System.EventHandler(this.textBoxWtot_Validated);
            // 
            // textBoxItot
            // 
            this.textBoxItot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxItot.Location = new System.Drawing.Point(3, 161);
            this.textBoxItot.Name = "textBoxItot";
            this.textBoxItot.Size = new System.Drawing.Size(137, 20);
            this.textBoxItot.TabIndex = 3;
            this.textBoxItot.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxItot_Validating);
            this.textBoxItot.Validated += new System.EventHandler(this.textBoxItot_Validated);
            // 
            // comboBoxZG
            // 
            this.comboBoxZG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxZG.FormattingEnabled = true;
            this.comboBoxZG.Items.AddRange(new object[] {
            "незасоленный",
            "засоленный(морской тип)",
            "засоленный(континентальный тип)"});
            this.comboBoxZG.Location = new System.Drawing.Point(3, 74);
            this.comboBoxZG.Name = "comboBoxZG";
            this.comboBoxZG.Size = new System.Drawing.Size(162, 21);
            this.comboBoxZG.TabIndex = 1;
            this.comboBoxZG.SelectedIndexChanged += new System.EventHandler(this.comboBoxZG_SelectedIndexChanged);
            // 
            // comboBoxTG
            // 
            this.comboBoxTG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTG.FormattingEnabled = true;
            this.comboBoxTG.Items.AddRange(new object[] {
            "Пески разных фракций",
            "Супеси и пылеватые пески",
            "Суглинок",
            "Глины",
            "Торф слаборазложившийся",
            "Торф среднеразложившийся"});
            this.comboBoxTG.Location = new System.Drawing.Point(3, 29);
            this.comboBoxTG.Name = "comboBoxTG";
            this.comboBoxTG.Size = new System.Drawing.Size(161, 21);
            this.comboBoxTG.TabIndex = 0;
            this.comboBoxTG.SelectedIndexChanged += new System.EventHandler(this.comboBoxTG_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(839, 489);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(866, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(30, 13);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 538);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "калькулятор теплофизического параметра «Температура начала замерзания грунта»";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCalculate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoad;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxWm;
        private System.Windows.Forms.TextBox textBoxWtot;
        private System.Windows.Forms.TextBox textBoxItot;
        private System.Windows.Forms.ComboBox comboBoxZG;
        private System.Windows.Forms.ComboBox comboBoxTG;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.Label labelTG;
        private System.Windows.Forms.Label labelZG;
        private System.Windows.Forms.Label labelDsal;
        private System.Windows.Forms.Label labelItot;
        private System.Windows.Forms.Label labelWtot;
        private System.Windows.Forms.Label labelWm;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonExport;
    }
}


namespace CachedProgramsList
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btLog = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.comboFilterOptions = new System.Windows.Forms.ComboBox();
            this.btFilter = new System.Windows.Forms.Button();
            this.btCancelFilter = new System.Windows.Forms.Button();
            this.btTheme = new System.Windows.Forms.Button();
            this.picWorking = new System.Windows.Forms.PictureBox();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lbEntryAmount = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.datagEntries = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkExists = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dateCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateModification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csmPath = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.moreInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWorking)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagEntries)).BeginInit();
            this.csmPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelTop.Controls.Add(this.btLog);
            this.panelTop.Controls.Add(this.lblFilter);
            this.panelTop.Controls.Add(this.txtFilter);
            this.panelTop.Controls.Add(this.comboFilterOptions);
            this.panelTop.Controls.Add(this.btFilter);
            this.panelTop.Controls.Add(this.btCancelFilter);
            this.panelTop.Controls.Add(this.btTheme);
            this.panelTop.Controls.Add(this.picWorking);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(697, 50);
            this.panelTop.TabIndex = 2;
            // 
            // btLog
            // 
            this.btLog.BackColor = System.Drawing.Color.Transparent;
            this.btLog.BackgroundImage = global::CachedProgramsList.Properties.Resources.log;
            this.btLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLog.Location = new System.Drawing.Point(45, 10);
            this.btLog.Name = "btLog";
            this.btLog.Size = new System.Drawing.Size(30, 30);
            this.btLog.TabIndex = 0;
            this.btLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLog.UseVisualStyleBackColor = false;
            this.btLog.Click += new System.EventHandler(this.btLog_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblFilter.Location = new System.Drawing.Point(80, 18);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(32, 13);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Filter:";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(120, 15);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(187, 20);
            this.txtFilter.TabIndex = 3;
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            // 
            // comboFilterOptions
            // 
            this.comboFilterOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFilterOptions.FormattingEnabled = true;
            this.comboFilterOptions.Items.AddRange(new object[] {
            "Name",
            "Creation Date",
            "Modification Date",
            "Path"});
            this.comboFilterOptions.Location = new System.Drawing.Point(320, 15);
            this.comboFilterOptions.Name = "comboFilterOptions";
            this.comboFilterOptions.Size = new System.Drawing.Size(142, 21);
            this.comboFilterOptions.TabIndex = 4;
            // 
            // btFilter
            // 
            this.btFilter.BackgroundImage = global::CachedProgramsList.Properties.Resources.search;
            this.btFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btFilter.Location = new System.Drawing.Point(470, 10);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(30, 30);
            this.btFilter.TabIndex = 2;
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // btCancelFilter
            // 
            this.btCancelFilter.BackColor = System.Drawing.Color.Transparent;
            this.btCancelFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCancelFilter.BackgroundImage")));
            this.btCancelFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCancelFilter.Enabled = false;
            this.btCancelFilter.Location = new System.Drawing.Point(510, 10);
            this.btCancelFilter.Name = "btCancelFilter";
            this.btCancelFilter.Size = new System.Drawing.Size(30, 30);
            this.btCancelFilter.TabIndex = 5;
            this.btCancelFilter.UseVisualStyleBackColor = false;
            this.btCancelFilter.Click += new System.EventHandler(this.btCancelFilter_Click);
            // 
            // btTheme
            // 
            this.btTheme.BackColor = System.Drawing.SystemColors.Control;
            this.btTheme.BackgroundImage = global::CachedProgramsList.Properties.Resources.light;
            this.btTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTheme.Location = new System.Drawing.Point(10, 10);
            this.btTheme.Name = "btTheme";
            this.btTheme.Size = new System.Drawing.Size(30, 30);
            this.btTheme.TabIndex = 6;
            this.btTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTheme.UseVisualStyleBackColor = false;
            this.btTheme.Click += new System.EventHandler(this.btTheme_Click);
            // 
            // picWorking
            // 
            this.picWorking.Image = ((System.Drawing.Image)(resources.GetObject("picWorking.Image")));
            this.picWorking.Location = new System.Drawing.Point(540, 10);
            this.picWorking.Name = "picWorking";
            this.picWorking.Size = new System.Drawing.Size(45, 30);
            this.picWorking.TabIndex = 7;
            this.picWorking.TabStop = false;
            this.picWorking.Visible = false;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panelBottom.Controls.Add(this.lbEntryAmount);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 460);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(697, 30);
            this.panelBottom.TabIndex = 3;
            // 
            // lbEntryAmount
            // 
            this.lbEntryAmount.AutoSize = true;
            this.lbEntryAmount.BackColor = System.Drawing.Color.Transparent;
            this.lbEntryAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbEntryAmount.Location = new System.Drawing.Point(10, 8);
            this.lbEntryAmount.Name = "lbEntryAmount";
            this.lbEntryAmount.Size = new System.Drawing.Size(56, 13);
            this.lbEntryAmount.TabIndex = 8;
            this.lbEntryAmount.Text = "Awaiting...";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.datagEntries);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(697, 410);
            this.panelMain.TabIndex = 1;
            // 
            // datagEntries
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Control;
            this.datagEntries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.datagEntries.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.datagEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagEntries.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagEntries.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagEntries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.datagEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.datagEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtName,
            this.chkExists,
            this.dateCreation,
            this.dateModification,
            this.txtPath});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagEntries.DefaultCellStyle = dataGridViewCellStyle10;
            this.datagEntries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagEntries.EnableHeadersVisualStyles = false;
            this.datagEntries.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.datagEntries.Location = new System.Drawing.Point(0, 0);
            this.datagEntries.Name = "datagEntries";
            this.datagEntries.RowHeadersVisible = false;
            this.datagEntries.Size = new System.Drawing.Size(697, 410);
            this.datagEntries.TabIndex = 0;
            this.datagEntries.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagEntries_CellMouseDown);
            // 
            // txtName
            // 
            this.txtName.FillWeight = 93.27411F;
            this.txtName.HeaderText = "Name";
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Width = 150;
            // 
            // chkExists
            // 
            this.chkExists.FillWeight = 50F;
            this.chkExists.HeaderText = "Exists";
            this.chkExists.Name = "chkExists";
            this.chkExists.ReadOnly = true;
            this.chkExists.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chkExists.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chkExists.Width = 59;
            // 
            // dateCreation
            // 
            dataGridViewCellStyle8.Format = "G";
            dataGridViewCellStyle8.NullValue = null;
            this.dateCreation.DefaultCellStyle = dataGridViewCellStyle8;
            this.dateCreation.FillWeight = 93.27411F;
            this.dateCreation.HeaderText = "Creation Date";
            this.dateCreation.Name = "dateCreation";
            this.dateCreation.ReadOnly = true;
            this.dateCreation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateCreation.Width = 115;
            // 
            // dateModification
            // 
            dataGridViewCellStyle9.Format = "G";
            dataGridViewCellStyle9.NullValue = null;
            this.dateModification.DefaultCellStyle = dataGridViewCellStyle9;
            this.dateModification.FillWeight = 93.27411F;
            this.dateModification.HeaderText = "Modification Date";
            this.dateModification.Name = "dateModification";
            this.dateModification.ReadOnly = true;
            this.dateModification.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dateModification.Width = 115;
            // 
            // txtPath
            // 
            this.txtPath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtPath.FillWeight = 93.27411F;
            this.txtPath.HeaderText = "Path";
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            // 
            // csmPath
            // 
            this.csmPath.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPathToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.moreInfoToolStripMenuItem});
            this.csmPath.Name = "csmPath";
            this.csmPath.Size = new System.Drawing.Size(131, 76);
            // 
            // openPathToolStripMenuItem
            // 
            this.openPathToolStripMenuItem.Name = "openPathToolStripMenuItem";
            this.openPathToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.openPathToolStripMenuItem.Text = "Open path";
            this.openPathToolStripMenuItem.Click += new System.EventHandler(this.openPathToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.openFileToolStripMenuItem.Text = "Open file";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // moreInfoToolStripMenuItem
            // 
            this.moreInfoToolStripMenuItem.Name = "moreInfoToolStripMenuItem";
            this.moreInfoToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.moreInfoToolStripMenuItem.Text = "More info";
            this.moreInfoToolStripMenuItem.Click += new System.EventHandler(this.moreInfoToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 490);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(525, 200);
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CachedProgramsList";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWorking)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagEntries)).EndInit();
            this.csmPath.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLog;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.DataGridView datagEntries;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox comboFilterOptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkExists;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateModification;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPath;
        private System.Windows.Forms.Button btCancelFilter;
        private System.Windows.Forms.ContextMenuStrip csmPath;
        private System.Windows.Forms.ToolStripMenuItem openPathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem moreInfoToolStripMenuItem;
        private System.Windows.Forms.Button btTheme;
        private System.Windows.Forms.PictureBox picWorking;
        private System.Windows.Forms.Label lbEntryAmount;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblFilter;
    }
}

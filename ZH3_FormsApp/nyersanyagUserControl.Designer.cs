namespace ZH3_FormsApp
{
    partial class nyersanyagUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewNyers = new System.Windows.Forms.DataGridView();
            this.nyersanyagIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyersanyagNevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyisegiEgysegIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.egysegarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mennyisegiEgysegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nyersanyagokBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nyersanyagokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxNyers = new System.Windows.Forms.ListBox();
            this.textBoxNyers = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNyers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyersanyagokBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyersanyagokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNyers
            // 
            this.dataGridViewNyers.AllowUserToAddRows = false;
            this.dataGridViewNyers.AllowUserToDeleteRows = false;
            this.dataGridViewNyers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewNyers.AutoGenerateColumns = false;
            this.dataGridViewNyers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNyers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nyersanyagIdDataGridViewTextBoxColumn,
            this.nyersanyagNevDataGridViewTextBoxColumn,
            this.mennyisegiEgysegIdDataGridViewTextBoxColumn,
            this.egysegarDataGridViewTextBoxColumn,
            this.mennyisegiEgysegDataGridViewTextBoxColumn,
            this.receptekDataGridViewTextBoxColumn});
            this.dataGridViewNyers.DataSource = this.nyersanyagokBindingSource1;
            this.dataGridViewNyers.Location = new System.Drawing.Point(233, 3);
            this.dataGridViewNyers.Name = "dataGridViewNyers";
            this.dataGridViewNyers.ReadOnly = true;
            this.dataGridViewNyers.RowTemplate.Height = 25;
            this.dataGridViewNyers.Size = new System.Drawing.Size(845, 471);
            this.dataGridViewNyers.TabIndex = 5;
            // 
            // nyersanyagIdDataGridViewTextBoxColumn
            // 
            this.nyersanyagIdDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagId";
            this.nyersanyagIdDataGridViewTextBoxColumn.HeaderText = "NyersanyagId";
            this.nyersanyagIdDataGridViewTextBoxColumn.Name = "nyersanyagIdDataGridViewTextBoxColumn";
            this.nyersanyagIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nyersanyagNevDataGridViewTextBoxColumn
            // 
            this.nyersanyagNevDataGridViewTextBoxColumn.DataPropertyName = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.HeaderText = "NyersanyagNev";
            this.nyersanyagNevDataGridViewTextBoxColumn.Name = "nyersanyagNevDataGridViewTextBoxColumn";
            this.nyersanyagNevDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mennyisegiEgysegIdDataGridViewTextBoxColumn
            // 
            this.mennyisegiEgysegIdDataGridViewTextBoxColumn.DataPropertyName = "MennyisegiEgysegId";
            this.mennyisegiEgysegIdDataGridViewTextBoxColumn.HeaderText = "MennyisegiEgysegId";
            this.mennyisegiEgysegIdDataGridViewTextBoxColumn.Name = "mennyisegiEgysegIdDataGridViewTextBoxColumn";
            this.mennyisegiEgysegIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // egysegarDataGridViewTextBoxColumn
            // 
            this.egysegarDataGridViewTextBoxColumn.DataPropertyName = "Egysegar";
            this.egysegarDataGridViewTextBoxColumn.HeaderText = "Egysegar";
            this.egysegarDataGridViewTextBoxColumn.Name = "egysegarDataGridViewTextBoxColumn";
            this.egysegarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mennyisegiEgysegDataGridViewTextBoxColumn
            // 
            this.mennyisegiEgysegDataGridViewTextBoxColumn.DataPropertyName = "MennyisegiEgyseg";
            this.mennyisegiEgysegDataGridViewTextBoxColumn.HeaderText = "MennyisegiEgyseg";
            this.mennyisegiEgysegDataGridViewTextBoxColumn.Name = "mennyisegiEgysegDataGridViewTextBoxColumn";
            this.mennyisegiEgysegDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // receptekDataGridViewTextBoxColumn
            // 
            this.receptekDataGridViewTextBoxColumn.DataPropertyName = "Receptek";
            this.receptekDataGridViewTextBoxColumn.HeaderText = "Receptek";
            this.receptekDataGridViewTextBoxColumn.Name = "receptekDataGridViewTextBoxColumn";
            this.receptekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nyersanyagokBindingSource1
            // 
            this.nyersanyagokBindingSource1.DataSource = typeof(ZH3_FormsApp.Models.Nyersanyagok);
            // 
            // nyersanyagokBindingSource
            // 
            this.nyersanyagokBindingSource.DataSource = typeof(ZH3_FormsApp.Models.Nyersanyagok);
            // 
            // listBoxNyers
            // 
            this.listBoxNyers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxNyers.FormattingEnabled = true;
            this.listBoxNyers.ItemHeight = 15;
            this.listBoxNyers.Location = new System.Drawing.Point(2, 35);
            this.listBoxNyers.Name = "listBoxNyers";
            this.listBoxNyers.Size = new System.Drawing.Size(225, 439);
            this.listBoxNyers.TabIndex = 4;
            // 
            // textBoxNyers
            // 
            this.textBoxNyers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxNyers.Location = new System.Drawing.Point(2, 6);
            this.textBoxNyers.Name = "textBoxNyers";
            this.textBoxNyers.Size = new System.Drawing.Size(225, 23);
            this.textBoxNyers.TabIndex = 3;
            this.textBoxNyers.TextChanged += new System.EventHandler(this.textBoxNyersKeres_TextChanged);
            // 
            // nyersanyagUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewNyers);
            this.Controls.Add(this.listBoxNyers);
            this.Controls.Add(this.textBoxNyers);
            this.Name = "nyersanyagUserControl";
            this.Size = new System.Drawing.Size(1081, 488);
            this.Load += new System.EventHandler(this.nyersanyagUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNyers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyersanyagokBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyersanyagokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewNyers;
        private ListBox listBoxNyers;
        private TextBox textBoxNyers;
        private BindingSource nyersanyagokBindingSource;
        private BindingSource nyersanyagokBindingSource1;
        private DataGridViewTextBoxColumn nyersanyagIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nyersanyagNevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyisegiEgysegIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn egysegarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn mennyisegiEgysegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn receptekDataGridViewTextBoxColumn;
    }
}

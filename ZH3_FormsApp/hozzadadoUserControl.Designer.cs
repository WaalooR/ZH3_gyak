namespace ZH3_FormsApp
{
    partial class hozzadadoUserControl
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
            this.listBoxFogas = new System.Windows.Forms.ListBox();
            this.textBoxFogas = new System.Windows.Forms.TextBox();
            this.textBoxNyers = new System.Windows.Forms.TextBox();
            this.listBoxNyers = new System.Windows.Forms.ListBox();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFogas
            // 
            this.listBoxFogas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFogas.FormattingEnabled = true;
            this.listBoxFogas.ItemHeight = 15;
            this.listBoxFogas.Location = new System.Drawing.Point(3, 32);
            this.listBoxFogas.Name = "listBoxFogas";
            this.listBoxFogas.Size = new System.Drawing.Size(237, 439);
            this.listBoxFogas.TabIndex = 0;
            this.listBoxFogas.SelectedIndexChanged += new System.EventHandler(this.listBoxFogas_SelectedIndexChanged);
            // 
            // textBoxFogas
            // 
            this.textBoxFogas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFogas.Location = new System.Drawing.Point(3, 3);
            this.textBoxFogas.Name = "textBoxFogas";
            this.textBoxFogas.Size = new System.Drawing.Size(237, 23);
            this.textBoxFogas.TabIndex = 1;
            this.textBoxFogas.TextChanged += new System.EventHandler(this.textBoxFogas_TextChanged);
            // 
            // textBoxNyers
            // 
            this.textBoxNyers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNyers.Location = new System.Drawing.Point(1023, 3);
            this.textBoxNyers.Name = "textBoxNyers";
            this.textBoxNyers.Size = new System.Drawing.Size(237, 23);
            this.textBoxNyers.TabIndex = 3;
            this.textBoxNyers.TextChanged += new System.EventHandler(this.textBoxNyers_TextChanged);
            // 
            // listBoxNyers
            // 
            this.listBoxNyers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxNyers.FormattingEnabled = true;
            this.listBoxNyers.ItemHeight = 15;
            this.listBoxNyers.Location = new System.Drawing.Point(1023, 32);
            this.listBoxNyers.Name = "listBoxNyers";
            this.listBoxNyers.Size = new System.Drawing.Size(237, 439);
            this.listBoxNyers.TabIndex = 2;
            this.listBoxNyers.SelectedIndexChanged += new System.EventHandler(this.listBoxNyers_SelectedIndexChanged);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(246, 3);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowTemplate.Height = 25;
            this.dataGridViewMain.Size = new System.Drawing.Size(771, 468);
            this.dataGridViewMain.TabIndex = 4;
            // 
            // hozzadadoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.textBoxNyers);
            this.Controls.Add(this.listBoxNyers);
            this.Controls.Add(this.textBoxFogas);
            this.Controls.Add(this.listBoxFogas);
            this.Name = "hozzadadoUserControl";
            this.Size = new System.Drawing.Size(1263, 550);
            this.Load += new System.EventHandler(this.hozzadadoUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxFogas;
        private TextBox textBoxFogas;
        private TextBox textBoxNyers;
        private ListBox listBoxNyers;
        private DataGridView dataGridViewMain;
    }
}

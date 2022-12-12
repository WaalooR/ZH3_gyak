namespace ZH3_FormsApp
{
    partial class fogasUserControl
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
            this.textBoxFogas = new System.Windows.Forms.TextBox();
            this.listBoxFogas = new System.Windows.Forms.ListBox();
            this.dataGridViewFogas = new System.Windows.Forms.DataGridView();
            this.FogasNev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leiras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receptekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fogasokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nyersanyagokBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelFogasNev = new System.Windows.Forms.Label();
            this.textBoxFogasNeve = new System.Windows.Forms.TextBox();
            this.labelFogasLeiras = new System.Windows.Forms.Label();
            this.textBoxFogasLeiras = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFogas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fogasokBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyersanyagokBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFogas
            // 
            this.textBoxFogas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFogas.Location = new System.Drawing.Point(3, 3);
            this.textBoxFogas.Name = "textBoxFogas";
            this.textBoxFogas.Size = new System.Drawing.Size(225, 23);
            this.textBoxFogas.TabIndex = 0;
            this.textBoxFogas.TextChanged += new System.EventHandler(this.textBoxFogasKeres_TextChanged);
            // 
            // listBoxFogas
            // 
            this.listBoxFogas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxFogas.FormattingEnabled = true;
            this.listBoxFogas.ItemHeight = 15;
            this.listBoxFogas.Location = new System.Drawing.Point(3, 32);
            this.listBoxFogas.Name = "listBoxFogas";
            this.listBoxFogas.Size = new System.Drawing.Size(225, 439);
            this.listBoxFogas.TabIndex = 1;
            this.listBoxFogas.SelectedIndexChanged += new System.EventHandler(this.listBoxFogasList_SelectedIndexChanged);
            // 
            // dataGridViewFogas
            // 
            this.dataGridViewFogas.AllowUserToAddRows = false;
            this.dataGridViewFogas.AllowUserToDeleteRows = false;
            this.dataGridViewFogas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFogas.AutoGenerateColumns = false;
            this.dataGridViewFogas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFogas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FogasNev,
            this.Leiras,
            this.receptekDataGridViewTextBoxColumn});
            this.dataGridViewFogas.DataSource = this.fogasokBindingSource;
            this.dataGridViewFogas.Location = new System.Drawing.Point(234, 0);
            this.dataGridViewFogas.Name = "dataGridViewFogas";
            this.dataGridViewFogas.ReadOnly = true;
            this.dataGridViewFogas.RowTemplate.Height = 25;
            this.dataGridViewFogas.Size = new System.Drawing.Size(330, 471);
            this.dataGridViewFogas.TabIndex = 2;
            // 
            // FogasNev
            // 
            this.FogasNev.DataPropertyName = "FogasNev";
            this.FogasNev.HeaderText = "FogasNev";
            this.FogasNev.Name = "FogasNev";
            this.FogasNev.ReadOnly = true;
            // 
            // Leiras
            // 
            this.Leiras.DataPropertyName = "Leiras";
            this.Leiras.HeaderText = "Leiras";
            this.Leiras.Name = "Leiras";
            this.Leiras.ReadOnly = true;
            // 
            // receptekDataGridViewTextBoxColumn
            // 
            this.receptekDataGridViewTextBoxColumn.DataPropertyName = "Receptek";
            this.receptekDataGridViewTextBoxColumn.HeaderText = "Receptek";
            this.receptekDataGridViewTextBoxColumn.Name = "receptekDataGridViewTextBoxColumn";
            this.receptekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fogasokBindingSource
            // 
            this.fogasokBindingSource.DataSource = typeof(ZH3_FormsApp.Models.Fogasok);
            // 
            // nyersanyagokBindingSource
            // 
            this.nyersanyagokBindingSource.DataSource = typeof(ZH3_FormsApp.Models.Nyersanyagok);
            // 
            // labelFogasNev
            // 
            this.labelFogasNev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFogasNev.AutoSize = true;
            this.labelFogasNev.Location = new System.Drawing.Point(570, 11);
            this.labelFogasNev.Name = "labelFogasNev";
            this.labelFogasNev.Size = new System.Drawing.Size(66, 15);
            this.labelFogasNev.TabIndex = 6;
            this.labelFogasNev.Text = "Fogás neve";
            // 
            // textBoxFogasNeve
            // 
            this.textBoxFogasNeve.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFogasNeve.Location = new System.Drawing.Point(570, 32);
            this.textBoxFogasNeve.Name = "textBoxFogasNeve";
            this.textBoxFogasNeve.Size = new System.Drawing.Size(225, 23);
            this.textBoxFogasNeve.TabIndex = 7;
            // 
            // labelFogasLeiras
            // 
            this.labelFogasLeiras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFogasLeiras.AutoSize = true;
            this.labelFogasLeiras.Location = new System.Drawing.Point(570, 71);
            this.labelFogasLeiras.Name = "labelFogasLeiras";
            this.labelFogasLeiras.Size = new System.Drawing.Size(74, 15);
            this.labelFogasLeiras.TabIndex = 8;
            this.labelFogasLeiras.Text = "Fogás leírása";
            // 
            // textBoxFogasLeiras
            // 
            this.textBoxFogasLeiras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFogasLeiras.Location = new System.Drawing.Point(570, 89);
            this.textBoxFogasLeiras.Multiline = true;
            this.textBoxFogasLeiras.Name = "textBoxFogasLeiras";
            this.textBoxFogasLeiras.Size = new System.Drawing.Size(225, 165);
            this.textBoxFogasLeiras.TabIndex = 9;
            // 
            // fogasUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxFogasLeiras);
            this.Controls.Add(this.labelFogasLeiras);
            this.Controls.Add(this.textBoxFogasNeve);
            this.Controls.Add(this.labelFogasNev);
            this.Controls.Add(this.dataGridViewFogas);
            this.Controls.Add(this.listBoxFogas);
            this.Controls.Add(this.textBoxFogas);
            this.Name = "fogasUserControl";
            this.Size = new System.Drawing.Size(798, 485);
            this.Load += new System.EventHandler(this.fogasUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFogas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fogasokBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyersanyagokBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxFogas;
        private ListBox listBoxFogas;
        private DataGridView dataGridViewFogas;
        private Label labelFogasNev;
        private TextBox textBoxFogasNeve;
        private Label labelFogasLeiras;
        private TextBox textBoxFogasLeiras;
        private BindingSource fogasokBindingSource;
        private BindingSource nyersanyagokBindingSource;
        private DataGridViewTextBoxColumn FogasNev;
        private DataGridViewTextBoxColumn Leiras;
        private DataGridViewTextBoxColumn receptekDataGridViewTextBoxColumn;
    }
}

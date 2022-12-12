namespace ZH3_FormsApp
{
    partial class Form1
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonFogas = new System.Windows.Forms.Button();
            this.buttonNyersanyag = new System.Windows.Forms.Button();
            this.buttonSzerkeszt = new System.Windows.Forms.Button();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.Location = new System.Drawing.Point(124, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(664, 426);
            this.panelMain.TabIndex = 1;
            // 
            // buttonFogas
            // 
            this.buttonFogas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFogas.Location = new System.Drawing.Point(12, 12);
            this.buttonFogas.Name = "buttonFogas";
            this.buttonFogas.Size = new System.Drawing.Size(106, 41);
            this.buttonFogas.TabIndex = 2;
            this.buttonFogas.Text = "Fogások megjelenítése";
            this.buttonFogas.UseVisualStyleBackColor = true;
            this.buttonFogas.Click += new System.EventHandler(this.buttonFogas_Click);
            // 
            // buttonNyersanyag
            // 
            this.buttonNyersanyag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNyersanyag.Location = new System.Drawing.Point(12, 59);
            this.buttonNyersanyag.Name = "buttonNyersanyag";
            this.buttonNyersanyag.Size = new System.Drawing.Size(106, 41);
            this.buttonNyersanyag.TabIndex = 3;
            this.buttonNyersanyag.Text = "Nyersanyagok megjelenítése";
            this.buttonNyersanyag.UseVisualStyleBackColor = true;
            this.buttonNyersanyag.Click += new System.EventHandler(this.buttonNyersanyag_Click);
            // 
            // buttonSzerkeszt
            // 
            this.buttonSzerkeszt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSzerkeszt.Location = new System.Drawing.Point(12, 106);
            this.buttonSzerkeszt.Name = "buttonSzerkeszt";
            this.buttonSzerkeszt.Size = new System.Drawing.Size(106, 41);
            this.buttonSzerkeszt.TabIndex = 4;
            this.buttonSzerkeszt.Text = "Receptek szerkesztése";
            this.buttonSzerkeszt.UseVisualStyleBackColor = true;
            this.buttonSzerkeszt.Click += new System.EventHandler(this.buttonSzerkeszt_Click);
            // 
            // buttonExcel
            // 
            this.buttonExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExcel.Location = new System.Drawing.Point(12, 397);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(106, 41);
            this.buttonExcel.TabIndex = 5;
            this.buttonExcel.Text = "Excel megnyitása ";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExcel);
            this.Controls.Add(this.buttonSzerkeszt);
            this.Controls.Add(this.buttonNyersanyag);
            this.Controls.Add(this.buttonFogas);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelMain;
        private Button buttonFogas;
        private Button buttonNyersanyag;
        private Button buttonSzerkeszt;
        private Button buttonExcel;
    }
}
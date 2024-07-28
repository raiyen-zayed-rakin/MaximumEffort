namespace MaximumEffort___Task_Manager.Pages
{
    partial class ViewPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPage));
            this.dgvTaskList = new System.Windows.Forms.DataGridView();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtboxsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lblviewtask = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.PictureBox();
            this.btnBack = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTaskList
            // 
            this.dgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskList.Location = new System.Drawing.Point(80, 199);
            this.dgvTaskList.Name = "dgvTaskList";
            this.dgvTaskList.RowHeadersWidth = 51;
            this.dgvTaskList.RowTemplate.Height = 24;
            this.dgvTaskList.Size = new System.Drawing.Size(1048, 290);
            this.dgvTaskList.TabIndex = 34;
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(1090, 148);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(38, 34);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 33;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // txtboxsearch
            // 
            this.txtboxsearch.Animated = true;
            this.txtboxsearch.BorderRadius = 10;
            this.txtboxsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxsearch.DefaultText = "";
            this.txtboxsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxsearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtboxsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxsearch.Location = new System.Drawing.Point(248, 148);
            this.txtboxsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxsearch.Name = "txtboxsearch";
            this.txtboxsearch.PasswordChar = '\0';
            this.txtboxsearch.PlaceholderText = "#####";
            this.txtboxsearch.SelectedText = "";
            this.txtboxsearch.Size = new System.Drawing.Size(836, 34);
            this.txtboxsearch.TabIndex = 32;
            this.txtboxsearch.TextChanged += new System.EventHandler(this.txtboxsearch_TextChanged);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Monospac821 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(74, 148);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(168, 34);
            this.lblsearch.TabIndex = 31;
            this.lblsearch.Text = "Search  :";
            // 
            // lblviewtask
            // 
            this.lblviewtask.AutoSize = true;
            this.lblviewtask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.lblviewtask.Font = new System.Drawing.Font("Monospac821 BT", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblviewtask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(11)))));
            this.lblviewtask.Location = new System.Drawing.Point(71, 70);
            this.lblviewtask.Name = "lblviewtask";
            this.lblviewtask.Size = new System.Drawing.Size(360, 51);
            this.lblviewtask.TabIndex = 30;
            this.lblviewtask.Text = "VIEW ALL TASK";
            // 
            // btnexit
            // 
            this.btnexit.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(1106, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(64, 58);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnexit.TabIndex = 35;
            this.btnexit.TabStop = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageRotate = 0F;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBack.Size = new System.Drawing.Size(64, 58);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 36;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.dgvTaskList);
            this.Controls.Add(this.guna2CirclePictureBox2);
            this.Controls.Add(this.txtboxsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.lblviewtask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPage";
            this.Load += new System.EventHandler(this.ViewPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTaskList;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtboxsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lblviewtask;
        private System.Windows.Forms.PictureBox btnexit;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnBack;
    }
}
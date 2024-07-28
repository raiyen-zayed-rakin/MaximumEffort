namespace MaximumEffort___Task_Manager.Pages
{
    partial class DeletePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletePage));
            this.btnback = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnexit = new System.Windows.Forms.PictureBox();
            this.lbladdtask = new System.Windows.Forms.Label();
            this.btnclear = new Guna.UI2.WinForms.Guna2Button();
            this.btndelete = new Guna.UI2.WinForms.Guna2Button();
            this.txtboxtaskid = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbltaskid = new System.Windows.Forms.Label();
            this.txtboxtaskname = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbltaskname = new System.Windows.Forms.Label();
            this.txtboxdescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.txtboxdate = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.btngroupradio = new Guna.UI2.WinForms.Guna2GroupBox();
            this.radioundone = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radiodone = new Guna.UI2.WinForms.Guna2RadioButton();
            this.lblsearch = new System.Windows.Forms.Label();
            this.dgvTaskList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            this.btngroupradio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.ImageRotate = 0F;
            this.btnback.Location = new System.Drawing.Point(12, 12);
            this.btnback.Name = "btnback";
            this.btnback.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnback.Size = new System.Drawing.Size(64, 58);
            this.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnback.TabIndex = 5;
            this.btnback.TabStop = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
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
            this.btnexit.TabIndex = 6;
            this.btnexit.TabStop = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbladdtask
            // 
            this.lbladdtask.AutoSize = true;
            this.lbladdtask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.lbladdtask.Font = new System.Drawing.Font("Monospac821 BT", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdtask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(11)))));
            this.lbladdtask.Location = new System.Drawing.Point(82, 51);
            this.lbladdtask.Name = "lbladdtask";
            this.lbladdtask.Size = new System.Drawing.Size(308, 51);
            this.lbladdtask.TabIndex = 11;
            this.lbladdtask.Text = "DELETE TASK";
            // 
            // btnclear
            // 
            this.btnclear.BorderRadius = 20;
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(11)))));
            this.btnclear.Font = new System.Drawing.Font("Monospac821 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.btnclear.Location = new System.Drawing.Point(297, 665);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(240, 52);
            this.btnclear.TabIndex = 38;
            this.btnclear.Text = "CLEAR";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.BorderRadius = 20;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(11)))));
            this.btndelete.Font = new System.Drawing.Font("Monospac821 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.btndelete.Location = new System.Drawing.Point(50, 665);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(223, 52);
            this.btndelete.TabIndex = 37;
            this.btndelete.Text = "DELETE";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtboxtaskid
            // 
            this.txtboxtaskid.Animated = true;
            this.txtboxtaskid.BorderRadius = 10;
            this.txtboxtaskid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxtaskid.DefaultText = "";
            this.txtboxtaskid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxtaskid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxtaskid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxtaskid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxtaskid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxtaskid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtboxtaskid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxtaskid.Location = new System.Drawing.Point(297, 116);
            this.txtboxtaskid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxtaskid.Name = "txtboxtaskid";
            this.txtboxtaskid.PasswordChar = '\0';
            this.txtboxtaskid.PlaceholderText = "Auto-generated";
            this.txtboxtaskid.ReadOnly = true;
            this.txtboxtaskid.SelectedText = "";
            this.txtboxtaskid.Size = new System.Drawing.Size(240, 34);
            this.txtboxtaskid.TabIndex = 40;
            // 
            // lbltaskid
            // 
            this.lbltaskid.AutoSize = true;
            this.lbltaskid.Font = new System.Drawing.Font("Monospac821 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaskid.Location = new System.Drawing.Point(55, 116);
            this.lbltaskid.Name = "lbltaskid";
            this.lbltaskid.Size = new System.Drawing.Size(236, 34);
            this.lbltaskid.TabIndex = 39;
            this.lbltaskid.Text = "Task ID     :";
            // 
            // txtboxtaskname
            // 
            this.txtboxtaskname.Animated = true;
            this.txtboxtaskname.BorderRadius = 10;
            this.txtboxtaskname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxtaskname.DefaultText = "";
            this.txtboxtaskname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxtaskname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxtaskname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxtaskname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxtaskname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxtaskname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtboxtaskname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxtaskname.Location = new System.Drawing.Point(297, 173);
            this.txtboxtaskname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxtaskname.Name = "txtboxtaskname";
            this.txtboxtaskname.PasswordChar = '\0';
            this.txtboxtaskname.PlaceholderText = "Heading name";
            this.txtboxtaskname.SelectedText = "";
            this.txtboxtaskname.Size = new System.Drawing.Size(240, 34);
            this.txtboxtaskname.TabIndex = 42;
            // 
            // lbltaskname
            // 
            this.lbltaskname.AutoSize = true;
            this.lbltaskname.Font = new System.Drawing.Font("Monospac821 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaskname.Location = new System.Drawing.Point(55, 173);
            this.lbltaskname.Name = "lbltaskname";
            this.lbltaskname.Size = new System.Drawing.Size(236, 34);
            this.lbltaskname.TabIndex = 41;
            this.lbltaskname.Text = "Task Name   :";
            // 
            // txtboxdescription
            // 
            this.txtboxdescription.Animated = true;
            this.txtboxdescription.BorderRadius = 20;
            this.txtboxdescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxdescription.DefaultText = "";
            this.txtboxdescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxdescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxdescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxdescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxdescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxdescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtboxdescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxdescription.Location = new System.Drawing.Point(60, 285);
            this.txtboxdescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxdescription.Name = "txtboxdescription";
            this.txtboxdescription.PasswordChar = '\0';
            this.txtboxdescription.PlaceholderText = "Your description";
            this.txtboxdescription.SelectedText = "";
            this.txtboxdescription.Size = new System.Drawing.Size(477, 179);
            this.txtboxdescription.TabIndex = 44;
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Monospac821 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(54, 233);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(236, 34);
            this.lbldescription.TabIndex = 43;
            this.lbldescription.Text = "Description :";
            // 
            // txtboxdate
            // 
            this.txtboxdate.Animated = true;
            this.txtboxdate.BorderRadius = 10;
            this.txtboxdate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxdate.DefaultText = "";
            this.txtboxdate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtboxdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtboxdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxdate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtboxdate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtboxdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtboxdate.Location = new System.Drawing.Point(297, 501);
            this.txtboxdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxdate.Name = "txtboxdate";
            this.txtboxdate.PasswordChar = '\0';
            this.txtboxdate.PlaceholderText = "DD/MM/YY";
            this.txtboxdate.SelectedText = "";
            this.txtboxdate.Size = new System.Drawing.Size(240, 34);
            this.txtboxdate.TabIndex = 46;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Monospac821 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(54, 501);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(236, 34);
            this.lbldate.TabIndex = 45;
            this.lbldate.Text = "Task Date   :";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Monospac821 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(55, 565);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(236, 34);
            this.lblstatus.TabIndex = 47;
            this.lblstatus.Text = "Task Status :";
            // 
            // btngroupradio
            // 
            this.btngroupradio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.btngroupradio.Controls.Add(this.radioundone);
            this.btngroupradio.Controls.Add(this.radiodone);
            this.btngroupradio.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.btngroupradio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.btngroupradio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btngroupradio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.btngroupradio.Location = new System.Drawing.Point(297, 565);
            this.btngroupradio.Name = "btngroupradio";
            this.btngroupradio.Size = new System.Drawing.Size(233, 75);
            this.btngroupradio.TabIndex = 48;
            // 
            // radioundone
            // 
            this.radioundone.AutoSize = true;
            this.radioundone.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioundone.CheckedState.BorderThickness = 0;
            this.radioundone.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioundone.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioundone.CheckedState.InnerOffset = -4;
            this.radioundone.Font = new System.Drawing.Font("Monospac821 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioundone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(11)))));
            this.radioundone.Location = new System.Drawing.Point(16, 31);
            this.radioundone.Name = "radioundone";
            this.radioundone.Size = new System.Drawing.Size(138, 38);
            this.radioundone.TabIndex = 24;
            this.radioundone.Text = "Undone";
            this.radioundone.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioundone.UncheckedState.BorderThickness = 2;
            this.radioundone.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioundone.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radiodone
            // 
            this.radiodone.AutoSize = true;
            this.radiodone.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radiodone.CheckedState.BorderThickness = 0;
            this.radiodone.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radiodone.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radiodone.CheckedState.InnerOffset = -4;
            this.radiodone.Font = new System.Drawing.Font("Monospac821 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiodone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(1)))), ((int)(((byte)(11)))));
            this.radiodone.Location = new System.Drawing.Point(16, -9);
            this.radiodone.Name = "radiodone";
            this.radiodone.Size = new System.Drawing.Size(104, 38);
            this.radiodone.TabIndex = 23;
            this.radiodone.Text = "Done";
            this.radiodone.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radiodone.UncheckedState.BorderThickness = 2;
            this.radiodone.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radiodone.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Monospac821 BT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(568, 116);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(287, 34);
            this.lblsearch.TabIndex = 49;
            this.lblsearch.Text = "Live Task View :";
            // 
            // dgvTaskList
            // 
            this.dgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaskList.Location = new System.Drawing.Point(574, 173);
            this.dgvTaskList.Name = "dgvTaskList";
            this.dgvTaskList.RowHeadersWidth = 51;
            this.dgvTaskList.RowTemplate.Height = 24;
            this.dgvTaskList.Size = new System.Drawing.Size(553, 545);
            this.dgvTaskList.TabIndex = 50;
            this.dgvTaskList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaskList_CellContentClick);
            this.dgvTaskList.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTaskList_RowHeaderMouseClick);
            // 
            // DeletePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(234)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.dgvTaskList);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btngroupradio);
            this.Controls.Add(this.txtboxdate);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.txtboxdescription);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.txtboxtaskname);
            this.Controls.Add(this.lbltaskname);
            this.Controls.Add(this.txtboxtaskid);
            this.Controls.Add(this.lbltaskid);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.lbladdtask);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeletePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeletePage";
            this.Load += new System.EventHandler(this.DeletePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            this.btngroupradio.ResumeLayout(false);
            this.btngroupradio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaskList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox btnback;
        private System.Windows.Forms.PictureBox btnexit;
        private System.Windows.Forms.Label lbladdtask;
        private Guna.UI2.WinForms.Guna2Button btnclear;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private Guna.UI2.WinForms.Guna2TextBox txtboxtaskid;
        private System.Windows.Forms.Label lbltaskid;
        private Guna.UI2.WinForms.Guna2TextBox txtboxtaskname;
        private System.Windows.Forms.Label lbltaskname;
        private Guna.UI2.WinForms.Guna2TextBox txtboxdescription;
        private System.Windows.Forms.Label lbldescription;
        private Guna.UI2.WinForms.Guna2TextBox txtboxdate;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblstatus;
        private Guna.UI2.WinForms.Guna2GroupBox btngroupradio;
        private Guna.UI2.WinForms.Guna2RadioButton radioundone;
        private Guna.UI2.WinForms.Guna2RadioButton radiodone;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.DataGridView dgvTaskList;
    }
}
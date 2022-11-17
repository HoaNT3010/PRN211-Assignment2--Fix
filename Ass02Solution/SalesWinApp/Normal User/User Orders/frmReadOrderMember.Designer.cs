namespace SalesWinApp.Normal_User.User_Orders
{
    partial class frmReadOrderMember
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
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMemberEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetails.Location = new System.Drawing.Point(44, 232);
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.RowHeadersWidth = 51;
            this.dgvOrderDetails.RowTemplate.Height = 29;
            this.dgvOrderDetails.Size = new System.Drawing.Size(692, 225);
            this.dgvOrderDetails.TabIndex = 86;
            this.dgvOrderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellClick);
            this.dgvOrderDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetails_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 92;
            this.label4.Text = "Order Details";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(221, 498);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(120, 35);
            this.btnRead.TabIndex = 91;
            this.btnRead.Text = "Details";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(431, 498);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 35);
            this.btnClose.TabIndex = 90;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(528, 113);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.ReadOnly = true;
            this.txtShippedDate.Size = new System.Drawing.Size(208, 27);
            this.txtShippedDate.TabIndex = 85;
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(528, 64);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.ReadOnly = true;
            this.txtRequiredDate.Size = new System.Drawing.Size(208, 27);
            this.txtRequiredDate.TabIndex = 84;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(528, 16);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(208, 27);
            this.txtOrderDate.TabIndex = 83;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(415, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 82;
            this.label10.Text = "Order Date";
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(528, 163);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.ReadOnly = true;
            this.txtFreight.Size = new System.Drawing.Size(208, 27);
            this.txtFreight.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "Freight";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 79;
            this.label8.Text = "Shipped Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(415, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 78;
            this.label9.Text = "Required Date";
            // 
            // txtMemberEmail
            // 
            this.txtMemberEmail.Location = new System.Drawing.Point(159, 116);
            this.txtMemberEmail.Name = "txtMemberEmail";
            this.txtMemberEmail.ReadOnly = true;
            this.txtMemberEmail.Size = new System.Drawing.Size(208, 27);
            this.txtMemberEmail.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Member Email";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(159, 67);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(208, 27);
            this.txtMemberID.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Member ID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(159, 19);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(208, 27);
            this.txtOrderID.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "Order ID";
            // 
            // frmReadOrderMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.dgvOrderDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMemberEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label1);
            this.Name = "frmReadOrderMember";
            this.Text = "View Member\'s Order Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReadOrderMember_FormClosing);
            this.Load += new System.EventHandler(this.frmReadOrderMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvOrderDetails;
        private Label label4;
        private Button btnRead;
        private Button btnClose;
        private TextBox txtShippedDate;
        private TextBox txtRequiredDate;
        private TextBox txtOrderDate;
        private Label label10;
        private TextBox txtFreight;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtMemberEmail;
        private Label label3;
        private TextBox txtMemberID;
        private Label label2;
        private TextBox txtOrderID;
        private Label label1;
    }
}
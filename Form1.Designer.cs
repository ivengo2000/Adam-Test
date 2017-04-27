namespace AdamTest
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbResponse = new System.Windows.Forms.Label();
            this.recipient_category_id = new System.Windows.Forms.TextBox();
            this.tbPostedLink = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.individual_flg = new System.Windows.Forms.CheckBox();
            this.tbFax = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAreaCode = new System.Windows.Forms.TextBox();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.tbState = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbAddress2 = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.lbResponse);
            this.groupBox1.Controls.Add(this.recipient_category_id);
            this.groupBox1.Controls.Add(this.tbPostedLink);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.individual_flg);
            this.groupBox1.Controls.Add(this.tbFax);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbAreaCode);
            this.groupBox1.Controls.Add(this.tbZipCode);
            this.groupBox1.Controls.Add(this.tbState);
            this.groupBox1.Controls.Add(this.tbCity);
            this.groupBox1.Controls.Add(this.tbAddress2);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 394);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADAM Form test: ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(117, 352);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbResponse
            // 
            this.lbResponse.Location = new System.Drawing.Point(25, 318);
            this.lbResponse.Name = "lbResponse";
            this.lbResponse.Size = new System.Drawing.Size(425, 23);
            this.lbResponse.TabIndex = 23;
            // 
            // recipient_category_id
            // 
            this.recipient_category_id.Location = new System.Drawing.Point(25, 232);
            this.recipient_category_id.Name = "recipient_category_id";
            this.recipient_category_id.Size = new System.Drawing.Size(195, 20);
            this.recipient_category_id.TabIndex = 22;
            this.recipient_category_id.Text = "3000";
            // 
            // tbPostedLink
            // 
            this.tbPostedLink.Location = new System.Drawing.Point(25, 277);
            this.tbPostedLink.Name = "tbPostedLink";
            this.tbPostedLink.Size = new System.Drawing.Size(425, 20);
            this.tbPostedLink.TabIndex = 21;
            this.tbPostedLink.Text = "http://adamdev.risk.regn.net/subscriber";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(25, 352);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 20;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // individual_flg
            // 
            this.individual_flg.AutoSize = true;
            this.individual_flg.Checked = true;
            this.individual_flg.CheckState = System.Windows.Forms.CheckState.Checked;
            this.individual_flg.Location = new System.Drawing.Point(25, 32);
            this.individual_flg.Name = "individual_flg";
            this.individual_flg.Size = new System.Drawing.Size(79, 17);
            this.individual_flg.TabIndex = 19;
            this.individual_flg.Text = "Is Business";
            this.individual_flg.UseVisualStyleBackColor = true;
            // 
            // tbFax
            // 
            this.tbFax.Location = new System.Drawing.Point(255, 191);
            this.tbFax.Name = "tbFax";
            this.tbFax.Size = new System.Drawing.Size(195, 20);
            this.tbFax.TabIndex = 18;
            this.tbFax.Text = "8138904530";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(25, 192);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(195, 20);
            this.tbEmail.TabIndex = 17;
            this.tbEmail.Text = "ddc@gmail.com";
            // 
            // tbAreaCode
            // 
            this.tbAreaCode.Location = new System.Drawing.Point(255, 155);
            this.tbAreaCode.MaxLength = 3;
            this.tbAreaCode.Name = "tbAreaCode";
            this.tbAreaCode.Size = new System.Drawing.Size(195, 20);
            this.tbAreaCode.TabIndex = 16;
            this.tbAreaCode.Text = "321";
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(25, 155);
            this.tbZipCode.MaxLength = 5;
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(195, 20);
            this.tbZipCode.TabIndex = 15;
            this.tbZipCode.Text = "32907";
            // 
            // tbState
            // 
            this.tbState.Location = new System.Drawing.Point(255, 116);
            this.tbState.MaxLength = 2;
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(195, 20);
            this.tbState.TabIndex = 14;
            this.tbState.Text = "FL";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(25, 116);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(195, 20);
            this.tbCity.TabIndex = 13;
            this.tbCity.Text = "Palm Bay";
            // 
            // tbAddress2
            // 
            this.tbAddress2.Location = new System.Drawing.Point(255, 74);
            this.tbAddress2.Name = "tbAddress2";
            this.tbAddress2.Size = new System.Drawing.Size(195, 20);
            this.tbAddress2.TabIndex = 12;
            this.tbAddress2.Text = "1807 Glenwood St";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(25, 74);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(195, 20);
            this.tbAddress.TabIndex = 11;
            this.tbAddress.Text = "1807 Glenwood St";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(255, 32);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(195, 20);
            this.tbName.TabIndex = 10;
            this.tbName.Text = "John Doe Corporation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 418);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.CheckBox individual_flg;
        private System.Windows.Forms.TextBox tbFax;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAreaCode;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.TextBox tbState;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbAddress2;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPostedLink;
        private System.Windows.Forms.TextBox recipient_category_id;
        private System.Windows.Forms.Label lbResponse;
        private System.Windows.Forms.Button btnReset;
    }
}


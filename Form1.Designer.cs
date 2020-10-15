namespace BHWDI6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.Need = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmentor = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblmajor = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblbio = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            this.textBio = new System.Windows.Forms.TextBox();
            this.buttonJOIN = new System.Windows.Forms.Button();
            this.DataBox = new System.Windows.Forms.DataGridView();
            this.textMentor = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 94);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(230, 258);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(284, 22);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Need
            // 
            this.Need.AutoSize = true;
            this.Need.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Need.Location = new System.Drawing.Point(296, 150);
            this.Need.Name = "Need";
            this.Need.Size = new System.Drawing.Size(123, 24);
            this.Need.TabIndex = 2;
            this.Need.Text = "Need a mentor?";
            this.Need.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "You can find our enlisted volunters here:";
            // 
            // lblmentor
            // 
            this.lblmentor.AutoSize = true;
            this.lblmentor.Location = new System.Drawing.Point(662, 190);
            this.lblmentor.Name = "lblmentor";
            this.lblmentor.Size = new System.Drawing.Size(73, 17);
            this.lblmentor.TabIndex = 5;
            this.lblmentor.Text = "Mentor_ID";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1087, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 94);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(706, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "willing to be a helping hand?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(817, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Join our Team!";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(671, 263);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(49, 17);
            this.lblname.TabIndex = 11;
            this.lblname.Text = "Name:";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(657, 340);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(63, 17);
            this.lblemail.TabIndex = 12;
            this.lblemail.Text = "Email ID:";
            // 
            // lblmajor
            // 
            this.lblmajor.AutoSize = true;
            this.lblmajor.Location = new System.Drawing.Point(671, 401);
            this.lblmajor.Name = "lblmajor";
            this.lblmajor.Size = new System.Drawing.Size(47, 17);
            this.lblmajor.TabIndex = 13;
            this.lblmajor.Text = "Major:";
            // 
            // lblbio
            // 
            this.lblbio.AutoSize = true;
            this.lblbio.Location = new System.Drawing.Point(687, 452);
            this.lblbio.Name = "lblbio";
            this.lblbio.Size = new System.Drawing.Size(31, 17);
            this.lblbio.TabIndex = 14;
            this.lblbio.Text = "BIO";
            this.lblbio.Click += new System.EventHandler(this.BIO_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(769, 258);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(287, 22);
            this.textName.TabIndex = 15;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(769, 340);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(287, 22);
            this.textEmail.TabIndex = 16;
            // 
            // cmbMajor
            // 
            this.cmbMajor.FormattingEnabled = true;
            this.cmbMajor.Items.AddRange(new object[] {
            "Computer Science",
            "Mechanical Engg",
            "Business Administration"});
            this.cmbMajor.Location = new System.Drawing.Point(769, 394);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(289, 24);
            this.cmbMajor.TabIndex = 19;
            // 
            // textBio
            // 
            this.textBio.Location = new System.Drawing.Point(769, 449);
            this.textBio.Multiline = true;
            this.textBio.Name = "textBio";
            this.textBio.Size = new System.Drawing.Size(401, 190);
            this.textBio.TabIndex = 20;
            // 
            // buttonJOIN
            // 
            this.buttonJOIN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonJOIN.Location = new System.Drawing.Point(959, 655);
            this.buttonJOIN.Name = "buttonJOIN";
            this.buttonJOIN.Size = new System.Drawing.Size(75, 23);
            this.buttonJOIN.TabIndex = 21;
            this.buttonJOIN.Text = "Join!";
            this.buttonJOIN.UseVisualStyleBackColor = true;
            this.buttonJOIN.Click += new System.EventHandler(this.buttonJOIN_Click);
            // 
            // DataBox
            // 
            this.DataBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataBox.Location = new System.Drawing.Point(186, 352);
            this.DataBox.Name = "DataBox";
            this.DataBox.RowHeadersWidth = 51;
            this.DataBox.RowTemplate.Height = 24;
            this.DataBox.Size = new System.Drawing.Size(378, 215);
            this.DataBox.TabIndex = 22;
            this.DataBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textMentor
            // 
            this.textMentor.Location = new System.Drawing.Point(769, 190);
            this.textMentor.Name = "textMentor";
            this.textMentor.ReadOnly = true;
            this.textMentor.Size = new System.Drawing.Size(188, 22);
            this.textMentor.TabIndex = 23;
            this.textMentor.TextChanged += new System.EventHandler(this.textMentor_TextChanged);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(31, 604);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(48, 35);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 25;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 690);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.textMentor);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.buttonJOIN);
            this.Controls.Add(this.textBio);
            this.Controls.Add(this.cmbMajor);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.lblbio);
            this.Controls.Add(this.lblmajor);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblmentor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Need);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label Need;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmentor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblmajor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblbio;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.ComboBox cmbMajor;
        private System.Windows.Forms.TextBox textBio;
        private System.Windows.Forms.Button buttonJOIN;
        private System.Windows.Forms.DataGridView DataBox;
        private System.Windows.Forms.TextBox textMentor;
        private System.Windows.Forms.PictureBox exit;
    }
}


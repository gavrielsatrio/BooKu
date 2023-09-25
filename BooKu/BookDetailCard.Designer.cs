namespace BooKu
{
    partial class BookDetailCard
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelBookInfo = new System.Windows.Forms.Panel();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblFirstPublished = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.panelBookCoversContainer = new System.Windows.Forms.Panel();
            this.panelBookCoversImg = new System.Windows.Forms.Panel();
            this.picBoxBookCovers = new System.Windows.Forms.PictureBox();
            this.tableLayoutBookCoversControl = new System.Windows.Forms.TableLayoutPanel();
            this.btnNextBookCovers = new System.Windows.Forms.Button();
            this.btnPrevBookCovers = new System.Windows.Forms.Button();
            this.txtDescValue = new System.Windows.Forms.RichTextBox();
            this.txtSubjectValue = new System.Windows.Forms.RichTextBox();
            this.panelBookInfo.SuspendLayout();
            this.panelBookCoversContainer.SuspendLayout();
            this.panelBookCoversImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBookCovers)).BeginInit();
            this.tableLayoutBookCoversControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(608, 30);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Boaty McBoatface";
            // 
            // panelBookInfo
            // 
            this.panelBookInfo.Controls.Add(this.txtSubjectValue);
            this.panelBookInfo.Controls.Add(this.txtDescValue);
            this.panelBookInfo.Controls.Add(this.lblSubject);
            this.panelBookInfo.Controls.Add(this.lblDesc);
            this.panelBookInfo.Controls.Add(this.lblFirstPublished);
            this.panelBookInfo.Controls.Add(this.lblAuthor);
            this.panelBookInfo.Controls.Add(this.panelBookCoversContainer);
            this.panelBookInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBookInfo.Location = new System.Drawing.Point(16, 46);
            this.panelBookInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelBookInfo.Name = "panelBookInfo";
            this.panelBookInfo.Padding = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.panelBookInfo.Size = new System.Drawing.Size(608, 260);
            this.panelBookInfo.TabIndex = 5;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(0, 158);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(50, 14);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Subjects";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(0, 66);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(66, 14);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "Description";
            // 
            // lblFirstPublished
            // 
            this.lblFirstPublished.AutoSize = true;
            this.lblFirstPublished.Location = new System.Drawing.Point(0, 32);
            this.lblFirstPublished.Margin = new System.Windows.Forms.Padding(0, 2, 0, 4);
            this.lblFirstPublished.Name = "lblFirstPublished";
            this.lblFirstPublished.Size = new System.Drawing.Size(112, 14);
            this.lblFirstPublished.TabIndex = 4;
            this.lblFirstPublished.Text = "first published: 2016";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(189)))), ((int)(((byte)(86)))));
            this.lblAuthor.Location = new System.Drawing.Point(0, 16);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(91, 14);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "by Baron Barton";
            // 
            // panelBookCoversContainer
            // 
            this.panelBookCoversContainer.Controls.Add(this.panelBookCoversImg);
            this.panelBookCoversContainer.Controls.Add(this.tableLayoutBookCoversControl);
            this.panelBookCoversContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBookCoversContainer.Location = new System.Drawing.Point(428, 16);
            this.panelBookCoversContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelBookCoversContainer.Name = "panelBookCoversContainer";
            this.panelBookCoversContainer.Size = new System.Drawing.Size(180, 244);
            this.panelBookCoversContainer.TabIndex = 3;
            // 
            // panelBookCoversImg
            // 
            this.panelBookCoversImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBookCoversImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBookCoversImg.Controls.Add(this.picBoxBookCovers);
            this.panelBookCoversImg.Location = new System.Drawing.Point(4, 4);
            this.panelBookCoversImg.Margin = new System.Windows.Forms.Padding(4);
            this.panelBookCoversImg.Name = "panelBookCoversImg";
            this.panelBookCoversImg.Size = new System.Drawing.Size(172, 198);
            this.panelBookCoversImg.TabIndex = 1;
            // 
            // picBoxBookCovers
            // 
            this.picBoxBookCovers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxBookCovers.Location = new System.Drawing.Point(0, 0);
            this.picBoxBookCovers.Name = "picBoxBookCovers";
            this.picBoxBookCovers.Size = new System.Drawing.Size(170, 196);
            this.picBoxBookCovers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxBookCovers.TabIndex = 0;
            this.picBoxBookCovers.TabStop = false;
            // 
            // tableLayoutBookCoversControl
            // 
            this.tableLayoutBookCoversControl.ColumnCount = 2;
            this.tableLayoutBookCoversControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutBookCoversControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutBookCoversControl.Controls.Add(this.btnNextBookCovers, 0, 0);
            this.tableLayoutBookCoversControl.Controls.Add(this.btnPrevBookCovers, 0, 0);
            this.tableLayoutBookCoversControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutBookCoversControl.Location = new System.Drawing.Point(0, 206);
            this.tableLayoutBookCoversControl.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutBookCoversControl.Name = "tableLayoutBookCoversControl";
            this.tableLayoutBookCoversControl.RowCount = 1;
            this.tableLayoutBookCoversControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutBookCoversControl.Size = new System.Drawing.Size(180, 38);
            this.tableLayoutBookCoversControl.TabIndex = 0;
            // 
            // btnNextBookCovers
            // 
            this.btnNextBookCovers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(189)))), ((int)(((byte)(86)))));
            this.btnNextBookCovers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextBookCovers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(118)))), ((int)(((byte)(62)))));
            this.btnNextBookCovers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextBookCovers.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextBookCovers.ForeColor = System.Drawing.Color.White;
            this.btnNextBookCovers.Location = new System.Drawing.Point(94, 4);
            this.btnNextBookCovers.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextBookCovers.Name = "btnNextBookCovers";
            this.btnNextBookCovers.Size = new System.Drawing.Size(82, 30);
            this.btnNextBookCovers.TabIndex = 13;
            this.btnNextBookCovers.Text = ">";
            this.btnNextBookCovers.UseVisualStyleBackColor = false;
            this.btnNextBookCovers.Click += new System.EventHandler(this.btnNextBookCovers_Click);
            // 
            // btnPrevBookCovers
            // 
            this.btnPrevBookCovers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(189)))), ((int)(((byte)(86)))));
            this.btnPrevBookCovers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevBookCovers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(118)))), ((int)(((byte)(62)))));
            this.btnPrevBookCovers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevBookCovers.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevBookCovers.ForeColor = System.Drawing.Color.White;
            this.btnPrevBookCovers.Location = new System.Drawing.Point(4, 4);
            this.btnPrevBookCovers.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevBookCovers.Name = "btnPrevBookCovers";
            this.btnPrevBookCovers.Size = new System.Drawing.Size(82, 30);
            this.btnPrevBookCovers.TabIndex = 12;
            this.btnPrevBookCovers.Text = "<";
            this.btnPrevBookCovers.UseVisualStyleBackColor = false;
            this.btnPrevBookCovers.Click += new System.EventHandler(this.btnPrevBookCovers_Click);
            // 
            // txtDescValue
            // 
            this.txtDescValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescValue.BackColor = System.Drawing.Color.White;
            this.txtDescValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescValue.Location = new System.Drawing.Point(2, 82);
            this.txtDescValue.Margin = new System.Windows.Forms.Padding(0, 2, 4, 0);
            this.txtDescValue.Name = "txtDescValue";
            this.txtDescValue.ReadOnly = true;
            this.txtDescValue.Size = new System.Drawing.Size(418, 62);
            this.txtDescValue.TabIndex = 8;
            this.txtDescValue.Text = "";
            // 
            // txtSubjectValue
            // 
            this.txtSubjectValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubjectValue.BackColor = System.Drawing.Color.White;
            this.txtSubjectValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubjectValue.Location = new System.Drawing.Point(2, 174);
            this.txtSubjectValue.Margin = new System.Windows.Forms.Padding(0, 2, 4, 0);
            this.txtSubjectValue.Name = "txtSubjectValue";
            this.txtSubjectValue.ReadOnly = true;
            this.txtSubjectValue.Size = new System.Drawing.Size(418, 62);
            this.txtSubjectValue.TabIndex = 8;
            this.txtSubjectValue.Text = "";
            // 
            // BookDetailCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelBookInfo);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "BookDetailCard";
            this.Padding = new System.Windows.Forms.Padding(16);
            this.Size = new System.Drawing.Size(640, 322);
            this.Load += new System.EventHandler(this.BookDetailCard_Load);
            this.panelBookInfo.ResumeLayout(false);
            this.panelBookInfo.PerformLayout();
            this.panelBookCoversContainer.ResumeLayout(false);
            this.panelBookCoversImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBookCovers)).EndInit();
            this.tableLayoutBookCoversControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelBookInfo;
        private System.Windows.Forms.Panel panelBookCoversContainer;
        private System.Windows.Forms.Panel panelBookCoversImg;
        private System.Windows.Forms.PictureBox picBoxBookCovers;
        private System.Windows.Forms.TableLayoutPanel tableLayoutBookCoversControl;
        private System.Windows.Forms.Button btnNextBookCovers;
        private System.Windows.Forms.Button btnPrevBookCovers;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblFirstPublished;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.RichTextBox txtDescValue;
        private System.Windows.Forms.RichTextBox txtSubjectValue;
    }
}

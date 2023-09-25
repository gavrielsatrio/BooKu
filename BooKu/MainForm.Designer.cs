namespace BooKu
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutContent = new System.Windows.Forms.TableLayoutPanel();
            this.panelBookDetail = new System.Windows.Forms.Panel();
            this.panelBookList = new System.Windows.Forms.Panel();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.panelBookListControl = new System.Windows.Forms.Panel();
            this.panelTxtPageContainer = new System.Windows.Forms.Panel();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.btnNextBookList = new System.Windows.Forms.Button();
            this.btnPrevBookList = new System.Windows.Forms.Button();
            this.lblBookCount = new System.Windows.Forms.Label();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.tableLayoutContent.SuspendLayout();
            this.panelBookList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.panelBookListControl.SuspendLayout();
            this.panelTxtPageContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.txtSubject);
            this.panelSearch.Controls.Add(this.lblSubject);
            this.panelSearch.Controls.Add(this.txtAuthor);
            this.panelSearch.Controls.Add(this.lblAuthor);
            this.panelSearch.Controls.Add(this.txtTitle);
            this.panelSearch.Controls.Add(this.lblTitle);
            this.panelSearch.Controls.Add(this.picBoxLogo);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Padding = new System.Windows.Forms.Padding(16);
            this.panelSearch.Size = new System.Drawing.Size(240, 591);
            this.panelSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(189)))), ((int)(((byte)(86)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(118)))), ((int)(((byte)(62)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(116, 225);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubject.Location = new System.Drawing.Point(65, 196);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(149, 21);
            this.txtSubject.TabIndex = 2;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(16, 199);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(45, 14);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthor.Location = new System.Drawing.Point(65, 167);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(149, 21);
            this.txtAuthor.TabIndex = 1;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(16, 170);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(43, 14);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(65, 138);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(149, 21);
            this.txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(16, 141);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(28, 14);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title";
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(16, 16);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(206, 86);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 1;
            this.picBoxLogo.TabStop = false;
            // 
            // tableLayoutContent
            // 
            this.tableLayoutContent.ColumnCount = 1;
            this.tableLayoutContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutContent.Controls.Add(this.panelBookDetail, 0, 1);
            this.tableLayoutContent.Controls.Add(this.panelBookList, 0, 0);
            this.tableLayoutContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutContent.Location = new System.Drawing.Point(240, 0);
            this.tableLayoutContent.Name = "tableLayoutContent";
            this.tableLayoutContent.RowCount = 2;
            this.tableLayoutContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutContent.Size = new System.Drawing.Size(644, 591);
            this.tableLayoutContent.TabIndex = 1;
            // 
            // panelBookDetail
            // 
            this.panelBookDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBookDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBookDetail.Location = new System.Drawing.Point(0, 295);
            this.panelBookDetail.Margin = new System.Windows.Forms.Padding(0);
            this.panelBookDetail.Name = "panelBookDetail";
            this.panelBookDetail.Size = new System.Drawing.Size(644, 296);
            this.panelBookDetail.TabIndex = 1;
            // 
            // panelBookList
            // 
            this.panelBookList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBookList.Controls.Add(this.dgvBookList);
            this.panelBookList.Controls.Add(this.panelBookListControl);
            this.panelBookList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBookList.Location = new System.Drawing.Point(0, 0);
            this.panelBookList.Margin = new System.Windows.Forms.Padding(0);
            this.panelBookList.Name = "panelBookList";
            this.panelBookList.Size = new System.Drawing.Size(644, 295);
            this.panelBookList.TabIndex = 0;
            // 
            // dgvBookList
            // 
            this.dgvBookList.AllowUserToAddRows = false;
            this.dgvBookList.AllowUserToDeleteRows = false;
            this.dgvBookList.AllowUserToResizeColumns = false;
            this.dgvBookList.AllowUserToResizeRows = false;
            this.dgvBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBookList.ColumnHeadersHeight = 32;
            this.dgvBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBookList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookList.EnableHeadersVisualStyles = false;
            this.dgvBookList.Location = new System.Drawing.Point(0, 0);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            this.dgvBookList.RowHeadersVisible = false;
            this.dgvBookList.RowTemplate.Height = 26;
            this.dgvBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookList.Size = new System.Drawing.Size(642, 247);
            this.dgvBookList.TabIndex = 1;
            this.dgvBookList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookList_CellClick);
            // 
            // panelBookListControl
            // 
            this.panelBookListControl.Controls.Add(this.panelTxtPageContainer);
            this.panelBookListControl.Controls.Add(this.btnNextBookList);
            this.panelBookListControl.Controls.Add(this.btnPrevBookList);
            this.panelBookListControl.Controls.Add(this.lblBookCount);
            this.panelBookListControl.Controls.Add(this.lblPageCount);
            this.panelBookListControl.Controls.Add(this.lblPage);
            this.panelBookListControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBookListControl.Location = new System.Drawing.Point(0, 247);
            this.panelBookListControl.Margin = new System.Windows.Forms.Padding(4);
            this.panelBookListControl.Name = "panelBookListControl";
            this.panelBookListControl.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.panelBookListControl.Size = new System.Drawing.Size(642, 46);
            this.panelBookListControl.TabIndex = 0;
            // 
            // panelTxtPageContainer
            // 
            this.panelTxtPageContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTxtPageContainer.Controls.Add(this.txtPageNumber);
            this.panelTxtPageContainer.Location = new System.Drawing.Point(94, 8);
            this.panelTxtPageContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelTxtPageContainer.Name = "panelTxtPageContainer";
            this.panelTxtPageContainer.Size = new System.Drawing.Size(54, 30);
            this.panelTxtPageContainer.TabIndex = 1;
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPageNumber.BackColor = System.Drawing.Color.White;
            this.txtPageNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPageNumber.Location = new System.Drawing.Point(0, 7);
            this.txtPageNumber.MaxLength = 10;
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(52, 14);
            this.txtPageNumber.TabIndex = 0;
            this.txtPageNumber.Text = "1";
            this.txtPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPageNumber.TextChanged += new System.EventHandler(this.txtPageNumber_TextChanged);
            // 
            // btnNextBookList
            // 
            this.btnNextBookList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(189)))), ((int)(((byte)(86)))));
            this.btnNextBookList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(118)))), ((int)(((byte)(62)))));
            this.btnNextBookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextBookList.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextBookList.ForeColor = System.Drawing.Color.White;
            this.btnNextBookList.Location = new System.Drawing.Point(156, 8);
            this.btnNextBookList.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextBookList.Name = "btnNextBookList";
            this.btnNextBookList.Size = new System.Drawing.Size(40, 30);
            this.btnNextBookList.TabIndex = 1;
            this.btnNextBookList.Text = ">";
            this.btnNextBookList.UseVisualStyleBackColor = false;
            this.btnNextBookList.Click += new System.EventHandler(this.btnNextBookList_Click);
            // 
            // btnPrevBookList
            // 
            this.btnPrevBookList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(189)))), ((int)(((byte)(86)))));
            this.btnPrevBookList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(118)))), ((int)(((byte)(62)))));
            this.btnPrevBookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevBookList.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevBookList.ForeColor = System.Drawing.Color.White;
            this.btnPrevBookList.Location = new System.Drawing.Point(46, 8);
            this.btnPrevBookList.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevBookList.Name = "btnPrevBookList";
            this.btnPrevBookList.Size = new System.Drawing.Size(40, 30);
            this.btnPrevBookList.TabIndex = 0;
            this.btnPrevBookList.Text = "<";
            this.btnPrevBookList.UseVisualStyleBackColor = false;
            this.btnPrevBookList.Click += new System.EventHandler(this.btnPrevBookList_Click);
            // 
            // lblBookCount
            // 
            this.lblBookCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBookCount.Location = new System.Drawing.Point(514, 0);
            this.lblBookCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookCount.Name = "lblBookCount";
            this.lblBookCount.Size = new System.Drawing.Size(120, 46);
            this.lblBookCount.TabIndex = 9;
            this.lblBookCount.Text = "of 4";
            this.lblBookCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Location = new System.Drawing.Point(204, 16);
            this.lblPageCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(27, 14);
            this.lblPageCount.TabIndex = 9;
            this.lblPageCount.Text = "of 4";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(6, 16);
            this.lblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(32, 14);
            this.lblPage.TabIndex = 10;
            this.lblPage.Text = "Page";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 591);
            this.Controls.Add(this.tableLayoutContent);
            this.Controls.Add(this.panelSearch);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooKu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.tableLayoutContent.ResumeLayout(false);
            this.panelBookList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.panelBookListControl.ResumeLayout(false);
            this.panelBookListControl.PerformLayout();
            this.panelTxtPageContainer.ResumeLayout(false);
            this.panelTxtPageContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutContent;
        private System.Windows.Forms.Panel panelBookList;
        private System.Windows.Forms.Panel panelBookDetail;
        private System.Windows.Forms.Panel panelBookListControl;
        private System.Windows.Forms.Panel panelTxtPageContainer;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.Button btnNextBookList;
        private System.Windows.Forms.Button btnPrevBookList;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblBookCount;
        private System.Windows.Forms.DataGridView dgvBookList;
    }
}


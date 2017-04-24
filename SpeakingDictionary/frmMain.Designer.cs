namespace SpeakingDictionary
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlHead = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.grbOptions = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.grbNavigation = new System.Windows.Forms.GroupBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.grbWordMeaning = new System.Windows.Forms.GroupBox();
            this.txtTopic = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblSynthesizerStatus = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.lblCategoryWordMeaning = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.cmbTopic = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHead.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grbOptions.SuspendLayout();
            this.grbNavigation.SuspendLayout();
            this.grbWordMeaning.SuspendLayout();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.Controls.Add(this.btnMinimize);
            this.pnlHead.Controls.Add(this.btnExit);
            this.pnlHead.Controls.Add(this.lblAppTitle);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1196, 40);
            this.pnlHead.TabIndex = 7;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(1108, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 30);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1149, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.Location = new System.Drawing.Point(12, 8);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(1090, 23);
            this.lblAppTitle.TabIndex = 4;
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Controls.Add(this.grbOptions);
            this.pnlMain.Controls.Add(this.grbNavigation);
            this.pnlMain.Controls.Add(this.grbWordMeaning);
            this.pnlMain.Controls.Add(this.grbSearch);
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(12, 46);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1172, 679);
            this.pnlMain.TabIndex = 6;
            // 
            // grbOptions
            // 
            this.grbOptions.Controls.Add(this.btnEdit);
            this.grbOptions.Controls.Add(this.btnCancel);
            this.grbOptions.Controls.Add(this.btnNew);
            this.grbOptions.Controls.Add(this.btnSave);
            this.grbOptions.Controls.Add(this.btnUpdate);
            this.grbOptions.Controls.Add(this.btnDelete);
            this.grbOptions.Location = new System.Drawing.Point(880, 365);
            this.grbOptions.Name = "grbOptions";
            this.grbOptions.Size = new System.Drawing.Size(251, 250);
            this.grbOptions.TabIndex = 4;
            this.grbOptions.TabStop = false;
            this.grbOptions.Text = "Options:";
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(67, 60);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 30);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(67, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(65, 24);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(120, 30);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "NEW";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(67, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(67, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(67, 204);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // grbNavigation
            // 
            this.grbNavigation.Controls.Add(this.btnFirst);
            this.grbNavigation.Controls.Add(this.btnPrevious);
            this.grbNavigation.Controls.Add(this.btnNext);
            this.grbNavigation.Controls.Add(this.lblCount);
            this.grbNavigation.Controls.Add(this.btnLast);
            this.grbNavigation.Location = new System.Drawing.Point(216, 552);
            this.grbNavigation.Name = "grbNavigation";
            this.grbNavigation.Size = new System.Drawing.Size(482, 63);
            this.grbNavigation.TabIndex = 3;
            this.grbNavigation.TabStop = false;
            this.grbNavigation.Text = "Navigation:";
            // 
            // btnFirst
            // 
            this.btnFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(37, 17);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(64, 35);
            this.btnFirst.TabIndex = 1;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(107, 17);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(64, 35);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(311, 17);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(64, 35);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblCount
            // 
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(177, 25);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(128, 18);
            this.lblCount.TabIndex = 47;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLast
            // 
            this.btnLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(381, 17);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(64, 35);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // grbWordMeaning
            // 
            this.grbWordMeaning.Controls.Add(this.txtTopic);
            this.grbWordMeaning.Controls.Add(this.lblStatus);
            this.grbWordMeaning.Controls.Add(this.lblSynthesizerStatus);
            this.grbWordMeaning.Controls.Add(this.btnStop);
            this.grbWordMeaning.Controls.Add(this.btnResume);
            this.grbWordMeaning.Controls.Add(this.btnPause);
            this.grbWordMeaning.Controls.Add(this.btnSpeak);
            this.grbWordMeaning.Controls.Add(this.lblCategoryWordMeaning);
            this.grbWordMeaning.Controls.Add(this.lblWord);
            this.grbWordMeaning.Controls.Add(this.txtWord);
            this.grbWordMeaning.Controls.Add(this.lblMeaning);
            this.grbWordMeaning.Controls.Add(this.txtMeaning);
            this.grbWordMeaning.Location = new System.Drawing.Point(216, 177);
            this.grbWordMeaning.Name = "grbWordMeaning";
            this.grbWordMeaning.Size = new System.Drawing.Size(482, 357);
            this.grbWordMeaning.TabIndex = 1;
            this.grbWordMeaning.TabStop = false;
            this.grbWordMeaning.Text = "Full Meaning:";
            // 
            // txtTopic
            // 
            this.txtTopic.Enabled = false;
            this.txtTopic.FormattingEnabled = true;
            this.txtTopic.Location = new System.Drawing.Point(87, 50);
            this.txtTopic.Name = "txtTopic";
            this.txtTopic.Size = new System.Drawing.Size(380, 24);
            this.txtTopic.TabIndex = 48;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(253, 291);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 16);
            this.lblStatus.TabIndex = 47;
            this.lblStatus.Text = "IDLE";
            // 
            // lblSynthesizerStatus
            // 
            this.lblSynthesizerStatus.AutoSize = true;
            this.lblSynthesizerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSynthesizerStatus.Location = new System.Drawing.Point(48, 291);
            this.lblSynthesizerStatus.Name = "lblSynthesizerStatus";
            this.lblSynthesizerStatus.Size = new System.Drawing.Size(199, 16);
            this.lblSynthesizerStatus.TabIndex = 46;
            this.lblSynthesizerStatus.Text = "SYNTHESIZER  STATUS  : ";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStop.Location = new System.Drawing.Point(342, 316);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 30);
            this.btnStop.TabIndex = 45;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.SystemColors.Control;
            this.btnResume.Enabled = false;
            this.btnResume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResume.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnResume.Location = new System.Drawing.Point(245, 316);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(90, 30);
            this.btnResume.TabIndex = 44;
            this.btnResume.Text = "RESUME";
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.Control;
            this.btnPause.Enabled = false;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPause.Location = new System.Drawing.Point(148, 316);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(90, 30);
            this.btnPause.TabIndex = 43;
            this.btnPause.Text = "PAUSE";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnSpeak
            // 
            this.btnSpeak.BackColor = System.Drawing.SystemColors.Control;
            this.btnSpeak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSpeak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeak.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSpeak.Location = new System.Drawing.Point(51, 316);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(90, 30);
            this.btnSpeak.TabIndex = 42;
            this.btnSpeak.Text = "SPEAK";
            this.btnSpeak.UseVisualStyleBackColor = false;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // lblCategoryWordMeaning
            // 
            this.lblCategoryWordMeaning.AutoSize = true;
            this.lblCategoryWordMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryWordMeaning.Location = new System.Drawing.Point(15, 53);
            this.lblCategoryWordMeaning.Name = "lblCategoryWordMeaning";
            this.lblCategoryWordMeaning.Size = new System.Drawing.Size(46, 16);
            this.lblCategoryWordMeaning.TabIndex = 41;
            this.lblCategoryWordMeaning.Text = "Topic:";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(15, 25);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(44, 16);
            this.lblWord.TabIndex = 37;
            this.lblWord.Text = "Word:";
            // 
            // txtWord
            // 
            this.txtWord.Enabled = false;
            this.txtWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWord.Location = new System.Drawing.Point(87, 22);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(380, 22);
            this.txtWord.TabIndex = 1;
            // 
            // lblMeaning
            // 
            this.lblMeaning.AutoSize = true;
            this.lblMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeaning.Location = new System.Drawing.Point(15, 81);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(63, 16);
            this.lblMeaning.TabIndex = 39;
            this.lblMeaning.Text = "Meaning:";
            // 
            // txtMeaning
            // 
            this.txtMeaning.Enabled = false;
            this.txtMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeaning.Location = new System.Drawing.Point(87, 78);
            this.txtMeaning.Multiline = true;
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMeaning.Size = new System.Drawing.Size(380, 200);
            this.txtMeaning.TabIndex = 3;
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.cmbTopic);
            this.grbSearch.Controls.Add(this.label3);
            this.grbSearch.Controls.Add(this.label2);
            this.grbSearch.Controls.Add(this.label1);
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Controls.Add(this.txtSearch);
            this.grbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearch.Location = new System.Drawing.Point(880, 91);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(251, 229);
            this.grbSearch.TabIndex = 2;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search:";
            // 
            // cmbTopic
            // 
            this.cmbTopic.FormattingEnabled = true;
            this.cmbTopic.Location = new System.Drawing.Point(21, 136);
            this.cmbTopic.Name = "cmbTopic";
            this.cmbTopic.Size = new System.Drawing.Size(211, 24);
            this.cmbTopic.TabIndex = 2;
            this.cmbTopic.Text = "All";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Topic:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Please input any scientific :";
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(65, 184);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(21, 74);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(211, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(459, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "technical terms,:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1196, 737);
            this.ControlBox = false;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHead);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlHead.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.grbOptions.ResumeLayout(false);
            this.grbNavigation.ResumeLayout(false);
            this.grbWordMeaning.ResumeLayout(false);
            this.grbWordMeaning.PerformLayout();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grbOptions;
        private System.Windows.Forms.GroupBox grbNavigation;
        private System.Windows.Forms.GroupBox grbWordMeaning;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCategoryWordMeaning;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbTopic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblSynthesizerStatus;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.ComboBox txtTopic;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}


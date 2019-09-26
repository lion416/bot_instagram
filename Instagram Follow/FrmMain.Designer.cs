namespace Instagram_Email_Scrape
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.dgv_account = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_proxy = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_link = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pool = new System.Windows.Forms.GroupBox();
            this.poolDisplay = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_pool_follower = new System.Windows.Forms.CheckBox();
            this.cb_pool = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cb_comment = new System.Windows.Forms.CheckBox();
            this.cb_like = new System.Windows.Forms.CheckBox();
            this.radioButton_unfollow = new System.Windows.Forms.RadioButton();
            this.radioButton_follow = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maleGender = new System.Windows.Forms.RadioButton();
            this.femaleGender = new System.Windows.Forms.RadioButton();
            this.allGender = new System.Windows.Forms.RadioButton();
            this.genderLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maxPostCount = new System.Windows.Forms.TextBox();
            this.minPostCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxFollowerCount = new System.Windows.Forms.TextBox();
            this.minFollowerCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maxFollowingCount = new System.Windows.Forms.TextBox();
            this.minFollowingCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tb_likeEndM = new System.Windows.Forms.TextBox();
            this.tb_likeStartM = new System.Windows.Forms.TextBox();
            this.tb_unfollowEndM = new System.Windows.Forms.TextBox();
            this.tb_unfollowStartM = new System.Windows.Forms.TextBox();
            this.tb_followEndM = new System.Windows.Forms.TextBox();
            this.tb_followStartM = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_likeRandomEndTime = new System.Windows.Forms.TextBox();
            this.tb_likeRandomStartTime = new System.Windows.Forms.TextBox();
            this.tb_likeEndH = new System.Windows.Forms.TextBox();
            this.tb_likeStartH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_unfollowRandomEndTime = new System.Windows.Forms.TextBox();
            this.tb_unfollowRandomStartTime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_unfollowEndH = new System.Windows.Forms.TextBox();
            this.tb_unfollowStartH = new System.Windows.Forms.TextBox();
            this.tb_randomEndTime = new System.Windows.Forms.TextBox();
            this.tb_randomStartTime = new System.Windows.Forms.TextBox();
            this.tb_followEndH = new System.Windows.Forms.TextBox();
            this.tb_followStartH = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proxy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_link)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pool.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(235, 107);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 40);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(235, 107);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 40);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Visible = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // dgv_account
            // 
            this.dgv_account.AllowUserToAddRows = false;
            this.dgv_account.BackgroundColor = System.Drawing.Color.White;
            this.dgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_account.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1});
            this.dgv_account.Location = new System.Drawing.Point(395, 22);
            this.dgv_account.Name = "dgv_account";
            this.dgv_account.RowHeadersVisible = false;
            this.dgv_account.Size = new System.Drawing.Size(281, 246);
            this.dgv_account.TabIndex = 8;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.Width = 160;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Password";
            this.Column1.Name = "Column1";
            this.Column1.Width = 160;
            // 
            // dgv_proxy
            // 
            this.dgv_proxy.AllowUserToAddRows = false;
            this.dgv_proxy.BackgroundColor = System.Drawing.Color.White;
            this.dgv_proxy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proxy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv_proxy.Location = new System.Drawing.Point(1132, 633);
            this.dgv_proxy.Name = "dgv_proxy";
            this.dgv_proxy.RowHeadersVisible = false;
            this.dgv_proxy.Size = new System.Drawing.Size(153, 95);
            this.dgv_proxy.TabIndex = 9;
            this.dgv_proxy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_proxy_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "IP";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Port";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dgv_link
            // 
            this.dgv_link.AllowUserToAddRows = false;
            this.dgv_link.BackgroundColor = System.Drawing.Color.White;
            this.dgv_link.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_link.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.dgv_link.Location = new System.Drawing.Point(395, 288);
            this.dgv_link.Name = "dgv_link";
            this.dgv_link.RowHeadersVisible = false;
            this.dgv_link.Size = new System.Drawing.Size(281, 321);
            this.dgv_link.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Link";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pool);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cb_comment);
            this.groupBox1.Controls.Add(this.cb_like);
            this.groupBox1.Controls.Add(this.radioButton_unfollow);
            this.groupBox1.Controls.Add(this.radioButton_follow);
            this.groupBox1.Controls.Add(this.btn_Stop);
            this.groupBox1.Controls.Add(this.btn_Start);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 683);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Option";
            // 
            // pool
            // 
            this.pool.Controls.Add(this.poolDisplay);
            this.pool.Location = new System.Drawing.Point(185, 344);
            this.pool.Name = "pool";
            this.pool.Size = new System.Drawing.Size(177, 74);
            this.pool.TabIndex = 14;
            this.pool.TabStop = false;
            this.pool.Text = "Pool";
            this.pool.Enter += new System.EventHandler(this.pool_Enter);
            // 
            // poolDisplay
            // 
            this.poolDisplay.Location = new System.Drawing.Point(41, 29);
            this.poolDisplay.Name = "poolDisplay";
            this.poolDisplay.Size = new System.Drawing.Size(100, 20);
            this.poolDisplay.TabIndex = 0;
            this.poolDisplay.TextChanged += new System.EventHandler(this.poolDisplay_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_pool_follower);
            this.groupBox4.Controls.Add(this.cb_pool);
            this.groupBox4.Location = new System.Drawing.Point(11, 330);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(144, 97);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pool";
            // 
            // cb_pool_follower
            // 
            this.cb_pool_follower.AutoSize = true;
            this.cb_pool_follower.Location = new System.Drawing.Point(6, 60);
            this.cb_pool_follower.Name = "cb_pool_follower";
            this.cb_pool_follower.Size = new System.Drawing.Size(70, 17);
            this.cb_pool_follower.TabIndex = 8;
            this.cb_pool_follower.Text = "Followers";
            this.cb_pool_follower.UseVisualStyleBackColor = true;
            // 
            // cb_pool
            // 
            this.cb_pool.AutoSize = true;
            this.cb_pool.Location = new System.Drawing.Point(6, 19);
            this.cb_pool.Name = "cb_pool";
            this.cb_pool.Size = new System.Drawing.Size(106, 17);
            this.cb_pool.TabIndex = 7;
            this.cb_pool.Text = "Comments, Likes";
            this.cb_pool.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 214);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 86);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cb_comment
            // 
            this.cb_comment.AutoSize = true;
            this.cb_comment.Location = new System.Drawing.Point(104, 136);
            this.cb_comment.Name = "cb_comment";
            this.cb_comment.Size = new System.Drawing.Size(70, 17);
            this.cb_comment.TabIndex = 5;
            this.cb_comment.Text = "Comment";
            this.cb_comment.UseVisualStyleBackColor = true;
            // 
            // cb_like
            // 
            this.cb_like.AutoSize = true;
            this.cb_like.Location = new System.Drawing.Point(28, 136);
            this.cb_like.Name = "cb_like";
            this.cb_like.Size = new System.Drawing.Size(70, 17);
            this.cb_like.TabIndex = 4;
            this.cb_like.Text = "Like Post";
            this.cb_like.UseVisualStyleBackColor = true;
            this.cb_like.CheckedChanged += new System.EventHandler(this.cb_like_CheckedChanged);
            // 
            // radioButton_unfollow
            // 
            this.radioButton_unfollow.AutoSize = true;
            this.radioButton_unfollow.Location = new System.Drawing.Point(104, 95);
            this.radioButton_unfollow.Name = "radioButton_unfollow";
            this.radioButton_unfollow.Size = new System.Drawing.Size(66, 17);
            this.radioButton_unfollow.TabIndex = 3;
            this.radioButton_unfollow.Text = "Unfollow";
            this.radioButton_unfollow.UseVisualStyleBackColor = true;
            this.radioButton_unfollow.CheckedChanged += new System.EventHandler(this.radioButton_unfollow_CheckedChanged);
            // 
            // radioButton_follow
            // 
            this.radioButton_follow.AutoSize = true;
            this.radioButton_follow.Checked = true;
            this.radioButton_follow.Location = new System.Drawing.Point(28, 94);
            this.radioButton_follow.Name = "radioButton_follow";
            this.radioButton_follow.Size = new System.Drawing.Size(55, 17);
            this.radioButton_follow.TabIndex = 2;
            this.radioButton_follow.TabStop = true;
            this.radioButton_follow.Text = "Follow";
            this.radioButton_follow.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.maleGender);
            this.groupBox2.Controls.Add(this.femaleGender);
            this.groupBox2.Controls.Add(this.allGender);
            this.groupBox2.Controls.Add(this.genderLabel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.maxPostCount);
            this.groupBox2.Controls.Add(this.minPostCount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.maxFollowerCount);
            this.groupBox2.Controls.Add(this.minFollowerCount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.maxFollowingCount);
            this.groupBox2.Controls.Add(this.minFollowingCount);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(1055, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 587);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Filters for Follows";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // maleGender
            // 
            this.maleGender.AutoSize = true;
            this.maleGender.Location = new System.Drawing.Point(69, 363);
            this.maleGender.Name = "maleGender";
            this.maleGender.Size = new System.Drawing.Size(116, 17);
            this.maleGender.TabIndex = 19;
            this.maleGender.TabStop = true;
            this.maleGender.Text = " Just follow MALES";
            this.maleGender.UseVisualStyleBackColor = true;
            // 
            // femaleGender
            // 
            this.femaleGender.AutoSize = true;
            this.femaleGender.Location = new System.Drawing.Point(69, 319);
            this.femaleGender.Name = "femaleGender";
            this.femaleGender.Size = new System.Drawing.Size(126, 17);
            this.femaleGender.TabIndex = 18;
            this.femaleGender.TabStop = true;
            this.femaleGender.Text = "Just follow FEMALES";
            this.femaleGender.UseVisualStyleBackColor = true;
            // 
            // allGender
            // 
            this.allGender.AutoSize = true;
            this.allGender.Location = new System.Drawing.Point(69, 282);
            this.allGender.Name = "allGender";
            this.allGender.Size = new System.Drawing.Size(111, 17);
            this.allGender.TabIndex = 17;
            this.allGender.TabStop = true;
            this.allGender.Text = "Follow all Genders";
            this.allGender.UseVisualStyleBackColor = true;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(24, 247);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(67, 13);
            this.genderLabel.TabIndex = 16;
            this.genderLabel.Text = "Gender Filter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(158, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Medias Count";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 11;
            // 
            // maxPostCount
            // 
            this.maxPostCount.Location = new System.Drawing.Point(314, 188);
            this.maxPostCount.Name = "maxPostCount";
            this.maxPostCount.Size = new System.Drawing.Size(62, 20);
            this.maxPostCount.TabIndex = 10;
            this.maxPostCount.Text = "1000";
            this.maxPostCount.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // minPostCount
            // 
            this.minPostCount.Location = new System.Drawing.Point(38, 188);
            this.minPostCount.Name = "minPostCount";
            this.minPostCount.Size = new System.Drawing.Size(66, 20);
            this.minPostCount.TabIndex = 9;
            this.minPostCount.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Followers Count ";
            // 
            // maxFollowerCount
            // 
            this.maxFollowerCount.Location = new System.Drawing.Point(314, 133);
            this.maxFollowerCount.Name = "maxFollowerCount";
            this.maxFollowerCount.Size = new System.Drawing.Size(63, 20);
            this.maxFollowerCount.TabIndex = 7;
            this.maxFollowerCount.Text = "1000";
            // 
            // minFollowerCount
            // 
            this.minFollowerCount.Location = new System.Drawing.Point(38, 134);
            this.minFollowerCount.Name = "minFollowerCount";
            this.minFollowerCount.Size = new System.Drawing.Size(66, 20);
            this.minFollowerCount.TabIndex = 6;
            this.minFollowerCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = " Following Count ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // maxFollowingCount
            // 
            this.maxFollowingCount.Location = new System.Drawing.Point(313, 77);
            this.maxFollowingCount.Name = "maxFollowingCount";
            this.maxFollowingCount.Size = new System.Drawing.Size(63, 20);
            this.maxFollowingCount.TabIndex = 4;
            this.maxFollowingCount.Text = "1000";
            this.maxFollowingCount.TextChanged += new System.EventHandler(this.maxFollowingCount_TextChanged);
            // 
            // minFollowingCount
            // 
            this.minFollowingCount.Location = new System.Drawing.Point(38, 77);
            this.minFollowingCount.Name = "minFollowingCount";
            this.minFollowingCount.Size = new System.Drawing.Size(66, 20);
            this.minFollowingCount.TabIndex = 3;
            this.minFollowingCount.Text = "0";
            this.minFollowingCount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Smaller than bellow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Larger than bellow";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_likeEndM);
            this.groupBox3.Controls.Add(this.tb_likeStartM);
            this.groupBox3.Controls.Add(this.tb_unfollowEndM);
            this.groupBox3.Controls.Add(this.tb_unfollowStartM);
            this.groupBox3.Controls.Add(this.tb_followEndM);
            this.groupBox3.Controls.Add(this.tb_followStartM);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tb_likeRandomEndTime);
            this.groupBox3.Controls.Add(this.tb_likeRandomStartTime);
            this.groupBox3.Controls.Add(this.tb_likeEndH);
            this.groupBox3.Controls.Add(this.tb_likeStartH);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tb_unfollowRandomEndTime);
            this.groupBox3.Controls.Add(this.tb_unfollowRandomStartTime);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tb_unfollowEndH);
            this.groupBox3.Controls.Add(this.tb_unfollowStartH);
            this.groupBox3.Controls.Add(this.tb_randomEndTime);
            this.groupBox3.Controls.Add(this.tb_randomStartTime);
            this.groupBox3.Controls.Add(this.tb_followEndH);
            this.groupBox3.Controls.Add(this.tb_followStartH);
            this.groupBox3.Location = new System.Drawing.Point(695, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(354, 587);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sleep Times";
            // 
            // tb_likeEndM
            // 
            this.tb_likeEndM.Location = new System.Drawing.Point(292, 363);
            this.tb_likeEndM.Name = "tb_likeEndM";
            this.tb_likeEndM.Size = new System.Drawing.Size(29, 20);
            this.tb_likeEndM.TabIndex = 20;
            // 
            // tb_likeStartM
            // 
            this.tb_likeStartM.Location = new System.Drawing.Point(126, 363);
            this.tb_likeStartM.Name = "tb_likeStartM";
            this.tb_likeStartM.Size = new System.Drawing.Size(30, 20);
            this.tb_likeStartM.TabIndex = 19;
            // 
            // tb_unfollowEndM
            // 
            this.tb_unfollowEndM.Location = new System.Drawing.Point(292, 212);
            this.tb_unfollowEndM.Name = "tb_unfollowEndM";
            this.tb_unfollowEndM.Size = new System.Drawing.Size(30, 20);
            this.tb_unfollowEndM.TabIndex = 18;
            // 
            // tb_unfollowStartM
            // 
            this.tb_unfollowStartM.Location = new System.Drawing.Point(126, 213);
            this.tb_unfollowStartM.Name = "tb_unfollowStartM";
            this.tb_unfollowStartM.Size = new System.Drawing.Size(30, 20);
            this.tb_unfollowStartM.TabIndex = 17;
            // 
            // tb_followEndM
            // 
            this.tb_followEndM.Location = new System.Drawing.Point(292, 73);
            this.tb_followEndM.Name = "tb_followEndM";
            this.tb_followEndM.Size = new System.Drawing.Size(31, 20);
            this.tb_followEndM.TabIndex = 16;
            // 
            // tb_followStartM
            // 
            this.tb_followStartM.Location = new System.Drawing.Point(126, 73);
            this.tb_followStartM.Name = "tb_followStartM";
            this.tb_followStartM.Size = new System.Drawing.Size(31, 20);
            this.tb_followStartM.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Follow";
            // 
            // tb_likeRandomEndTime
            // 
            this.tb_likeRandomEndTime.Location = new System.Drawing.Point(236, 416);
            this.tb_likeRandomEndTime.Name = "tb_likeRandomEndTime";
            this.tb_likeRandomEndTime.Size = new System.Drawing.Size(100, 20);
            this.tb_likeRandomEndTime.TabIndex = 13;
            // 
            // tb_likeRandomStartTime
            // 
            this.tb_likeRandomStartTime.Location = new System.Drawing.Point(69, 416);
            this.tb_likeRandomStartTime.Name = "tb_likeRandomStartTime";
            this.tb_likeRandomStartTime.Size = new System.Drawing.Size(100, 20);
            this.tb_likeRandomStartTime.TabIndex = 12;
            // 
            // tb_likeEndH
            // 
            this.tb_likeEndH.Location = new System.Drawing.Point(236, 363);
            this.tb_likeEndH.Name = "tb_likeEndH";
            this.tb_likeEndH.Size = new System.Drawing.Size(35, 20);
            this.tb_likeEndH.TabIndex = 11;
            // 
            // tb_likeStartH
            // 
            this.tb_likeStartH.Location = new System.Drawing.Point(69, 363);
            this.tb_likeStartH.Name = "tb_likeStartH";
            this.tb_likeStartH.Size = new System.Drawing.Size(34, 20);
            this.tb_likeStartH.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Like";
            // 
            // tb_unfollowRandomEndTime
            // 
            this.tb_unfollowRandomEndTime.Location = new System.Drawing.Point(236, 266);
            this.tb_unfollowRandomEndTime.Name = "tb_unfollowRandomEndTime";
            this.tb_unfollowRandomEndTime.Size = new System.Drawing.Size(100, 20);
            this.tb_unfollowRandomEndTime.TabIndex = 8;
            // 
            // tb_unfollowRandomStartTime
            // 
            this.tb_unfollowRandomStartTime.Location = new System.Drawing.Point(69, 266);
            this.tb_unfollowRandomStartTime.Name = "tb_unfollowRandomStartTime";
            this.tb_unfollowRandomStartTime.Size = new System.Drawing.Size(100, 20);
            this.tb_unfollowRandomStartTime.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Unfollow";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tb_unfollowEndH
            // 
            this.tb_unfollowEndH.Location = new System.Drawing.Point(236, 214);
            this.tb_unfollowEndH.Name = "tb_unfollowEndH";
            this.tb_unfollowEndH.Size = new System.Drawing.Size(35, 20);
            this.tb_unfollowEndH.TabIndex = 5;
            // 
            // tb_unfollowStartH
            // 
            this.tb_unfollowStartH.Location = new System.Drawing.Point(69, 214);
            this.tb_unfollowStartH.Name = "tb_unfollowStartH";
            this.tb_unfollowStartH.Size = new System.Drawing.Size(34, 20);
            this.tb_unfollowStartH.TabIndex = 4;
            // 
            // tb_randomEndTime
            // 
            this.tb_randomEndTime.Location = new System.Drawing.Point(236, 127);
            this.tb_randomEndTime.Name = "tb_randomEndTime";
            this.tb_randomEndTime.Size = new System.Drawing.Size(100, 20);
            this.tb_randomEndTime.TabIndex = 3;
            // 
            // tb_randomStartTime
            // 
            this.tb_randomStartTime.Location = new System.Drawing.Point(69, 127);
            this.tb_randomStartTime.Name = "tb_randomStartTime";
            this.tb_randomStartTime.Size = new System.Drawing.Size(100, 20);
            this.tb_randomStartTime.TabIndex = 2;
            // 
            // tb_followEndH
            // 
            this.tb_followEndH.Location = new System.Drawing.Point(236, 73);
            this.tb_followEndH.Name = "tb_followEndH";
            this.tb_followEndH.Size = new System.Drawing.Size(35, 20);
            this.tb_followEndH.TabIndex = 1;
            // 
            // tb_followStartH
            // 
            this.tb_followStartH.Location = new System.Drawing.Point(69, 73);
            this.tb_followStartH.Name = "tb_followStartH";
            this.tb_followStartH.Size = new System.Drawing.Size(34, 20);
            this.tb_followStartH.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 740);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_link);
            this.Controls.Add(this.dgv_proxy);
            this.Controls.Add(this.dgv_account);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Instagram Follow";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proxy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_link)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pool.ResumeLayout(false);
            this.pool.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.DataGridView dgv_account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgv_proxy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dgv_link;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_follow;
        private System.Windows.Forms.RadioButton radioButton_unfollow;
        private System.Windows.Forms.CheckBox cb_like;
        private System.Windows.Forms.CheckBox cb_comment;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maxPostCount;
        private System.Windows.Forms.TextBox minPostCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maxFollowerCount;
        private System.Windows.Forms.TextBox minFollowerCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox maxFollowingCount;
        private System.Windows.Forms.TextBox minFollowingCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox pool;
        public System.Windows.Forms.TextBox poolDisplay;
        private System.Windows.Forms.CheckBox cb_pool;
        private System.Windows.Forms.RadioButton maleGender;
        private System.Windows.Forms.RadioButton femaleGender;
        private System.Windows.Forms.RadioButton allGender;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cb_pool_follower;
        private System.Windows.Forms.TextBox tb_randomEndTime;
        private System.Windows.Forms.TextBox tb_randomStartTime;
        private System.Windows.Forms.TextBox tb_followEndH;
        private System.Windows.Forms.TextBox tb_followStartH;
        private System.Windows.Forms.TextBox tb_likeRandomEndTime;
        private System.Windows.Forms.TextBox tb_likeRandomStartTime;
        private System.Windows.Forms.TextBox tb_likeEndH;
        private System.Windows.Forms.TextBox tb_likeStartH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_unfollowRandomEndTime;
        private System.Windows.Forms.TextBox tb_unfollowRandomStartTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_unfollowEndH;
        private System.Windows.Forms.TextBox tb_unfollowStartH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_followStartM;
        private System.Windows.Forms.TextBox tb_followEndM;
        private System.Windows.Forms.TextBox tb_unfollowStartM;
        private System.Windows.Forms.TextBox tb_unfollowEndM;
        private System.Windows.Forms.TextBox tb_likeStartM;
        private System.Windows.Forms.TextBox tb_likeEndM;
    }
}


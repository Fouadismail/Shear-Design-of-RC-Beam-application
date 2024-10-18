namespace shear_for_simple_beam
{
    partial class welcom_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcom_form));
            this.start_button = new System.Windows.Forms.Button();
            this.length_label = new System.Windows.Forms.Label();
            this.Length = new System.Windows.Forms.TextBox();
            this.dis_load = new System.Windows.Forms.TextBox();
            this.load_label = new System.Windows.Forms.Label();
            this.avilable_conload = new System.Windows.Forms.CheckBox();
            this.depth = new System.Windows.Forms.TextBox();
            this.depth_label = new System.Windows.Forms.Label();
            this.col_width = new System.Windows.Forms.TextBox();
            this.column_label = new System.Windows.Forms.Label();
            this.con_load = new System.Windows.Forms.TextBox();
            this.con_load_label = new System.Windows.Forms.Label();
            this.loction_con_load = new System.Windows.Forms.TextBox();
            this.location_conLoad_label = new System.Windows.Forms.Label();
            this.Qcracked = new System.Windows.Forms.TextBox();
            this.Q_cracked = new System.Windows.Forms.Label();
            this.min_width_label = new System.Windows.Forms.Label();
            this.fcu_label = new System.Windows.Forms.Label();
            this.min_width = new System.Windows.Forms.TextBox();
            this.Fcu_input = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.qu_input = new System.Windows.Forms.TextBox();
            this.qu_label = new System.Windows.Forms.Label();
            this.qcr_input = new System.Windows.Forms.TextBox();
            this.qcr_label = new System.Windows.Forms.Label();
            this.quncr_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.qumax_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.Shear_result_label = new System.Windows.Forms.Label();
            this.fy_input = new System.Windows.Forms.TextBox();
            this.fy_label = new System.Windows.Forms.Label();
            this.spacing_label = new System.Windows.Forms.Label();
            this.spacing = new System.Windows.Forms.TextBox();
            this.spacing_stat = new System.Windows.Forms.Label();
            this.No_stirrups_input = new System.Windows.Forms.TextBox();
            this.No_stirrups_label = new System.Windows.Forms.Label();
            this.phi_input = new System.Windows.Forms.ComboBox();
            this.phi_label = new System.Windows.Forms.Label();
            this.n_input = new System.Windows.Forms.ComboBox();
            this.no_branch_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.White;
            this.start_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.start_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.start_button.FlatAppearance.BorderSize = 0;
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.start_button.Location = new System.Drawing.Point(119, 234);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(114, 23);
            this.start_button.TabIndex = 12;
            this.start_button.Text = "start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // length_label
            // 
            this.length_label.AutoSize = true;
            this.length_label.Location = new System.Drawing.Point(33, 13);
            this.length_label.Name = "length_label";
            this.length_label.Size = new System.Drawing.Size(30, 13);
            this.length_label.TabIndex = 2;
            this.length_label.Text = "L (m)";
            this.length_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(17, 33);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(62, 20);
            this.Length.TabIndex = 0;
            this.Length.TextChanged += new System.EventHandler(this.L_TextChanged);
            // 
            // dis_load
            // 
            this.dis_load.Location = new System.Drawing.Point(17, 83);
            this.dis_load.Name = "dis_load";
            this.dis_load.Size = new System.Drawing.Size(62, 20);
            this.dis_load.TabIndex = 3;
            // 
            // load_label
            // 
            this.load_label.AutoSize = true;
            this.load_label.Location = new System.Drawing.Point(21, 64);
            this.load_label.Name = "load_label";
            this.load_label.Size = new System.Drawing.Size(55, 13);
            this.load_label.TabIndex = 4;
            this.load_label.Text = "W (KN/m)";
            this.load_label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // avilable_conload
            // 
            this.avilable_conload.AutoSize = true;
            this.avilable_conload.Cursor = System.Windows.Forms.Cursors.Default;
            this.avilable_conload.Location = new System.Drawing.Point(22, 162);
            this.avilable_conload.Name = "avilable_conload";
            this.avilable_conload.Size = new System.Drawing.Size(112, 17);
            this.avilable_conload.TabIndex = 9;
            this.avilable_conload.Text = "concentrated load";
            this.avilable_conload.UseVisualStyleBackColor = true;
            this.avilable_conload.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(100, 33);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(62, 20);
            this.depth.TabIndex = 1;
            // 
            // depth_label
            // 
            this.depth_label.AutoSize = true;
            this.depth_label.Location = new System.Drawing.Point(116, 13);
            this.depth_label.Name = "depth_label";
            this.depth_label.Size = new System.Drawing.Size(30, 13);
            this.depth_label.TabIndex = 8;
            this.depth_label.Text = "d (m)";
            // 
            // col_width
            // 
            this.col_width.Location = new System.Drawing.Point(187, 33);
            this.col_width.Name = "col_width";
            this.col_width.Size = new System.Drawing.Size(62, 20);
            this.col_width.TabIndex = 2;
            // 
            // column_label
            // 
            this.column_label.AutoSize = true;
            this.column_label.Location = new System.Drawing.Point(203, 13);
            this.column_label.Name = "column_label";
            this.column_label.Size = new System.Drawing.Size(31, 13);
            this.column_label.TabIndex = 10;
            this.column_label.Text = "C (m)";
            this.column_label.Click += new System.EventHandler(this.label2_Click);
            // 
            // con_load
            // 
            this.con_load.Location = new System.Drawing.Point(22, 198);
            this.con_load.Name = "con_load";
            this.con_load.Size = new System.Drawing.Size(134, 20);
            this.con_load.TabIndex = 10;
            this.con_load.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // con_load_label
            // 
            this.con_load_label.AutoSize = true;
            this.con_load_label.Location = new System.Drawing.Point(66, 182);
            this.con_load_label.Name = "con_load_label";
            this.con_load_label.Size = new System.Drawing.Size(38, 13);
            this.con_load_label.TabIndex = 12;
            this.con_load_label.Text = "P (KN)";
            this.con_load_label.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // loction_con_load
            // 
            this.loction_con_load.Location = new System.Drawing.Point(187, 198);
            this.loction_con_load.Name = "loction_con_load";
            this.loction_con_load.Size = new System.Drawing.Size(134, 20);
            this.loction_con_load.TabIndex = 11;
            // 
            // location_conLoad_label
            // 
            this.location_conLoad_label.AutoSize = true;
            this.location_conLoad_label.Location = new System.Drawing.Point(232, 182);
            this.location_conLoad_label.Name = "location_conLoad_label";
            this.location_conLoad_label.Size = new System.Drawing.Size(30, 13);
            this.location_conLoad_label.TabIndex = 14;
            this.location_conLoad_label.Text = "a (m)";
            this.location_conLoad_label.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // Qcracked
            // 
            this.Qcracked.Location = new System.Drawing.Point(17, 309);
            this.Qcracked.Name = "Qcracked";
            this.Qcracked.ReadOnly = true;
            this.Qcracked.Size = new System.Drawing.Size(62, 20);
            this.Qcracked.TabIndex = 13;
            this.Qcracked.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Q_cracked
            // 
            this.Q_cracked.AutoSize = true;
            this.Q_cracked.Location = new System.Drawing.Point(14, 291);
            this.Q_cracked.Name = "Q_cracked";
            this.Q_cracked.Size = new System.Drawing.Size(48, 13);
            this.Q_cracked.TabIndex = 16;
            this.Q_cracked.Text = "Qcr (KN)";
            this.Q_cracked.Click += new System.EventHandler(this.label1_Click_4);
            // 
            // min_width_label
            // 
            this.min_width_label.AutoSize = true;
            this.min_width_label.Location = new System.Drawing.Point(280, 45);
            this.min_width_label.Name = "min_width_label";
            this.min_width_label.Size = new System.Drawing.Size(30, 13);
            this.min_width_label.TabIndex = 20;
            this.min_width_label.Text = "b (m)";
            this.min_width_label.Click += new System.EventHandler(this.label1_Click_5);
            // 
            // fcu_label
            // 
            this.fcu_label.AutoSize = true;
            this.fcu_label.Location = new System.Drawing.Point(98, 64);
            this.fcu_label.Name = "fcu_label";
            this.fcu_label.Size = new System.Drawing.Size(66, 13);
            this.fcu_label.TabIndex = 21;
            this.fcu_label.Text = "fcu (N/mm2)";
            this.fcu_label.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // min_width
            // 
            this.min_width.Location = new System.Drawing.Point(268, 64);
            this.min_width.Name = "min_width";
            this.min_width.Size = new System.Drawing.Size(62, 20);
            this.min_width.TabIndex = 6;
            // 
            // Fcu_input
            // 
            this.Fcu_input.Location = new System.Drawing.Point(100, 83);
            this.Fcu_input.Name = "Fcu_input";
            this.Fcu_input.Size = new System.Drawing.Size(62, 20);
            this.Fcu_input.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.Location = new System.Drawing.Point(341, 289);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.ShortcutsEnabled = false;
            this.textBox3.Size = new System.Drawing.Size(231, 134);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // qu_input
            // 
            this.qu_input.Location = new System.Drawing.Point(100, 309);
            this.qu_input.Name = "qu_input";
            this.qu_input.ReadOnly = true;
            this.qu_input.Size = new System.Drawing.Size(62, 20);
            this.qu_input.TabIndex = 14;
            // 
            // qu_label
            // 
            this.qu_label.AutoSize = true;
            this.qu_label.Location = new System.Drawing.Point(101, 291);
            this.qu_label.Name = "qu_label";
            this.qu_label.Size = new System.Drawing.Size(63, 13);
            this.qu_label.TabIndex = 24;
            this.qu_label.Text = "qu (N/mm2)";
            this.qu_label.Click += new System.EventHandler(this.qu_label_Click);
            // 
            // qcr_input
            // 
            this.qcr_input.Location = new System.Drawing.Point(271, 309);
            this.qcr_input.Name = "qcr_input";
            this.qcr_input.ReadOnly = true;
            this.qcr_input.Size = new System.Drawing.Size(62, 20);
            this.qcr_input.TabIndex = 16;
            this.qcr_input.TextChanged += new System.EventHandler(this.qcr_input_TextChanged);
            // 
            // qcr_label
            // 
            this.qcr_label.AutoSize = true;
            this.qcr_label.Location = new System.Drawing.Point(268, 291);
            this.qcr_label.Name = "qcr_label";
            this.qcr_label.Size = new System.Drawing.Size(69, 13);
            this.qcr_label.TabIndex = 26;
            this.qcr_label.Text = "q cr (N/mm2)";
            this.qcr_label.Click += new System.EventHandler(this.label1_Click_6);
            // 
            // quncr_input
            // 
            this.quncr_input.Location = new System.Drawing.Point(187, 309);
            this.quncr_input.Name = "quncr_input";
            this.quncr_input.ReadOnly = true;
            this.quncr_input.Size = new System.Drawing.Size(62, 20);
            this.quncr_input.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "q uncr (N/mm2)";
            // 
            // qumax_input
            // 
            this.qumax_input.Location = new System.Drawing.Point(122, 340);
            this.qumax_input.Name = "qumax_input";
            this.qumax_input.ReadOnly = true;
            this.qumax_input.Size = new System.Drawing.Size(93, 20);
            this.qumax_input.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "qu max (N/mm2)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "must ≤ 4.4 N/mm2";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(122, 371);
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(193, 20);
            this.result.TabIndex = 18;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Shear_result_label
            // 
            this.Shear_result_label.AutoSize = true;
            this.Shear_result_label.Location = new System.Drawing.Point(10, 375);
            this.Shear_result_label.Name = "Shear_result_label";
            this.Shear_result_label.Size = new System.Drawing.Size(109, 13);
            this.Shear_result_label.TabIndex = 33;
            this.Shear_result_label.Text = "Check of Shear result";
            // 
            // fy_input
            // 
            this.fy_input.Location = new System.Drawing.Point(187, 83);
            this.fy_input.Name = "fy_input";
            this.fy_input.Size = new System.Drawing.Size(62, 20);
            this.fy_input.TabIndex = 5;
            // 
            // fy_label
            // 
            this.fy_label.AutoSize = true;
            this.fy_label.Location = new System.Drawing.Point(189, 64);
            this.fy_label.Name = "fy_label";
            this.fy_label.Size = new System.Drawing.Size(59, 13);
            this.fy_label.TabIndex = 35;
            this.fy_label.Text = "fy (N/mm2)";
            // 
            // spacing_label
            // 
            this.spacing_label.AutoSize = true;
            this.spacing_label.Location = new System.Drawing.Point(10, 406);
            this.spacing_label.Name = "spacing_label";
            this.spacing_label.Size = new System.Drawing.Size(39, 13);
            this.spacing_label.TabIndex = 37;
            this.spacing_label.Text = "S (mm)";
            this.spacing_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // spacing
            // 
            this.spacing.Location = new System.Drawing.Point(55, 403);
            this.spacing.Name = "spacing";
            this.spacing.ReadOnly = true;
            this.spacing.Size = new System.Drawing.Size(109, 20);
            this.spacing.TabIndex = 19;
            // 
            // spacing_stat
            // 
            this.spacing_stat.AutoSize = true;
            this.spacing_stat.Location = new System.Drawing.Point(168, 406);
            this.spacing_stat.Name = "spacing_stat";
            this.spacing_stat.Size = new System.Drawing.Size(19, 13);
            this.spacing_stat.TabIndex = 38;
            this.spacing_stat.Text = "....";
            // 
            // No_stirrups_input
            // 
            this.No_stirrups_input.Location = new System.Drawing.Point(135, 434);
            this.No_stirrups_input.Name = "No_stirrups_input";
            this.No_stirrups_input.ReadOnly = true;
            this.No_stirrups_input.Size = new System.Drawing.Size(113, 20);
            this.No_stirrups_input.TabIndex = 20;
            this.No_stirrups_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // No_stirrups_label
            // 
            this.No_stirrups_label.AutoSize = true;
            this.No_stirrups_label.Location = new System.Drawing.Point(10, 438);
            this.No_stirrups_label.Name = "No_stirrups_label";
            this.No_stirrups_label.Size = new System.Drawing.Size(119, 13);
            this.No_stirrups_label.TabIndex = 40;
            this.No_stirrups_label.Text = "No. of stirrups per meter";
            // 
            // phi_input
            // 
            this.phi_input.FormattingEnabled = true;
            this.phi_input.Items.AddRange(new object[] {
            "8 ",
            "10",
            "12"});
            this.phi_input.Location = new System.Drawing.Point(88, 132);
            this.phi_input.Name = "phi_input";
            this.phi_input.Size = new System.Drawing.Size(66, 21);
            this.phi_input.TabIndex = 7;
            this.phi_input.Text = "8 ";
            this.phi_input.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // phi_label
            // 
            this.phi_label.AutoSize = true;
            this.phi_label.Location = new System.Drawing.Point(64, 117);
            this.phi_label.Name = "phi_label";
            this.phi_label.Size = new System.Drawing.Size(115, 13);
            this.phi_label.TabIndex = 42;
            this.phi_label.Text = "diameter of stirrup (mm)";
            // 
            // n_input
            // 
            this.n_input.FormattingEnabled = true;
            this.n_input.Items.AddRange(new object[] {
            "2",
            "4"});
            this.n_input.Location = new System.Drawing.Point(207, 132);
            this.n_input.Name = "n_input";
            this.n_input.Size = new System.Drawing.Size(66, 21);
            this.n_input.TabIndex = 8;
            this.n_input.Text = "2";
            // 
            // no_branch_label
            // 
            this.no_branch_label.AutoSize = true;
            this.no_branch_label.Location = new System.Drawing.Point(204, 115);
            this.no_branch_label.Name = "no_branch_label";
            this.no_branch_label.Size = new System.Drawing.Size(72, 13);
            this.no_branch_label.TabIndex = 47;
            this.no_branch_label.Text = "No. of branch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(148, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Results";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::shear_for_simple_beam.Properties.Resources.Screenshot_2024_09_22_030005;
            this.pictureBox2.Location = new System.Drawing.Point(341, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 137);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::shear_for_simple_beam.Properties.Resources.Screenshot_2024_09_22_025113;
            this.pictureBox1.Location = new System.Drawing.Point(341, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(374, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 39);
            this.label5.TabIndex = 49;
            this.label5.Text = "by: Fouad ismail Fouad\r\nProgramming task in the Digital \r\nEngineering Diploma at " +
    "KAITECH";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // welcom_form
            // 
            this.AcceptButton = this.start_button;
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(117)))), ((int)(((byte)(162)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(582, 470);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.n_input);
            this.Controls.Add(this.no_branch_label);
            this.Controls.Add(this.phi_input);
            this.Controls.Add(this.phi_label);
            this.Controls.Add(this.No_stirrups_input);
            this.Controls.Add(this.No_stirrups_label);
            this.Controls.Add(this.spacing_stat);
            this.Controls.Add(this.spacing);
            this.Controls.Add(this.spacing_label);
            this.Controls.Add(this.fy_input);
            this.Controls.Add(this.fy_label);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Shear_result_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qumax_input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.quncr_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qcr_input);
            this.Controls.Add(this.qcr_label);
            this.Controls.Add(this.qu_input);
            this.Controls.Add(this.qu_label);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Fcu_input);
            this.Controls.Add(this.min_width);
            this.Controls.Add(this.fcu_label);
            this.Controls.Add(this.min_width_label);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.Qcracked);
            this.Controls.Add(this.Q_cracked);
            this.Controls.Add(this.loction_con_load);
            this.Controls.Add(this.location_conLoad_label);
            this.Controls.Add(this.con_load);
            this.Controls.Add(this.con_load_label);
            this.Controls.Add(this.col_width);
            this.Controls.Add(this.column_label);
            this.Controls.Add(this.depth_label);
            this.Controls.Add(this.avilable_conload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dis_load);
            this.Controls.Add(this.load_label);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.length_label);
            this.Controls.Add(this.start_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "welcom_form";
            this.Text = "Shear Design for simple beam";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label length_label;
        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.TextBox dis_load;
        private System.Windows.Forms.Label load_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox avilable_conload;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.Label depth_label;
        private System.Windows.Forms.TextBox col_width;
        private System.Windows.Forms.Label column_label;
        private System.Windows.Forms.TextBox con_load;
        private System.Windows.Forms.Label con_load_label;
        private System.Windows.Forms.TextBox loction_con_load;
        private System.Windows.Forms.Label location_conLoad_label;
        private System.Windows.Forms.TextBox Qcracked;
        private System.Windows.Forms.Label Q_cracked;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label min_width_label;
        private System.Windows.Forms.Label fcu_label;
        private System.Windows.Forms.TextBox min_width;
        private System.Windows.Forms.TextBox Fcu_input;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox qu_input;
        private System.Windows.Forms.Label qu_label;
        private System.Windows.Forms.TextBox qcr_input;
        private System.Windows.Forms.Label qcr_label;
        private System.Windows.Forms.TextBox quncr_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox qumax_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label Shear_result_label;
        private System.Windows.Forms.TextBox fy_input;
        private System.Windows.Forms.Label fy_label;
        private System.Windows.Forms.Label spacing_label;
        private System.Windows.Forms.TextBox spacing;
        private System.Windows.Forms.Label spacing_stat;
        private System.Windows.Forms.TextBox No_stirrups_input;
        private System.Windows.Forms.Label No_stirrups_label;
        private System.Windows.Forms.ComboBox phi_input;
        private System.Windows.Forms.Label phi_label;
        private System.Windows.Forms.ComboBox n_input;
        private System.Windows.Forms.Label no_branch_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


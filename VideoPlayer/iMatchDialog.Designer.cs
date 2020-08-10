namespace Warp_Csharp
{
    partial class iMatchDialog
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
            this.btn_LoadColorImg = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_LoadGrayImg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_FinalReduction = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbx_usingrobust = new System.Windows.Forms.CheckBox();
            this.cbx_usingsubpixel = new System.Windows.Forms.CheckBox();
            this.tbx_sensitivy = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbx_MinReduceArea = new System.Windows.Forms.TextBox();
            this.cbx_ColorSimilarity = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbx_objnums = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbx_dontcarethreshold = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbx_dontcare = new System.Windows.Forms.CheckBox();
            this.cbx_scale = new System.Windows.Forms.CheckBox();
            this.cbx_rotation = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_minscale = new System.Windows.Forms.TextBox();
            this.tbx_maxscale = new System.Windows.Forms.TextBox();
            this.tbx_minang = new System.Windows.Forms.TextBox();
            this.tbx_maxang = new System.Windows.Forms.TextBox();
            this.tbx_minscore = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_NCCmatching = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obj_X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obj_Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Angle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_NCCtraining = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SaveModel = new System.Windows.Forms.Button();
            this.btn_ReadModel = new System.Windows.Forms.Button();
            this.chk_TrainingFromROI = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_DeleteMatchingROI = new System.Windows.Forms.Button();
            this.btn_MatchingROI = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbx_MatchingROI = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_LoadColorImg
            // 
            this.btn_LoadColorImg.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_LoadColorImg.Location = new System.Drawing.Point(12, 12);
            this.btn_LoadColorImg.Name = "btn_LoadColorImg";
            this.btn_LoadColorImg.Size = new System.Drawing.Size(117, 34);
            this.btn_LoadColorImg.TabIndex = 0;
            this.btn_LoadColorImg.Text = "Load Color Img";
            this.btn_LoadColorImg.UseVisualStyleBackColor = true;
            this.btn_LoadColorImg.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_Close.Location = new System.Drawing.Point(703, 382);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(119, 36);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_LoadGrayImg
            // 
            this.btn_LoadGrayImg.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_LoadGrayImg.Location = new System.Drawing.Point(12, 54);
            this.btn_LoadGrayImg.Name = "btn_LoadGrayImg";
            this.btn_LoadGrayImg.Size = new System.Drawing.Size(117, 34);
            this.btn_LoadGrayImg.TabIndex = 2;
            this.btn_LoadGrayImg.Text = "Load Gray Img";
            this.btn_LoadGrayImg.UseVisualStyleBackColor = true;
            this.btn_LoadGrayImg.Click += new System.EventHandler(this.btn_LoadGrayImg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(596, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "State :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(660, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "NULL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_FinalReduction);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.cbx_usingrobust);
            this.groupBox1.Controls.Add(this.cbx_usingsubpixel);
            this.groupBox1.Controls.Add(this.tbx_sensitivy);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tbx_MinReduceArea);
            this.groupBox1.Controls.Add(this.cbx_ColorSimilarity);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.tbx_objnums);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.tbx_dontcarethreshold);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbx_dontcare);
            this.groupBox1.Controls.Add(this.cbx_scale);
            this.groupBox1.Controls.Add(this.cbx_rotation);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbx_minscale);
            this.groupBox1.Controls.Add(this.tbx_maxscale);
            this.groupBox1.Controls.Add(this.tbx_minang);
            this.groupBox1.Controls.Add(this.tbx_maxang);
            this.groupBox1.Controls.Add(this.tbx_minscore);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(145, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 413);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "iMatch Parameter";
            // 
            // tbx_FinalReduction
            // 
            this.tbx_FinalReduction.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_FinalReduction.Location = new System.Drawing.Point(119, 300);
            this.tbx_FinalReduction.Name = "tbx_FinalReduction";
            this.tbx_FinalReduction.Size = new System.Drawing.Size(49, 27);
            this.tbx_FinalReduction.TabIndex = 83;
            this.tbx_FinalReduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(11, 303);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 16);
            this.label17.TabIndex = 82;
            this.label17.Text = "Final Reduction";
            this.label17.UseMnemonic = false;
            // 
            // cbx_usingrobust
            // 
            this.cbx_usingrobust.AutoSize = true;
            this.cbx_usingrobust.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_usingrobust.Location = new System.Drawing.Point(11, 351);
            this.cbx_usingrobust.Name = "cbx_usingrobust";
            this.cbx_usingrobust.Size = new System.Drawing.Size(113, 17);
            this.cbx_usingrobust.TabIndex = 81;
            this.cbx_usingrobust.Text = "Using Robustness";
            this.cbx_usingrobust.UseVisualStyleBackColor = true;
            // 
            // cbx_usingsubpixel
            // 
            this.cbx_usingsubpixel.AutoSize = true;
            this.cbx_usingsubpixel.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_usingsubpixel.Location = new System.Drawing.Point(11, 332);
            this.cbx_usingsubpixel.Name = "cbx_usingsubpixel";
            this.cbx_usingsubpixel.Size = new System.Drawing.Size(100, 17);
            this.cbx_usingsubpixel.TabIndex = 80;
            this.cbx_usingsubpixel.Text = "Using Subpixel";
            this.cbx_usingsubpixel.UseVisualStyleBackColor = true;
            // 
            // tbx_sensitivy
            // 
            this.tbx_sensitivy.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_sensitivy.Location = new System.Drawing.Point(119, 387);
            this.tbx_sensitivy.Name = "tbx_sensitivy";
            this.tbx_sensitivy.Size = new System.Drawing.Size(52, 23);
            this.tbx_sensitivy.TabIndex = 54;
            this.tbx_sensitivy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(8, 392);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "Sensitivy (0-100%)";
            // 
            // tbx_MinReduceArea
            // 
            this.tbx_MinReduceArea.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_MinReduceArea.Location = new System.Drawing.Point(120, 273);
            this.tbx_MinReduceArea.Name = "tbx_MinReduceArea";
            this.tbx_MinReduceArea.Size = new System.Drawing.Size(49, 27);
            this.tbx_MinReduceArea.TabIndex = 41;
            this.tbx_MinReduceArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbx_ColorSimilarity
            // 
            this.cbx_ColorSimilarity.AutoSize = true;
            this.cbx_ColorSimilarity.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_ColorSimilarity.Location = new System.Drawing.Point(11, 369);
            this.cbx_ColorSimilarity.Name = "cbx_ColorSimilarity";
            this.cbx_ColorSimilarity.Size = new System.Drawing.Size(135, 17);
            this.cbx_ColorSimilarity.TabIndex = 52;
            this.cbx_ColorSimilarity.Text = "Using Color Similarity";
            this.cbx_ColorSimilarity.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(8, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 16);
            this.label14.TabIndex = 40;
            this.label14.Text = "MinReduceArea";
            this.label14.UseMnemonic = false;
            // 
            // tbx_objnums
            // 
            this.tbx_objnums.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_objnums.Location = new System.Drawing.Point(80, 149);
            this.tbx_objnums.Name = "tbx_objnums";
            this.tbx_objnums.Size = new System.Drawing.Size(61, 27);
            this.tbx_objnums.TabIndex = 39;
            this.tbx_objnums.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(7, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 16);
            this.label12.TabIndex = 38;
            this.label12.Text = "Objnum";
            // 
            // tbx_dontcarethreshold
            // 
            this.tbx_dontcarethreshold.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_dontcarethreshold.Location = new System.Drawing.Point(120, 245);
            this.tbx_dontcarethreshold.Name = "tbx_dontcarethreshold";
            this.tbx_dontcarethreshold.Size = new System.Drawing.Size(49, 27);
            this.tbx_dontcarethreshold.TabIndex = 37;
            this.tbx_dontcarethreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(8, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "Don\'t Care value";
            this.label11.UseMnemonic = false;
            // 
            // cbx_dontcare
            // 
            this.cbx_dontcare.AutoSize = true;
            this.cbx_dontcare.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_dontcare.Location = new System.Drawing.Point(122, 223);
            this.cbx_dontcare.Name = "cbx_dontcare";
            this.cbx_dontcare.Size = new System.Drawing.Size(51, 20);
            this.cbx_dontcare.TabIndex = 35;
            this.cbx_dontcare.Text = "Yes";
            this.cbx_dontcare.UseVisualStyleBackColor = true;
            // 
            // cbx_scale
            // 
            this.cbx_scale.AutoSize = true;
            this.cbx_scale.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_scale.Location = new System.Drawing.Point(122, 201);
            this.cbx_scale.Name = "cbx_scale";
            this.cbx_scale.Size = new System.Drawing.Size(51, 20);
            this.cbx_scale.TabIndex = 34;
            this.cbx_scale.Text = "Yes";
            this.cbx_scale.UseVisualStyleBackColor = true;
            // 
            // cbx_rotation
            // 
            this.cbx_rotation.AutoSize = true;
            this.cbx_rotation.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbx_rotation.Location = new System.Drawing.Point(122, 178);
            this.cbx_rotation.Name = "cbx_rotation";
            this.cbx_rotation.Size = new System.Drawing.Size(51, 20);
            this.cbx_rotation.TabIndex = 33;
            this.cbx_rotation.Text = "Yes";
            this.cbx_rotation.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(8, 224);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Using Don\'t Care";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(8, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "UsingScale";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(8, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "UsingRotation";
            // 
            // tbx_minscale
            // 
            this.tbx_minscale.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_minscale.Location = new System.Drawing.Point(80, 123);
            this.tbx_minscale.Name = "tbx_minscale";
            this.tbx_minscale.Size = new System.Drawing.Size(61, 27);
            this.tbx_minscale.TabIndex = 29;
            this.tbx_minscale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_maxscale
            // 
            this.tbx_maxscale.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_maxscale.Location = new System.Drawing.Point(80, 98);
            this.tbx_maxscale.Name = "tbx_maxscale";
            this.tbx_maxscale.Size = new System.Drawing.Size(61, 27);
            this.tbx_maxscale.TabIndex = 28;
            this.tbx_maxscale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_minang
            // 
            this.tbx_minang.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_minang.Location = new System.Drawing.Point(80, 73);
            this.tbx_minang.Name = "tbx_minang";
            this.tbx_minang.Size = new System.Drawing.Size(61, 27);
            this.tbx_minang.TabIndex = 27;
            this.tbx_minang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_maxang
            // 
            this.tbx_maxang.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_maxang.Location = new System.Drawing.Point(80, 48);
            this.tbx_maxang.Name = "tbx_maxang";
            this.tbx_maxang.Size = new System.Drawing.Size(61, 27);
            this.tbx_maxang.TabIndex = 26;
            this.tbx_maxang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_minscore
            // 
            this.tbx_minscore.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbx_minscore.Location = new System.Drawing.Point(80, 23);
            this.tbx_minscore.Name = "tbx_minscore";
            this.tbx_minscore.Size = new System.Drawing.Size(61, 27);
            this.tbx_minscore.TabIndex = 25;
            this.tbx_minscore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(6, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "MinScale";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(6, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "MaxScale";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "MinAngle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "MaxAngle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "MinScore";
            // 
            // btn_NCCmatching
            // 
            this.btn_NCCmatching.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_NCCmatching.Location = new System.Drawing.Point(12, 160);
            this.btn_NCCmatching.Name = "btn_NCCmatching";
            this.btn_NCCmatching.Size = new System.Drawing.Size(117, 34);
            this.btn_NCCmatching.TabIndex = 25;
            this.btn_NCCmatching.Text = "Matching";
            this.btn_NCCmatching.UseVisualStyleBackColor = true;
            this.btn_NCCmatching.Click += new System.EventHandler(this.btn_NCCmatching_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Score,
            this.obj_X,
            this.obj_Y,
            this.Angle,
            this.Scale,
            this.time});
            this.dataGridView1.Location = new System.Drawing.Point(328, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(494, 300);
            this.dataGridView1.TabIndex = 26;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Score.Width = 75;
            // 
            // obj_X
            // 
            this.obj_X.HeaderText = "objX";
            this.obj_X.Name = "obj_X";
            this.obj_X.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.obj_X.Width = 75;
            // 
            // obj_Y
            // 
            this.obj_Y.HeaderText = "obj_Y";
            this.obj_Y.Name = "obj_Y";
            this.obj_Y.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.obj_Y.Width = 75;
            // 
            // Angle
            // 
            this.Angle.HeaderText = "Angle";
            this.Angle.Name = "Angle";
            this.Angle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Angle.Width = 75;
            // 
            // Scale
            // 
            this.Scale.HeaderText = "Scale";
            this.Scale.Name = "Scale";
            this.Scale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Scale.Width = 75;
            // 
            // time
            // 
            this.time.HeaderText = "time(ms)";
            this.time.Name = "time";
            this.time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.time.Width = 75;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("PMingLiU", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(324, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(215, 27);
            this.label13.TabIndex = 27;
            this.label13.Text = "Results Information";
            // 
            // btn_NCCtraining
            // 
            this.btn_NCCtraining.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_NCCtraining.Location = new System.Drawing.Point(12, 94);
            this.btn_NCCtraining.Name = "btn_NCCtraining";
            this.btn_NCCtraining.Size = new System.Drawing.Size(117, 34);
            this.btn_NCCtraining.TabIndex = 28;
            this.btn_NCCtraining.Text = "Training";
            this.btn_NCCtraining.UseVisualStyleBackColor = true;
            this.btn_NCCtraining.Click += new System.EventHandler(this.btn_NCCtraining_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(9, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 16);
            this.label15.TabIndex = 42;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SaveModel);
            this.groupBox2.Controls.Add(this.btn_ReadModel);
            this.groupBox2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(328, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 80);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MatchModel";
            // 
            // btn_SaveModel
            // 
            this.btn_SaveModel.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_SaveModel.Location = new System.Drawing.Point(131, 29);
            this.btn_SaveModel.Name = "btn_SaveModel";
            this.btn_SaveModel.Size = new System.Drawing.Size(119, 36);
            this.btn_SaveModel.TabIndex = 44;
            this.btn_SaveModel.Text = "Save Match Model";
            this.btn_SaveModel.UseVisualStyleBackColor = true;
            this.btn_SaveModel.Click += new System.EventHandler(this.btn_SaveModel_Click);
            // 
            // btn_ReadModel
            // 
            this.btn_ReadModel.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn_ReadModel.Location = new System.Drawing.Point(6, 29);
            this.btn_ReadModel.Name = "btn_ReadModel";
            this.btn_ReadModel.Size = new System.Drawing.Size(119, 36);
            this.btn_ReadModel.TabIndex = 43;
            this.btn_ReadModel.Text = "Read Match Model";
            this.btn_ReadModel.UseVisualStyleBackColor = true;
            this.btn_ReadModel.Click += new System.EventHandler(this.btn_ReadModel_Click);
            // 
            // chk_TrainingFromROI
            // 
            this.chk_TrainingFromROI.AutoSize = true;
            this.chk_TrainingFromROI.Checked = true;
            this.chk_TrainingFromROI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_TrainingFromROI.Location = new System.Drawing.Point(20, 135);
            this.chk_TrainingFromROI.Name = "chk_TrainingFromROI";
            this.chk_TrainingFromROI.Size = new System.Drawing.Size(109, 16);
            this.chk_TrainingFromROI.TabIndex = 45;
            this.chk_TrainingFromROI.Text = "TrainingFromROI";
            this.chk_TrainingFromROI.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_DeleteMatchingROI);
            this.groupBox3.Controls.Add(this.btn_MatchingROI);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(8, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(131, 144);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ROI";
            // 
            // btn_DeleteMatchingROI
            // 
            this.btn_DeleteMatchingROI.Location = new System.Drawing.Point(8, 98);
            this.btn_DeleteMatchingROI.Name = "btn_DeleteMatchingROI";
            this.btn_DeleteMatchingROI.Size = new System.Drawing.Size(117, 34);
            this.btn_DeleteMatchingROI.TabIndex = 2;
            this.btn_DeleteMatchingROI.Text = "Delete Matching ROI";
            this.btn_DeleteMatchingROI.UseVisualStyleBackColor = true;
            this.btn_DeleteMatchingROI.Click += new System.EventHandler(this.btn_DeleteMatchingROI_Click);
            // 
            // btn_MatchingROI
            // 
            this.btn_MatchingROI.Location = new System.Drawing.Point(8, 58);
            this.btn_MatchingROI.Name = "btn_MatchingROI";
            this.btn_MatchingROI.Size = new System.Drawing.Size(117, 34);
            this.btn_MatchingROI.TabIndex = 1;
            this.btn_MatchingROI.Text = "Add Matching ROI";
            this.btn_MatchingROI.UseVisualStyleBackColor = true;
            this.btn_MatchingROI.Click += new System.EventHandler(this.btn_MatchingROI_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 34);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add Training ROI";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.AddBaseROI);
            // 
            // cbx_MatchingROI
            // 
            this.cbx_MatchingROI.AutoSize = true;
            this.cbx_MatchingROI.Location = new System.Drawing.Point(20, 199);
            this.cbx_MatchingROI.Name = "cbx_MatchingROI";
            this.cbx_MatchingROI.Size = new System.Drawing.Size(113, 16);
            this.cbx_MatchingROI.TabIndex = 48;
            this.cbx_MatchingROI.Text = "MatchingFromROI";
            this.cbx_MatchingROI.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 36);
            this.button1.TabIndex = 49;
            this.button1.Text = "iVisitingKey";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iMatchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 427);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbx_MatchingROI);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.chk_TrainingFromROI);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_NCCtraining);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_NCCmatching);
            this.Controls.Add(this.btn_LoadGrayImg);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_LoadColorImg);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "iMatchDialog";
            this.Text = "iMatchDialog";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LoadColorImg;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_LoadGrayImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_dontcarethreshold;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbx_dontcare;
        private System.Windows.Forms.CheckBox cbx_scale;
        private System.Windows.Forms.CheckBox cbx_rotation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_minscale;
        private System.Windows.Forms.TextBox tbx_maxscale;
        private System.Windows.Forms.TextBox tbx_minang;
        private System.Windows.Forms.TextBox tbx_maxang;
        private System.Windows.Forms.TextBox tbx_minscore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_objnums;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_NCCmatching;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.DataGridViewTextBoxColumn obj_X;
        private System.Windows.Forms.DataGridViewTextBoxColumn obj_Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Angle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scale;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.Button btn_NCCtraining;
        private System.Windows.Forms.TextBox tbx_MinReduceArea;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_SaveModel;
        private System.Windows.Forms.Button btn_ReadModel;
        private System.Windows.Forms.CheckBox chk_TrainingFromROI;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.CheckBox cbx_MatchingROI;
        private System.Windows.Forms.Button btn_MatchingROI;
        private System.Windows.Forms.Button btn_DeleteMatchingROI;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbx_sensitivy;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cbx_ColorSimilarity;
        private System.Windows.Forms.CheckBox cbx_usingrobust;
        private System.Windows.Forms.CheckBox cbx_usingsubpixel;
        private System.Windows.Forms.TextBox tbx_FinalReduction;
        private System.Windows.Forms.Label label17;
    }
}
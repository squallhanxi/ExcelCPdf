namespace ExcelCPdf
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.load_button = new System.Windows.Forms.Button();
            this.pdf_pictureBox = new System.Windows.Forms.PictureBox();
            this.pdfdir_folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.pdfdir_button = new System.Windows.Forms.Button();
            this.exceldir_button = new System.Windows.Forms.Button();
            this.exceldir_openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pdfdir_textBox = new System.Windows.Forms.TextBox();
            this.exceldir_textBox = new System.Windows.Forms.TextBox();
            this.filenamecol_label = new System.Windows.Forms.Label();
            this.iden_label = new System.Windows.Forms.Label();
            this.filenamecol_textBox = new System.Windows.Forms.TextBox();
            this.idencol_textBox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.num_label = new System.Windows.Forms.Label();
            this.batch_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.num_textBox = new System.Windows.Forms.TextBox();
            this.batch_textBox = new System.Windows.Forms.TextBox();
            this.previous_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.namecol_label = new System.Windows.Forms.Label();
            this.numcol_label = new System.Windows.Forms.Label();
            this.batchcol_label = new System.Windows.Forms.Label();
            this.namecol_textBox = new System.Windows.Forms.TextBox();
            this.numcol_textBox = new System.Windows.Forms.TextBox();
            this.batchcol_textBox = new System.Windows.Forms.TextBox();
            this.idenmsg_label = new System.Windows.Forms.Label();
            this.idenmsg_textBox = new System.Windows.Forms.TextBox();
            this.msg_richTextBox = new System.Windows.Forms.RichTextBox();
            this.idenmsg_button = new System.Windows.Forms.Button();
            this.row_textBox = new System.Windows.Forms.TextBox();
            this.check_groupBox = new System.Windows.Forms.GroupBox();
            this.idencolor_textBox = new System.Windows.Forms.TextBox();
            this.idencolor_button = new System.Windows.Forms.Button();
            this.m4_textBox = new System.Windows.Forms.TextBox();
            this.m4_label = new System.Windows.Forms.Label();
            this.m3_textBox = new System.Windows.Forms.TextBox();
            this.m2_textBox = new System.Windows.Forms.TextBox();
            this.m1_textBox = new System.Windows.Forms.TextBox();
            this.m3_label = new System.Windows.Forms.Label();
            this.m2_label = new System.Windows.Forms.Label();
            this.m1_label = new System.Windows.Forms.Label();
            this.mode_label = new System.Windows.Forms.Label();
            this.mode_textBox = new System.Windows.Forms.TextBox();
            this.reason_label = new System.Windows.Forms.Label();
            this.reason_textBox = new System.Windows.Forms.TextBox();
            this.pageredirect_button = new System.Windows.Forms.Button();
            this.pageredirect_textBox = new System.Windows.Forms.TextBox();
            this.redirect_label = new System.Windows.Forms.Label();
            this.pdfpagerot_button = new System.Windows.Forms.Button();
            this.notfilter_label = new System.Windows.Forms.Label();
            this.notfilter_textBox = new System.Windows.Forms.TextBox();
            this.notequ_label = new System.Windows.Forms.Label();
            this.notequ_textBox = new System.Windows.Forms.TextBox();
            this.pdfpagedown_button = new System.Windows.Forms.Button();
            this.pdfpageup_button = new System.Windows.Forms.Button();
            this.notequcol_label = new System.Windows.Forms.Label();
            this.notequcol_textBox = new System.Windows.Forms.TextBox();
            this.notfiltercol_textBox = new System.Windows.Forms.TextBox();
            this.notfiltercol_label = new System.Windows.Forms.Label();
            this.reasoncol_label = new System.Windows.Forms.Label();
            this.reasoncol_textBox = new System.Windows.Forms.TextBox();
            this.iscopypdf_checkBox = new System.Windows.Forms.CheckBox();
            this.copypdf_textBox = new System.Windows.Forms.TextBox();
            this.copypdf_button = new System.Windows.Forms.Button();
            this.copypdf_folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.m4col_textBox = new System.Windows.Forms.TextBox();
            this.m4col_label = new System.Windows.Forms.Label();
            this.m3col_textBox = new System.Windows.Forms.TextBox();
            this.m3col_label = new System.Windows.Forms.Label();
            this.m1col_textBox = new System.Windows.Forms.TextBox();
            this.modecol_textBox = new System.Windows.Forms.TextBox();
            this.m1col_label = new System.Windows.Forms.Label();
            this.modecol_label = new System.Windows.Forms.Label();
            this.m2col_textBox = new System.Windows.Forms.TextBox();
            this.m2col_label = new System.Windows.Forms.Label();
            this.iden_colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pdf_pictureBox)).BeginInit();
            this.check_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(12, 23);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(336, 44);
            this.load_button.TabIndex = 0;
            this.load_button.Text = "加载文档";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // pdf_pictureBox
            // 
            this.pdf_pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pdf_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pdf_pictureBox.ErrorImage = null;
            this.pdf_pictureBox.InitialImage = null;
            this.pdf_pictureBox.Location = new System.Drawing.Point(12, 87);
            this.pdf_pictureBox.Name = "pdf_pictureBox";
            this.pdf_pictureBox.Size = new System.Drawing.Size(831, 583);
            this.pdf_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pdf_pictureBox.TabIndex = 1;
            this.pdf_pictureBox.TabStop = false;
            this.pdf_pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pdf_pictureBox_MouseDown);
            this.pdf_pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pdf_pictureBox_MouseMove);
            // 
            // pdfdir_button
            // 
            this.pdfdir_button.Location = new System.Drawing.Point(12, 12);
            this.pdfdir_button.Name = "pdfdir_button";
            this.pdfdir_button.Size = new System.Drawing.Size(76, 31);
            this.pdfdir_button.TabIndex = 2;
            this.pdfdir_button.Text = "装机证路径";
            this.pdfdir_button.UseVisualStyleBackColor = true;
            this.pdfdir_button.Click += new System.EventHandler(this.pdfdir_button_Click);
            // 
            // exceldir_button
            // 
            this.exceldir_button.Location = new System.Drawing.Point(12, 50);
            this.exceldir_button.Name = "exceldir_button";
            this.exceldir_button.Size = new System.Drawing.Size(76, 31);
            this.exceldir_button.TabIndex = 3;
            this.exceldir_button.Text = "EXCEL路径";
            this.exceldir_button.UseVisualStyleBackColor = true;
            this.exceldir_button.Click += new System.EventHandler(this.exceldir_button_Click);
            // 
            // exceldir_openFileDialog
            // 
            this.exceldir_openFileDialog.FileName = "openFileDialog1";
            // 
            // pdfdir_textBox
            // 
            this.pdfdir_textBox.Location = new System.Drawing.Point(94, 18);
            this.pdfdir_textBox.Name = "pdfdir_textBox";
            this.pdfdir_textBox.Size = new System.Drawing.Size(143, 21);
            this.pdfdir_textBox.TabIndex = 4;
            // 
            // exceldir_textBox
            // 
            this.exceldir_textBox.Location = new System.Drawing.Point(94, 56);
            this.exceldir_textBox.Name = "exceldir_textBox";
            this.exceldir_textBox.Size = new System.Drawing.Size(143, 21);
            this.exceldir_textBox.TabIndex = 5;
            // 
            // filenamecol_label
            // 
            this.filenamecol_label.AutoSize = true;
            this.filenamecol_label.Location = new System.Drawing.Point(412, 27);
            this.filenamecol_label.Name = "filenamecol_label";
            this.filenamecol_label.Size = new System.Drawing.Size(77, 12);
            this.filenamecol_label.TabIndex = 6;
            this.filenamecol_label.Text = "装机证号列：";
            // 
            // iden_label
            // 
            this.iden_label.AutoSize = true;
            this.iden_label.Location = new System.Drawing.Point(634, 27);
            this.iden_label.Name = "iden_label";
            this.iden_label.Size = new System.Drawing.Size(53, 12);
            this.iden_label.TabIndex = 7;
            this.iden_label.Text = "标识列：";
            // 
            // filenamecol_textBox
            // 
            this.filenamecol_textBox.Location = new System.Drawing.Point(487, 23);
            this.filenamecol_textBox.Name = "filenamecol_textBox";
            this.filenamecol_textBox.Size = new System.Drawing.Size(30, 21);
            this.filenamecol_textBox.TabIndex = 8;
            this.filenamecol_textBox.Text = "19";
            // 
            // idencol_textBox
            // 
            this.idencol_textBox.Location = new System.Drawing.Point(694, 22);
            this.idencol_textBox.Name = "idencol_textBox";
            this.idencol_textBox.Size = new System.Drawing.Size(30, 21);
            this.idencol_textBox.TabIndex = 9;
            this.idencol_textBox.Text = "29";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(12, 86);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(119, 12);
            this.name_label.TabIndex = 10;
            this.name_label.Text = "EXCEL中元器件名称：";
            // 
            // num_label
            // 
            this.num_label.AutoSize = true;
            this.num_label.Location = new System.Drawing.Point(12, 144);
            this.num_label.Name = "num_label";
            this.num_label.Size = new System.Drawing.Size(119, 12);
            this.num_label.TabIndex = 11;
            this.num_label.Text = "EXCEL中元器件数量：";
            // 
            // batch_label
            // 
            this.batch_label.AutoSize = true;
            this.batch_label.Location = new System.Drawing.Point(12, 174);
            this.batch_label.Name = "batch_label";
            this.batch_label.Size = new System.Drawing.Size(119, 12);
            this.batch_label.TabIndex = 12;
            this.batch_label.Text = "EXCEL中元器件批次：";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(135, 81);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(213, 21);
            this.name_textBox.TabIndex = 13;
            // 
            // num_textBox
            // 
            this.num_textBox.Location = new System.Drawing.Point(135, 141);
            this.num_textBox.Name = "num_textBox";
            this.num_textBox.Size = new System.Drawing.Size(213, 21);
            this.num_textBox.TabIndex = 14;
            // 
            // batch_textBox
            // 
            this.batch_textBox.Location = new System.Drawing.Point(135, 170);
            this.batch_textBox.Name = "batch_textBox";
            this.batch_textBox.Size = new System.Drawing.Size(213, 21);
            this.batch_textBox.TabIndex = 15;
            // 
            // previous_button
            // 
            this.previous_button.Enabled = false;
            this.previous_button.Location = new System.Drawing.Point(12, 450);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(162, 48);
            this.previous_button.TabIndex = 16;
            this.previous_button.Text = "上一条信息";
            this.previous_button.UseVisualStyleBackColor = true;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // next_button
            // 
            this.next_button.Enabled = false;
            this.next_button.Location = new System.Drawing.Point(186, 450);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(162, 48);
            this.next_button.TabIndex = 17;
            this.next_button.Text = "下一条信息";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // namecol_label
            // 
            this.namecol_label.AutoSize = true;
            this.namecol_label.Location = new System.Drawing.Point(412, 55);
            this.namecol_label.Name = "namecol_label";
            this.namecol_label.Size = new System.Drawing.Size(53, 12);
            this.namecol_label.TabIndex = 18;
            this.namecol_label.Text = "名称列：";
            // 
            // numcol_label
            // 
            this.numcol_label.AutoSize = true;
            this.numcol_label.Location = new System.Drawing.Point(534, 27);
            this.numcol_label.Name = "numcol_label";
            this.numcol_label.Size = new System.Drawing.Size(53, 12);
            this.numcol_label.TabIndex = 19;
            this.numcol_label.Text = "数量列：";
            // 
            // batchcol_label
            // 
            this.batchcol_label.AutoSize = true;
            this.batchcol_label.Location = new System.Drawing.Point(534, 55);
            this.batchcol_label.Name = "batchcol_label";
            this.batchcol_label.Size = new System.Drawing.Size(53, 12);
            this.batchcol_label.TabIndex = 20;
            this.batchcol_label.Text = "批次列：";
            // 
            // namecol_textBox
            // 
            this.namecol_textBox.Location = new System.Drawing.Point(487, 52);
            this.namecol_textBox.Name = "namecol_textBox";
            this.namecol_textBox.Size = new System.Drawing.Size(30, 21);
            this.namecol_textBox.TabIndex = 21;
            this.namecol_textBox.Text = "3";
            // 
            // numcol_textBox
            // 
            this.numcol_textBox.Location = new System.Drawing.Point(586, 22);
            this.numcol_textBox.Name = "numcol_textBox";
            this.numcol_textBox.Size = new System.Drawing.Size(30, 21);
            this.numcol_textBox.TabIndex = 22;
            this.numcol_textBox.Text = "7";
            // 
            // batchcol_textBox
            // 
            this.batchcol_textBox.Location = new System.Drawing.Point(586, 50);
            this.batchcol_textBox.Name = "batchcol_textBox";
            this.batchcol_textBox.Size = new System.Drawing.Size(30, 21);
            this.batchcol_textBox.TabIndex = 23;
            this.batchcol_textBox.Text = "18";
            // 
            // idenmsg_label
            // 
            this.idenmsg_label.AutoSize = true;
            this.idenmsg_label.Location = new System.Drawing.Point(92, 514);
            this.idenmsg_label.Name = "idenmsg_label";
            this.idenmsg_label.Size = new System.Drawing.Size(65, 12);
            this.idenmsg_label.TabIndex = 24;
            this.idenmsg_label.Text = "标识信息：";
            // 
            // idenmsg_textBox
            // 
            this.idenmsg_textBox.Location = new System.Drawing.Point(155, 511);
            this.idenmsg_textBox.Name = "idenmsg_textBox";
            this.idenmsg_textBox.Size = new System.Drawing.Size(163, 21);
            this.idenmsg_textBox.TabIndex = 25;
            // 
            // msg_richTextBox
            // 
            this.msg_richTextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.msg_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msg_richTextBox.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msg_richTextBox.ForeColor = System.Drawing.Color.Red;
            this.msg_richTextBox.Location = new System.Drawing.Point(119, 201);
            this.msg_richTextBox.Name = "msg_richTextBox";
            this.msg_richTextBox.Size = new System.Drawing.Size(214, 189);
            this.msg_richTextBox.TabIndex = 26;
            this.msg_richTextBox.Text = "";
            // 
            // idenmsg_button
            // 
            this.idenmsg_button.Enabled = false;
            this.idenmsg_button.Location = new System.Drawing.Point(155, 538);
            this.idenmsg_button.Name = "idenmsg_button";
            this.idenmsg_button.Size = new System.Drawing.Size(193, 33);
            this.idenmsg_button.TabIndex = 27;
            this.idenmsg_button.Text = "标识";
            this.idenmsg_button.UseVisualStyleBackColor = true;
            this.idenmsg_button.Click += new System.EventHandler(this.idenmsg_button_Click);
            // 
            // row_textBox
            // 
            this.row_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.row_textBox.Location = new System.Drawing.Point(12, 426);
            this.row_textBox.Name = "row_textBox";
            this.row_textBox.ReadOnly = true;
            this.row_textBox.Size = new System.Drawing.Size(135, 14);
            this.row_textBox.TabIndex = 28;
            this.row_textBox.Text = "0 / 0";
            // 
            // check_groupBox
            // 
            this.check_groupBox.Controls.Add(this.idencolor_textBox);
            this.check_groupBox.Controls.Add(this.idencolor_button);
            this.check_groupBox.Controls.Add(this.m4_textBox);
            this.check_groupBox.Controls.Add(this.m4_label);
            this.check_groupBox.Controls.Add(this.m3_textBox);
            this.check_groupBox.Controls.Add(this.m2_textBox);
            this.check_groupBox.Controls.Add(this.m1_textBox);
            this.check_groupBox.Controls.Add(this.m3_label);
            this.check_groupBox.Controls.Add(this.m2_label);
            this.check_groupBox.Controls.Add(this.m1_label);
            this.check_groupBox.Controls.Add(this.mode_label);
            this.check_groupBox.Controls.Add(this.mode_textBox);
            this.check_groupBox.Controls.Add(this.reason_label);
            this.check_groupBox.Controls.Add(this.reason_textBox);
            this.check_groupBox.Controls.Add(this.pageredirect_button);
            this.check_groupBox.Controls.Add(this.pageredirect_textBox);
            this.check_groupBox.Controls.Add(this.redirect_label);
            this.check_groupBox.Controls.Add(this.pdfpagerot_button);
            this.check_groupBox.Controls.Add(this.notfilter_label);
            this.check_groupBox.Controls.Add(this.notfilter_textBox);
            this.check_groupBox.Controls.Add(this.notequ_label);
            this.check_groupBox.Controls.Add(this.notequ_textBox);
            this.check_groupBox.Controls.Add(this.pdfpagedown_button);
            this.check_groupBox.Controls.Add(this.pdfpageup_button);
            this.check_groupBox.Controls.Add(this.load_button);
            this.check_groupBox.Controls.Add(this.row_textBox);
            this.check_groupBox.Controls.Add(this.name_label);
            this.check_groupBox.Controls.Add(this.idenmsg_button);
            this.check_groupBox.Controls.Add(this.num_label);
            this.check_groupBox.Controls.Add(this.batch_label);
            this.check_groupBox.Controls.Add(this.idenmsg_textBox);
            this.check_groupBox.Controls.Add(this.name_textBox);
            this.check_groupBox.Controls.Add(this.idenmsg_label);
            this.check_groupBox.Controls.Add(this.num_textBox);
            this.check_groupBox.Controls.Add(this.batch_textBox);
            this.check_groupBox.Controls.Add(this.previous_button);
            this.check_groupBox.Controls.Add(this.next_button);
            this.check_groupBox.Location = new System.Drawing.Point(850, 87);
            this.check_groupBox.Name = "check_groupBox";
            this.check_groupBox.Size = new System.Drawing.Size(359, 583);
            this.check_groupBox.TabIndex = 29;
            this.check_groupBox.TabStop = false;
            this.check_groupBox.Text = "核对区：";
            // 
            // idencolor_textBox
            // 
            this.idencolor_textBox.BackColor = System.Drawing.SystemColors.Window;
            this.idencolor_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idencolor_textBox.Location = new System.Drawing.Point(324, 511);
            this.idencolor_textBox.Name = "idencolor_textBox";
            this.idencolor_textBox.ReadOnly = true;
            this.idencolor_textBox.Size = new System.Drawing.Size(24, 21);
            this.idencolor_textBox.TabIndex = 55;
            // 
            // idencolor_button
            // 
            this.idencolor_button.Location = new System.Drawing.Point(106, 538);
            this.idencolor_button.Name = "idencolor_button";
            this.idencolor_button.Size = new System.Drawing.Size(43, 33);
            this.idencolor_button.TabIndex = 54;
            this.idencolor_button.Text = "颜色";
            this.idencolor_button.UseVisualStyleBackColor = true;
            this.idencolor_button.Click += new System.EventHandler(this.idencolor_button_Click);
            // 
            // m4_textBox
            // 
            this.m4_textBox.Location = new System.Drawing.Point(135, 374);
            this.m4_textBox.Name = "m4_textBox";
            this.m4_textBox.Size = new System.Drawing.Size(213, 21);
            this.m4_textBox.TabIndex = 53;
            // 
            // m4_label
            // 
            this.m4_label.AutoSize = true;
            this.m4_label.Location = new System.Drawing.Point(60, 377);
            this.m4_label.Name = "m4_label";
            this.m4_label.Size = new System.Drawing.Size(71, 12);
            this.m4_label.TabIndex = 52;
            this.m4_label.Text = "其他信息4：";
            // 
            // m3_textBox
            // 
            this.m3_textBox.Location = new System.Drawing.Point(135, 346);
            this.m3_textBox.Name = "m3_textBox";
            this.m3_textBox.Size = new System.Drawing.Size(213, 21);
            this.m3_textBox.TabIndex = 51;
            // 
            // m2_textBox
            // 
            this.m2_textBox.Location = new System.Drawing.Point(135, 316);
            this.m2_textBox.Name = "m2_textBox";
            this.m2_textBox.Size = new System.Drawing.Size(213, 21);
            this.m2_textBox.TabIndex = 50;
            // 
            // m1_textBox
            // 
            this.m1_textBox.Location = new System.Drawing.Point(135, 286);
            this.m1_textBox.Name = "m1_textBox";
            this.m1_textBox.Size = new System.Drawing.Size(213, 21);
            this.m1_textBox.TabIndex = 49;
            // 
            // m3_label
            // 
            this.m3_label.AutoSize = true;
            this.m3_label.Location = new System.Drawing.Point(60, 351);
            this.m3_label.Name = "m3_label";
            this.m3_label.Size = new System.Drawing.Size(71, 12);
            this.m3_label.TabIndex = 48;
            this.m3_label.Text = "其他信息3：";
            // 
            // m2_label
            // 
            this.m2_label.AutoSize = true;
            this.m2_label.Location = new System.Drawing.Point(60, 321);
            this.m2_label.Name = "m2_label";
            this.m2_label.Size = new System.Drawing.Size(71, 12);
            this.m2_label.TabIndex = 47;
            this.m2_label.Text = "其他信息2：";
            // 
            // m1_label
            // 
            this.m1_label.AutoSize = true;
            this.m1_label.Location = new System.Drawing.Point(60, 291);
            this.m1_label.Name = "m1_label";
            this.m1_label.Size = new System.Drawing.Size(71, 12);
            this.m1_label.TabIndex = 46;
            this.m1_label.Text = "其他信息1：";
            // 
            // mode_label
            // 
            this.mode_label.AutoSize = true;
            this.mode_label.Location = new System.Drawing.Point(12, 116);
            this.mode_label.Name = "mode_label";
            this.mode_label.Size = new System.Drawing.Size(119, 12);
            this.mode_label.TabIndex = 44;
            this.mode_label.Text = "EXCEL中元器件型号：";
            // 
            // mode_textBox
            // 
            this.mode_textBox.Location = new System.Drawing.Point(135, 111);
            this.mode_textBox.Name = "mode_textBox";
            this.mode_textBox.Size = new System.Drawing.Size(213, 21);
            this.mode_textBox.TabIndex = 45;
            // 
            // reason_label
            // 
            this.reason_label.AutoSize = true;
            this.reason_label.Location = new System.Drawing.Point(12, 261);
            this.reason_label.Name = "reason_label";
            this.reason_label.Size = new System.Drawing.Size(119, 12);
            this.reason_label.TabIndex = 42;
            this.reason_label.Text = "EXCEL中不一致原因：";
            // 
            // reason_textBox
            // 
            this.reason_textBox.Location = new System.Drawing.Point(135, 257);
            this.reason_textBox.Name = "reason_textBox";
            this.reason_textBox.Size = new System.Drawing.Size(213, 21);
            this.reason_textBox.TabIndex = 43;
            // 
            // pageredirect_button
            // 
            this.pageredirect_button.Enabled = false;
            this.pageredirect_button.Location = new System.Drawing.Point(209, 423);
            this.pageredirect_button.Name = "pageredirect_button";
            this.pageredirect_button.Size = new System.Drawing.Size(30, 21);
            this.pageredirect_button.TabIndex = 41;
            this.pageredirect_button.Text = "GO";
            this.pageredirect_button.UseVisualStyleBackColor = true;
            this.pageredirect_button.Click += new System.EventHandler(this.pageredirect_button_Click);
            // 
            // pageredirect_textBox
            // 
            this.pageredirect_textBox.Location = new System.Drawing.Point(141, 423);
            this.pageredirect_textBox.Name = "pageredirect_textBox";
            this.pageredirect_textBox.Size = new System.Drawing.Size(62, 21);
            this.pageredirect_textBox.TabIndex = 40;
            // 
            // redirect_label
            // 
            this.redirect_label.AutoSize = true;
            this.redirect_label.Location = new System.Drawing.Point(92, 426);
            this.redirect_label.Name = "redirect_label";
            this.redirect_label.Size = new System.Drawing.Size(53, 12);
            this.redirect_label.TabIndex = 39;
            this.redirect_label.Text = "跳转到：";
            // 
            // pdfpagerot_button
            // 
            this.pdfpagerot_button.Location = new System.Drawing.Point(37, 548);
            this.pdfpagerot_button.Name = "pdfpagerot_button";
            this.pdfpagerot_button.Size = new System.Drawing.Size(31, 23);
            this.pdfpagerot_button.TabIndex = 38;
            this.pdfpagerot_button.Text = "☉";
            this.pdfpagerot_button.UseVisualStyleBackColor = true;
            this.pdfpagerot_button.Click += new System.EventHandler(this.pdfpagerot_button_Click);
            // 
            // notfilter_label
            // 
            this.notfilter_label.AutoSize = true;
            this.notfilter_label.Location = new System.Drawing.Point(12, 232);
            this.notfilter_label.Name = "notfilter_label";
            this.notfilter_label.Size = new System.Drawing.Size(119, 12);
            this.notfilter_label.TabIndex = 36;
            this.notfilter_label.Text = "EXCEL中不可筛型号：";
            // 
            // notfilter_textBox
            // 
            this.notfilter_textBox.Location = new System.Drawing.Point(135, 229);
            this.notfilter_textBox.Name = "notfilter_textBox";
            this.notfilter_textBox.Size = new System.Drawing.Size(213, 21);
            this.notfilter_textBox.TabIndex = 37;
            // 
            // notequ_label
            // 
            this.notequ_label.AutoSize = true;
            this.notequ_label.Location = new System.Drawing.Point(12, 203);
            this.notequ_label.Name = "notequ_label";
            this.notequ_label.Size = new System.Drawing.Size(119, 12);
            this.notequ_label.TabIndex = 34;
            this.notequ_label.Text = "EXCEL中不一致型号：";
            // 
            // notequ_textBox
            // 
            this.notequ_textBox.Location = new System.Drawing.Point(135, 200);
            this.notequ_textBox.Name = "notequ_textBox";
            this.notequ_textBox.Size = new System.Drawing.Size(213, 21);
            this.notequ_textBox.TabIndex = 35;
            // 
            // pdfpagedown_button
            // 
            this.pdfpagedown_button.Location = new System.Drawing.Point(0, 548);
            this.pdfpagedown_button.Name = "pdfpagedown_button";
            this.pdfpagedown_button.Size = new System.Drawing.Size(31, 23);
            this.pdfpagedown_button.TabIndex = 33;
            this.pdfpagedown_button.Text = "∨";
            this.pdfpagedown_button.UseVisualStyleBackColor = true;
            this.pdfpagedown_button.Click += new System.EventHandler(this.pdfpagedown_button_Click);
            // 
            // pdfpageup_button
            // 
            this.pdfpageup_button.Location = new System.Drawing.Point(0, 519);
            this.pdfpageup_button.Name = "pdfpageup_button";
            this.pdfpageup_button.Size = new System.Drawing.Size(31, 23);
            this.pdfpageup_button.TabIndex = 32;
            this.pdfpageup_button.Text = "∧";
            this.pdfpageup_button.UseVisualStyleBackColor = true;
            this.pdfpageup_button.Click += new System.EventHandler(this.pdfpageup_button_Click);
            // 
            // notequcol_label
            // 
            this.notequcol_label.AutoSize = true;
            this.notequcol_label.Location = new System.Drawing.Point(634, 56);
            this.notequcol_label.Name = "notequcol_label";
            this.notequcol_label.Size = new System.Drawing.Size(65, 12);
            this.notequcol_label.TabIndex = 30;
            this.notequcol_label.Text = "不一致列：";
            // 
            // notequcol_textBox
            // 
            this.notequcol_textBox.Location = new System.Drawing.Point(694, 52);
            this.notequcol_textBox.Name = "notequcol_textBox";
            this.notequcol_textBox.Size = new System.Drawing.Size(30, 21);
            this.notequcol_textBox.TabIndex = 31;
            this.notequcol_textBox.Text = "29";
            // 
            // notfiltercol_textBox
            // 
            this.notfiltercol_textBox.Location = new System.Drawing.Point(813, 22);
            this.notfiltercol_textBox.Name = "notfiltercol_textBox";
            this.notfiltercol_textBox.Size = new System.Drawing.Size(30, 21);
            this.notfiltercol_textBox.TabIndex = 33;
            this.notfiltercol_textBox.Text = "29";
            // 
            // notfiltercol_label
            // 
            this.notfiltercol_label.AutoSize = true;
            this.notfiltercol_label.Location = new System.Drawing.Point(740, 27);
            this.notfiltercol_label.Name = "notfiltercol_label";
            this.notfiltercol_label.Size = new System.Drawing.Size(77, 12);
            this.notfiltercol_label.TabIndex = 32;
            this.notfiltercol_label.Text = "不可筛选列：";
            // 
            // reasoncol_label
            // 
            this.reasoncol_label.AutoSize = true;
            this.reasoncol_label.Location = new System.Drawing.Point(742, 55);
            this.reasoncol_label.Name = "reasoncol_label";
            this.reasoncol_label.Size = new System.Drawing.Size(53, 12);
            this.reasoncol_label.TabIndex = 34;
            this.reasoncol_label.Text = "原因列：";
            // 
            // reasoncol_textBox
            // 
            this.reasoncol_textBox.Location = new System.Drawing.Point(813, 52);
            this.reasoncol_textBox.Name = "reasoncol_textBox";
            this.reasoncol_textBox.Size = new System.Drawing.Size(30, 21);
            this.reasoncol_textBox.TabIndex = 35;
            this.reasoncol_textBox.Text = "29";
            // 
            // iscopypdf_checkBox
            // 
            this.iscopypdf_checkBox.AutoSize = true;
            this.iscopypdf_checkBox.Location = new System.Drawing.Point(266, 34);
            this.iscopypdf_checkBox.Name = "iscopypdf_checkBox";
            this.iscopypdf_checkBox.Size = new System.Drawing.Size(84, 16);
            this.iscopypdf_checkBox.TabIndex = 36;
            this.iscopypdf_checkBox.Text = "复制路径：";
            this.iscopypdf_checkBox.UseVisualStyleBackColor = true;
            this.iscopypdf_checkBox.CheckedChanged += new System.EventHandler(this.iscopypdf_checkBox_CheckedChanged);
            // 
            // copypdf_textBox
            // 
            this.copypdf_textBox.Location = new System.Drawing.Point(266, 56);
            this.copypdf_textBox.Name = "copypdf_textBox";
            this.copypdf_textBox.Size = new System.Drawing.Size(111, 21);
            this.copypdf_textBox.TabIndex = 37;
            // 
            // copypdf_button
            // 
            this.copypdf_button.Location = new System.Drawing.Point(347, 30);
            this.copypdf_button.Name = "copypdf_button";
            this.copypdf_button.Size = new System.Drawing.Size(30, 23);
            this.copypdf_button.TabIndex = 38;
            this.copypdf_button.UseVisualStyleBackColor = true;
            this.copypdf_button.Click += new System.EventHandler(this.copypdf_button_Click);
            // 
            // m4col_textBox
            // 
            this.m4col_textBox.Location = new System.Drawing.Point(1122, 22);
            this.m4col_textBox.Name = "m4col_textBox";
            this.m4col_textBox.Size = new System.Drawing.Size(30, 21);
            this.m4col_textBox.TabIndex = 48;
            this.m4col_textBox.Text = "29";
            // 
            // m4col_label
            // 
            this.m4col_label.AutoSize = true;
            this.m4col_label.Location = new System.Drawing.Point(1065, 27);
            this.m4col_label.Name = "m4col_label";
            this.m4col_label.Size = new System.Drawing.Size(59, 12);
            this.m4col_label.TabIndex = 47;
            this.m4col_label.Text = "信息4列：";
            // 
            // m3col_textBox
            // 
            this.m3col_textBox.Location = new System.Drawing.Point(1017, 52);
            this.m3col_textBox.Name = "m3col_textBox";
            this.m3col_textBox.Size = new System.Drawing.Size(30, 21);
            this.m3col_textBox.TabIndex = 46;
            this.m3col_textBox.Text = "29";
            // 
            // m3col_label
            // 
            this.m3col_label.AutoSize = true;
            this.m3col_label.Location = new System.Drawing.Point(959, 56);
            this.m3col_label.Name = "m3col_label";
            this.m3col_label.Size = new System.Drawing.Size(59, 12);
            this.m3col_label.TabIndex = 45;
            this.m3col_label.Text = "信息3列：";
            // 
            // m1col_textBox
            // 
            this.m1col_textBox.Location = new System.Drawing.Point(917, 50);
            this.m1col_textBox.Name = "m1col_textBox";
            this.m1col_textBox.Size = new System.Drawing.Size(30, 21);
            this.m1col_textBox.TabIndex = 44;
            this.m1col_textBox.Text = "18";
            // 
            // modecol_textBox
            // 
            this.modecol_textBox.Location = new System.Drawing.Point(917, 22);
            this.modecol_textBox.Name = "modecol_textBox";
            this.modecol_textBox.Size = new System.Drawing.Size(30, 21);
            this.modecol_textBox.TabIndex = 43;
            this.modecol_textBox.Text = "7";
            // 
            // m1col_label
            // 
            this.m1col_label.AutoSize = true;
            this.m1col_label.Location = new System.Drawing.Point(859, 55);
            this.m1col_label.Name = "m1col_label";
            this.m1col_label.Size = new System.Drawing.Size(59, 12);
            this.m1col_label.TabIndex = 42;
            this.m1col_label.Text = "信息1列：";
            // 
            // modecol_label
            // 
            this.modecol_label.AutoSize = true;
            this.modecol_label.Location = new System.Drawing.Point(859, 27);
            this.modecol_label.Name = "modecol_label";
            this.modecol_label.Size = new System.Drawing.Size(53, 12);
            this.modecol_label.TabIndex = 41;
            this.modecol_label.Text = "型号列：";
            // 
            // m2col_textBox
            // 
            this.m2col_textBox.Location = new System.Drawing.Point(1017, 22);
            this.m2col_textBox.Name = "m2col_textBox";
            this.m2col_textBox.Size = new System.Drawing.Size(30, 21);
            this.m2col_textBox.TabIndex = 40;
            this.m2col_textBox.Text = "29";
            // 
            // m2col_label
            // 
            this.m2col_label.AutoSize = true;
            this.m2col_label.Location = new System.Drawing.Point(959, 27);
            this.m2col_label.Name = "m2col_label";
            this.m2col_label.Size = new System.Drawing.Size(59, 12);
            this.m2col_label.TabIndex = 39;
            this.m2col_label.Text = "信息2列：";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 682);
            this.Controls.Add(this.m4col_textBox);
            this.Controls.Add(this.m4col_label);
            this.Controls.Add(this.m3col_textBox);
            this.Controls.Add(this.m3col_label);
            this.Controls.Add(this.m1col_textBox);
            this.Controls.Add(this.modecol_textBox);
            this.Controls.Add(this.m1col_label);
            this.Controls.Add(this.modecol_label);
            this.Controls.Add(this.m2col_textBox);
            this.Controls.Add(this.m2col_label);
            this.Controls.Add(this.copypdf_button);
            this.Controls.Add(this.copypdf_textBox);
            this.Controls.Add(this.iscopypdf_checkBox);
            this.Controls.Add(this.reasoncol_textBox);
            this.Controls.Add(this.reasoncol_label);
            this.Controls.Add(this.notfiltercol_textBox);
            this.Controls.Add(this.notfiltercol_label);
            this.Controls.Add(this.notequcol_textBox);
            this.Controls.Add(this.notequcol_label);
            this.Controls.Add(this.check_groupBox);
            this.Controls.Add(this.msg_richTextBox);
            this.Controls.Add(this.batchcol_textBox);
            this.Controls.Add(this.numcol_textBox);
            this.Controls.Add(this.namecol_textBox);
            this.Controls.Add(this.batchcol_label);
            this.Controls.Add(this.numcol_label);
            this.Controls.Add(this.namecol_label);
            this.Controls.Add(this.idencol_textBox);
            this.Controls.Add(this.filenamecol_textBox);
            this.Controls.Add(this.iden_label);
            this.Controls.Add(this.filenamecol_label);
            this.Controls.Add(this.exceldir_textBox);
            this.Controls.Add(this.pdfdir_textBox);
            this.Controls.Add(this.exceldir_button);
            this.Controls.Add(this.pdfdir_button);
            this.Controls.Add(this.pdf_pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "装机证核对工具 V1.0.0.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pdf_pictureBox)).EndInit();
            this.check_groupBox.ResumeLayout(false);
            this.check_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.PictureBox pdf_pictureBox;
        private System.Windows.Forms.FolderBrowserDialog pdfdir_folderBrowserDialog;
        private System.Windows.Forms.Button pdfdir_button;
        private System.Windows.Forms.Button exceldir_button;
        private System.Windows.Forms.OpenFileDialog exceldir_openFileDialog;
        private System.Windows.Forms.TextBox pdfdir_textBox;
        private System.Windows.Forms.TextBox exceldir_textBox;
        private System.Windows.Forms.Label filenamecol_label;
        private System.Windows.Forms.Label iden_label;
        private System.Windows.Forms.TextBox filenamecol_textBox;
        private System.Windows.Forms.TextBox idencol_textBox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label num_label;
        private System.Windows.Forms.Label batch_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox num_textBox;
        private System.Windows.Forms.TextBox batch_textBox;
        private System.Windows.Forms.Button previous_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Label namecol_label;
        private System.Windows.Forms.Label numcol_label;
        private System.Windows.Forms.Label batchcol_label;
        private System.Windows.Forms.TextBox namecol_textBox;
        private System.Windows.Forms.TextBox numcol_textBox;
        private System.Windows.Forms.TextBox batchcol_textBox;
        private System.Windows.Forms.Label idenmsg_label;
        private System.Windows.Forms.TextBox idenmsg_textBox;
        private System.Windows.Forms.RichTextBox msg_richTextBox;
        private System.Windows.Forms.Button idenmsg_button;
        private System.Windows.Forms.TextBox row_textBox;
        private System.Windows.Forms.GroupBox check_groupBox;
        private System.Windows.Forms.Button pdfpagedown_button;
        private System.Windows.Forms.Button pdfpageup_button;
        private System.Windows.Forms.Label notequcol_label;
        private System.Windows.Forms.TextBox notequcol_textBox;
        private System.Windows.Forms.TextBox notfiltercol_textBox;
        private System.Windows.Forms.Label notfiltercol_label;
        private System.Windows.Forms.Label notequ_label;
        private System.Windows.Forms.TextBox notequ_textBox;
        private System.Windows.Forms.Label notfilter_label;
        private System.Windows.Forms.TextBox notfilter_textBox;
        private System.Windows.Forms.Button pdfpagerot_button;
        private System.Windows.Forms.Button pageredirect_button;
        private System.Windows.Forms.TextBox pageredirect_textBox;
        private System.Windows.Forms.Label redirect_label;
        private System.Windows.Forms.Label reasoncol_label;
        private System.Windows.Forms.TextBox reasoncol_textBox;
        private System.Windows.Forms.Label reason_label;
        private System.Windows.Forms.TextBox reason_textBox;
        private System.Windows.Forms.CheckBox iscopypdf_checkBox;
        private System.Windows.Forms.TextBox copypdf_textBox;
        private System.Windows.Forms.Button copypdf_button;
        private System.Windows.Forms.FolderBrowserDialog copypdf_folderBrowserDialog;
        private System.Windows.Forms.Label mode_label;
        private System.Windows.Forms.TextBox mode_textBox;
        private System.Windows.Forms.TextBox m4_textBox;
        private System.Windows.Forms.Label m4_label;
        private System.Windows.Forms.TextBox m3_textBox;
        private System.Windows.Forms.TextBox m2_textBox;
        private System.Windows.Forms.TextBox m1_textBox;
        private System.Windows.Forms.Label m3_label;
        private System.Windows.Forms.Label m2_label;
        private System.Windows.Forms.Label m1_label;
        private System.Windows.Forms.TextBox m4col_textBox;
        private System.Windows.Forms.Label m4col_label;
        private System.Windows.Forms.TextBox m3col_textBox;
        private System.Windows.Forms.Label m3col_label;
        private System.Windows.Forms.TextBox m1col_textBox;
        private System.Windows.Forms.TextBox modecol_textBox;
        private System.Windows.Forms.Label m1col_label;
        private System.Windows.Forms.Label modecol_label;
        private System.Windows.Forms.TextBox m2col_textBox;
        private System.Windows.Forms.Label m2col_label;
        private System.Windows.Forms.Button idencolor_button;
        private System.Windows.Forms.ColorDialog iden_colorDialog;
        private System.Windows.Forms.TextBox idencolor_textBox;
    }
}


namespace nakrutchik
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.urltext = new System.Windows.Forms.TextBox();
            this.urllbl = new System.Windows.Forms.Label();
            this.countlabel = new System.Windows.Forms.Label();
            this.countnum = new System.Windows.Forms.NumericUpDown();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.delaydiaplbl = new System.Windows.Forms.Label();
            this.delaydiapnumot = new System.Windows.Forms.NumericUpDown();
            this.delaydiapnumdo = new System.Windows.Forms.NumericUpDown();
            this.delaydidaplblot = new System.Windows.Forms.Label();
            this.delaydiaplbldo = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.stopbtn = new System.Windows.Forms.Button();
            this.processlbl = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.titlelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countnum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delaydiapnumot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delaydiapnumdo)).BeginInit();
            this.SuspendLayout();
            // 
            // urltext
            // 
            this.urltext.Location = new System.Drawing.Point(96, 66);
            this.urltext.Name = "urltext";
            this.urltext.Size = new System.Drawing.Size(217, 20);
            this.urltext.TabIndex = 0;
            this.urltext.Text = "http://";
            this.urltext.TextChanged += new System.EventHandler(this.urltext_TextChanged);
            this.urltext.KeyUp += new System.Windows.Forms.KeyEventHandler(this.urltext_KeyUp);
            // 
            // urllbl
            // 
            this.urllbl.AutoSize = true;
            this.urllbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.urllbl.Location = new System.Drawing.Point(12, 67);
            this.urllbl.Name = "urllbl";
            this.urllbl.Size = new System.Drawing.Size(78, 15);
            this.urllbl.TabIndex = 1;
            this.urllbl.Text = "Адрес сайта";
            // 
            // countlabel
            // 
            this.countlabel.AutoSize = true;
            this.countlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countlabel.Location = new System.Drawing.Point(12, 107);
            this.countlabel.Name = "countlabel";
            this.countlabel.Size = new System.Drawing.Size(133, 15);
            this.countlabel.TabIndex = 2;
            this.countlabel.Text = "Количество запросов";
            // 
            // countnum
            // 
            this.countnum.Location = new System.Drawing.Point(151, 107);
            this.countnum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.countnum.Name = "countnum";
            this.countnum.Size = new System.Drawing.Size(162, 20);
            this.countnum.TabIndex = 3;
            this.countnum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(0, 273);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(333, 25);
            this.progress.TabIndex = 4;
            // 
            // delaydiaplbl
            // 
            this.delaydiaplbl.AutoSize = true;
            this.delaydiaplbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delaydiaplbl.Location = new System.Drawing.Point(46, 143);
            this.delaydiaplbl.Name = "delaydiaplbl";
            this.delaydiaplbl.Size = new System.Drawing.Size(243, 15);
            this.delaydiaplbl.TabIndex = 5;
            this.delaydiaplbl.Text = "Диапазон интервалов между запросами";
            // 
            // delaydiapnumot
            // 
            this.delaydiapnumot.Location = new System.Drawing.Point(12, 170);
            this.delaydiapnumot.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.delaydiapnumot.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delaydiapnumot.Name = "delaydiapnumot";
            this.delaydiapnumot.Size = new System.Drawing.Size(133, 20);
            this.delaydiapnumot.TabIndex = 6;
            this.delaydiapnumot.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delaydiapnumot.ValueChanged += new System.EventHandler(this.delaydiapnumot_ValueChanged);
            // 
            // delaydiapnumdo
            // 
            this.delaydiapnumdo.Location = new System.Drawing.Point(180, 170);
            this.delaydiapnumdo.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.delaydiapnumdo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delaydiapnumdo.Name = "delaydiapnumdo";
            this.delaydiapnumdo.Size = new System.Drawing.Size(133, 20);
            this.delaydiapnumdo.TabIndex = 7;
            this.delaydiapnumdo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delaydiapnumdo.ValueChanged += new System.EventHandler(this.delaydiapnumdo_ValueChanged);
            // 
            // delaydidaplblot
            // 
            this.delaydidaplblot.AutoSize = true;
            this.delaydidaplblot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delaydidaplblot.Location = new System.Drawing.Point(58, 193);
            this.delaydidaplblot.Name = "delaydidaplblot";
            this.delaydidaplblot.Size = new System.Drawing.Size(44, 15);
            this.delaydidaplblot.TabIndex = 8;
            this.delaydidaplblot.Text = "От, мс";
            // 
            // delaydiaplbldo
            // 
            this.delaydiaplbldo.AutoSize = true;
            this.delaydiaplbldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delaydiaplbldo.Location = new System.Drawing.Point(223, 193);
            this.delaydiaplbldo.Name = "delaydiaplbldo";
            this.delaydiaplbldo.Size = new System.Drawing.Size(44, 15);
            this.delaydiaplbldo.TabIndex = 9;
            this.delaydiaplbldo.Text = "До, мс";
            // 
            // startbtn
            // 
            this.startbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.startbtn.Enabled = false;
            this.startbtn.Location = new System.Drawing.Point(15, 237);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(133, 30);
            this.startbtn.TabIndex = 10;
            this.startbtn.Text = "Старт!";
            this.startbtn.UseVisualStyleBackColor = false;
            this.startbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.BackColor = System.Drawing.Color.Red;
            this.stopbtn.Enabled = false;
            this.stopbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopbtn.Location = new System.Drawing.Point(180, 237);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(133, 30);
            this.stopbtn.TabIndex = 11;
            this.stopbtn.Text = "СТОП";
            this.stopbtn.UseVisualStyleBackColor = false;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // processlbl
            // 
            this.processlbl.AutoSize = true;
            this.processlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.processlbl.Location = new System.Drawing.Point(126, 277);
            this.processlbl.Name = "processlbl";
            this.processlbl.Size = new System.Drawing.Size(87, 15);
            this.processlbl.TabIndex = 12;
            this.processlbl.Text = "Процесс идет";
            this.processlbl.Visible = false;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel.Location = new System.Drawing.Point(223, 44);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(100, 13);
            this.linkLabel.TabIndex = 13;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "http://dubos.esy.es";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // titlelbl
            // 
            this.titlelbl.AutoSize = true;
            this.titlelbl.Font = new System.Drawing.Font("Segoe Print", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(210)));
            this.titlelbl.Location = new System.Drawing.Point(12, 3);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(293, 35);
            this.titlelbl.TabIndex = 14;
            this.titlelbl.Text = "DuboS Soft Накрутчик 2G";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 301);
            this.Controls.Add(this.titlelbl);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.processlbl);
            this.Controls.Add(this.stopbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.delaydiaplbldo);
            this.Controls.Add(this.delaydidaplblot);
            this.Controls.Add(this.delaydiapnumdo);
            this.Controls.Add(this.delaydiapnumot);
            this.Controls.Add(this.delaydiaplbl);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.countnum);
            this.Controls.Add(this.countlabel);
            this.Controls.Add(this.urllbl);
            this.Controls.Add(this.urltext);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 340);
            this.MinimumSize = new System.Drawing.Size(350, 340);
            this.Name = "MainForm";
            this.Text = "DubosSoft Накрутчик 2G";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.countnum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delaydiapnumot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delaydiapnumdo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urltext;
        private System.Windows.Forms.Label urllbl;
        private System.Windows.Forms.Label countlabel;
        private System.Windows.Forms.NumericUpDown countnum;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label delaydiaplbl;
        private System.Windows.Forms.NumericUpDown delaydiapnumot;
        private System.Windows.Forms.NumericUpDown delaydiapnumdo;
        private System.Windows.Forms.Label delaydidaplblot;
        private System.Windows.Forms.Label delaydiaplbldo;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.Label processlbl;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Label titlelbl;
    }
}


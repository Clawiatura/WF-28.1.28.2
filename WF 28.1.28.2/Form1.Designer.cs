namespace WF_28._1._28._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbRandom = new GroupBox();
            lbRes = new Label();
            gblp = new GroupBox();
            tbusserlog = new TextBox();
            lbpass = new ListBox();
            lblog = new ListBox();
            btgen = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btClear = new Button();
            gbRandom.SuspendLayout();
            gblp.SuspendLayout();
            SuspendLayout();
            // 
            // gbRandom
            // 
            gbRandom.Controls.Add(lbRes);
            gbRandom.Location = new Point(12, 4);
            gbRandom.Name = "gbRandom";
            gbRandom.Size = new Size(388, 443);
            gbRandom.TabIndex = 0;
            gbRandom.TabStop = false;
            // 
            // lbRes
            // 
            lbRes.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbRes.Location = new Point(9, 33);
            lbRes.Name = "lbRes";
            lbRes.Size = new Size(362, 305);
            lbRes.TabIndex = 0;
            // 
            // gblp
            // 
            gblp.Controls.Add(btClear);
            gblp.Controls.Add(tbusserlog);
            gblp.Controls.Add(lbpass);
            gblp.Controls.Add(lblog);
            gblp.Controls.Add(btgen);
            gblp.Controls.Add(label3);
            gblp.Controls.Add(label2);
            gblp.Controls.Add(label1);
            gblp.Location = new Point(520, 12);
            gblp.Name = "gblp";
            gblp.Size = new Size(510, 426);
            gblp.TabIndex = 1;
            gblp.TabStop = false;
            gblp.Text = "g";
            // 
            // tbusserlog
            // 
            tbusserlog.Location = new Point(28, 56);
            tbusserlog.Multiline = true;
            tbusserlog.Name = "tbusserlog";
            tbusserlog.Size = new Size(100, 149);
            tbusserlog.TabIndex = 7;
            // 
            // lbpass
            // 
            lbpass.FormattingEnabled = true;
            lbpass.ItemHeight = 15;
            lbpass.Location = new Point(384, 56);
            lbpass.Name = "lbpass";
            lbpass.Size = new Size(120, 229);
            lbpass.TabIndex = 6;
            // 
            // lblog
            // 
            lblog.FormattingEnabled = true;
            lblog.ItemHeight = 15;
            lblog.Location = new Point(216, 56);
            lblog.Name = "lblog";
            lblog.Size = new Size(120, 229);
            lblog.TabIndex = 5;
            // 
            // btgen
            // 
            btgen.Location = new Point(28, 211);
            btgen.Name = "btgen";
            btgen.Size = new Size(100, 77);
            btgen.TabIndex = 3;
            btgen.Text = "Сгененировать";
            btgen.UseVisualStyleBackColor = true;
            btgen.Click += btgen_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(385, 30);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Пароль: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 29);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Логин:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 27);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "Имя пользователя: ";
            // 
            // btClear
            // 
            btClear.Location = new Point(28, 294);
            btClear.Name = "btClear";
            btClear.Size = new Size(100, 23);
            btClear.TabIndex = 8;
            btClear.Text = "Delete";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 450);
            Controls.Add(gblp);
            Controls.Add(gbRandom);
            Name = "Form1";
            Text = "Домашняя работа";
            gbRandom.ResumeLayout(false);
            gblp.ResumeLayout(false);
            gblp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbRandom;
        private Label lbRes;
        private GroupBox gblp;
        private Button btgen;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox lbpass;
        private ListBox lblog;
        private TextBox tbusserlog;
        private Button btClear;
    }
}

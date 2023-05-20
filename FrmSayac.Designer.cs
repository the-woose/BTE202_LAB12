namespace BTE202_LAB12
{
    partial class FrmSayac
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
            groupBox1 = new GroupBox();
            button2 = new Button();
            buttonSay = new Button();
            radioButton10 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(buttonSay);
            groupBox1.Controls.Add(radioButton10);
            groupBox1.Controls.Add(radioButton5);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(112, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(177, 353);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "1den 20ye sayma aralığı";
            // 
            // button2
            // 
            button2.Location = new Point(26, 281);
            button2.Name = "button2";
            button2.Size = new Size(131, 45);
            button2.TabIndex = 1;
            button2.Text = "&Çıkış";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonSay
            // 
            buttonSay.Location = new Point(26, 221);
            buttonSay.Name = "buttonSay";
            buttonSay.Size = new Size(131, 45);
            buttonSay.TabIndex = 1;
            buttonSay.Text = "&Say";
            buttonSay.UseVisualStyleBackColor = true;
            buttonSay.Click += buttonSay_Click;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(26, 167);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(47, 19);
            radioButton10.TabIndex = 0;
            radioButton10.TabStop = true;
            radioButton10.Text = "10ar";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(26, 126);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(41, 19);
            radioButton5.TabIndex = 0;
            radioButton5.TabStop = true;
            radioButton5.Text = "5er";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(26, 82);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(46, 19);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "2şer";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(26, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(41, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "1er";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(76, 353);
            textBox1.TabIndex = 2;
            // 
            // FrmSayac
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 385);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Name = "FrmSayac";
            Text = "FrmSayac";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Button button2;
        private Button buttonSay;
        private RadioButton radioButton10;
        private RadioButton radioButton5;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
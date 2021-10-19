namespace WindowsFormsApp1
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.numUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.buffer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(136, 139);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(58, 17);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "Letters";
            this.cb1.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(136, 162);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(89, 17);
            this.cb2.TabIndex = 1;
            this.cb2.Text = "Capital letters";
            this.cb2.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            this.cb3.AutoSize = true;
            this.cb3.Location = new System.Drawing.Point(136, 185);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(68, 17);
            this.cb3.TabIndex = 2;
            this.cb3.Text = "Numbers";
            this.cb3.UseVisualStyleBackColor = true;
            // 
            // cb4
            // 
            this.cb4.AutoSize = true;
            this.cb4.Location = new System.Drawing.Point(136, 208);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(101, 17);
            this.cb4.TabIndex = 3;
            this.cb4.Text = "Special symbols";
            this.cb4.UseVisualStyleBackColor = true;
            // 
            // numUpDown
            // 
            this.numUpDown.Location = new System.Drawing.Point(136, 305);
            this.numUpDown.Name = "numUpDown";
            this.numUpDown.Size = new System.Drawing.Size(120, 20);
            this.numUpDown.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Length";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(313, 302);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 8;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // buffer
            // 
            this.buffer.Location = new System.Drawing.Point(403, 302);
            this.buffer.Name = "buffer";
            this.buffer.Size = new System.Drawing.Size(75, 23);
            this.buffer.TabIndex = 9;
            this.buffer.Text = "Copy";
            this.buffer.UseVisualStyleBackColor = true;
            this.buffer.Click += new System.EventHandler(this.buffer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buffer);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUpDown);
            this.Controls.Add(this.cb4);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Name = "Form1";
            this.Text = "Window";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb3;
        private System.Windows.Forms.CheckBox cb4;
        private System.Windows.Forms.NumericUpDown numUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button buffer;
        protected internal System.Windows.Forms.TextBox textBox1;
    }
}


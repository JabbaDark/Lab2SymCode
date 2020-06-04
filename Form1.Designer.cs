namespace Symmetr
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
            this.VernCode = new System.Windows.Forms.Button();
            this.VernDecode = new System.Windows.Forms.Button();
            this.RC2Code = new System.Windows.Forms.Button();
            this.RC2Decode = new System.Windows.Forms.Button();
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CodeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DecodeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // VernCode
            // 
            this.VernCode.Location = new System.Drawing.Point(13, 13);
            this.VernCode.Name = "VernCode";
            this.VernCode.Size = new System.Drawing.Size(149, 23);
            this.VernCode.TabIndex = 0;
            this.VernCode.Text = "Зашифровать Вернамом";
            this.VernCode.UseVisualStyleBackColor = true;
            this.VernCode.Click += new System.EventHandler(this.VernCode_Click);
            // 
            // VernDecode
            // 
            this.VernDecode.Location = new System.Drawing.Point(13, 43);
            this.VernDecode.Name = "VernDecode";
            this.VernDecode.Size = new System.Drawing.Size(149, 23);
            this.VernDecode.TabIndex = 1;
            this.VernDecode.Text = "Расшифровать Вернамом";
            this.VernDecode.UseVisualStyleBackColor = true;
            this.VernDecode.Click += new System.EventHandler(this.VernDecode_Click);
            // 
            // RC2Code
            // 
            this.RC2Code.Location = new System.Drawing.Point(13, 72);
            this.RC2Code.Name = "RC2Code";
            this.RC2Code.Size = new System.Drawing.Size(149, 23);
            this.RC2Code.TabIndex = 2;
            this.RC2Code.Text = "Зашифровать RC2";
            this.RC2Code.UseVisualStyleBackColor = true;
            this.RC2Code.Click += new System.EventHandler(this.RC2Code_Click);
            // 
            // RC2Decode
            // 
            this.RC2Decode.Location = new System.Drawing.Point(13, 268);
            this.RC2Decode.Name = "RC2Decode";
            this.RC2Decode.Size = new System.Drawing.Size(149, 23);
            this.RC2Decode.TabIndex = 3;
            this.RC2Decode.Text = "Расшифровать RC2";
            this.RC2Decode.UseVisualStyleBackColor = true;
            this.RC2Decode.Click += new System.EventHandler(this.RC2Decode_Click);
            // 
            // MainTextBox
            // 
            this.MainTextBox.Location = new System.Drawing.Point(13, 119);
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(149, 20);
            this.MainTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Текст для шифрования";
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Location = new System.Drawing.Point(13, 162);
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.Size = new System.Drawing.Size(149, 20);
            this.KeyTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ключ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Зашифрованный текст";
            // 
            // CodeTextBox
            // 
            this.CodeTextBox.Location = new System.Drawing.Point(13, 206);
            this.CodeTextBox.Multiline = true;
            this.CodeTextBox.Name = "CodeTextBox";
            this.CodeTextBox.Size = new System.Drawing.Size(149, 56);
            this.CodeTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Расшифрованный текст";
            // 
            // DecodeTextBox
            // 
            this.DecodeTextBox.Location = new System.Drawing.Point(13, 315);
            this.DecodeTextBox.Multiline = true;
            this.DecodeTextBox.Name = "DecodeTextBox";
            this.DecodeTextBox.Size = new System.Drawing.Size(149, 72);
            this.DecodeTextBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 412);
            this.Controls.Add(this.DecodeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CodeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KeyTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.RC2Decode);
            this.Controls.Add(this.RC2Code);
            this.Controls.Add(this.VernDecode);
            this.Controls.Add(this.VernCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VernCode;
        private System.Windows.Forms.Button VernDecode;
        private System.Windows.Forms.Button RC2Code;
        private System.Windows.Forms.Button RC2Decode;
        private System.Windows.Forms.TextBox MainTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CodeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DecodeTextBox;
    }
}


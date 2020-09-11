namespace _518H0545_Lab01_01
{
    partial class Form1
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
            this.InsertBox = new System.Windows.Forms.Label();
            this.txtNhapten = new System.Windows.Forms.TextBox();
            this.ColorBox = new System.Windows.Forms.GroupBox();
            this.Orange = new System.Windows.Forms.RadioButton();
            this.Blue = new System.Windows.Forms.RadioButton();
            this.Green = new System.Windows.Forms.RadioButton();
            this.Red = new System.Windows.Forms.RadioButton();
            this.FontBox = new System.Windows.Forms.GroupBox();
            this.Underline = new System.Windows.Forms.CheckBox();
            this.Italic = new System.Windows.Forms.CheckBox();
            this.Bold = new System.Windows.Forms.CheckBox();
            this.LabelResult = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ResultTextbox = new System.Windows.Forms.TextBox();
            this.ColorBox.SuspendLayout();
            this.FontBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertBox
            // 
            this.InsertBox.AutoSize = true;
            this.InsertBox.BackColor = System.Drawing.Color.Black;
            this.InsertBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBox.ForeColor = System.Drawing.Color.Lime;
            this.InsertBox.Location = new System.Drawing.Point(12, 9);
            this.InsertBox.Name = "InsertBox";
            this.InsertBox.Size = new System.Drawing.Size(78, 20);
            this.InsertBox.TabIndex = 0;
            this.InsertBox.Text = "Nhập tên:";
            // 
            // txtNhapten
            // 
            this.txtNhapten.Location = new System.Drawing.Point(96, 9);
            this.txtNhapten.Name = "txtNhapten";
            this.txtNhapten.Size = new System.Drawing.Size(182, 20);
            this.txtNhapten.TabIndex = 1;
            this.txtNhapten.TextChanged += new System.EventHandler(this.txtNhapten_TextChanged);
            // 
            // ColorBox
            // 
            this.ColorBox.Controls.Add(this.Orange);
            this.ColorBox.Controls.Add(this.Blue);
            this.ColorBox.Controls.Add(this.Green);
            this.ColorBox.Controls.Add(this.Red);
            this.ColorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorBox.Location = new System.Drawing.Point(12, 73);
            this.ColorBox.Name = "ColorBox";
            this.ColorBox.Size = new System.Drawing.Size(137, 157);
            this.ColorBox.TabIndex = 2;
            this.ColorBox.TabStop = false;
            this.ColorBox.Text = "Color";
            // 
            // Orange
            // 
            this.Orange.AutoSize = true;
            this.Orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Orange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orange.Location = new System.Drawing.Point(6, 107);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(86, 24);
            this.Orange.TabIndex = 5;
            this.Orange.TabStop = true;
            this.Orange.Text = "Orange";
            this.Orange.UseVisualStyleBackColor = false;
            this.Orange.CheckedChanged += new System.EventHandler(this.Orange_CheckedChanged);
            // 
            // Blue
            // 
            this.Blue.AutoSize = true;
            this.Blue.BackColor = System.Drawing.Color.Cyan;
            this.Blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Blue.Location = new System.Drawing.Point(6, 79);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(63, 24);
            this.Blue.TabIndex = 2;
            this.Blue.TabStop = true;
            this.Blue.Text = "Blue";
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.CheckedChanged += new System.EventHandler(this.Blue_CheckedChanged);
            // 
            // Green
            // 
            this.Green.AutoSize = true;
            this.Green.BackColor = System.Drawing.Color.Lime;
            this.Green.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Green.Location = new System.Drawing.Point(6, 51);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(77, 24);
            this.Green.TabIndex = 1;
            this.Green.TabStop = true;
            this.Green.Text = "Green";
            this.Green.UseVisualStyleBackColor = false;
            this.Green.CheckedChanged += new System.EventHandler(this.Green_CheckedChanged);
            // 
            // Red
            // 
            this.Red.AutoSize = true;
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Red.Location = new System.Drawing.Point(6, 23);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(60, 24);
            this.Red.TabIndex = 0;
            this.Red.TabStop = true;
            this.Red.Text = "Red";
            this.Red.UseVisualStyleBackColor = false;
            this.Red.CheckedChanged += new System.EventHandler(this.Red_CheckedChanged);
            // 
            // FontBox
            // 
            this.FontBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FontBox.Controls.Add(this.Underline);
            this.FontBox.Controls.Add(this.Italic);
            this.FontBox.Controls.Add(this.Bold);
            this.FontBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FontBox.Location = new System.Drawing.Point(224, 73);
            this.FontBox.Name = "FontBox";
            this.FontBox.Size = new System.Drawing.Size(159, 157);
            this.FontBox.TabIndex = 3;
            this.FontBox.TabStop = false;
            this.FontBox.Text = "Font";
            this.FontBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // Underline
            // 
            this.Underline.AutoSize = true;
            this.Underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Underline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Underline.Location = new System.Drawing.Point(6, 65);
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(106, 24);
            this.Underline.TabIndex = 2;
            this.Underline.Text = "Gạch chân";
            this.Underline.UseVisualStyleBackColor = true;
            this.Underline.CheckedChanged += new System.EventHandler(this.Underline_CheckedChanged);
            // 
            // Italic
            // 
            this.Italic.AutoSize = true;
            this.Italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Italic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Italic.Location = new System.Drawing.Point(6, 42);
            this.Italic.Name = "Italic";
            this.Italic.Size = new System.Drawing.Size(124, 24);
            this.Italic.TabIndex = 1;
            this.Italic.Text = "Nghiêng Italic";
            this.Italic.UseVisualStyleBackColor = true;
            this.Italic.CheckedChanged += new System.EventHandler(this.Italic_CheckedChanged);
            // 
            // Bold
            // 
            this.Bold.AutoSize = true;
            this.Bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bold.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Bold.Location = new System.Drawing.Point(6, 19);
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(106, 24);
            this.Bold.TabIndex = 0;
            this.Bold.Text = "Đậm Bold";
            this.Bold.UseVisualStyleBackColor = true;
            this.Bold.CheckedChanged += new System.EventHandler(this.Bold_CheckedChanged);
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResult.ForeColor = System.Drawing.Color.Red;
            this.LabelResult.Location = new System.Drawing.Point(9, 327);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(138, 24);
            this.LabelResult.TabIndex = 6;
            this.LabelResult.Text = "Lập trình bởi: ";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(288, 450);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(95, 32);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Thoát";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResultTextbox
            // 
            this.ResultTextbox.Location = new System.Drawing.Point(153, 332);
            this.ResultTextbox.Name = "ResultTextbox";
            this.ResultTextbox.Size = new System.Drawing.Size(207, 20);
            this.ResultTextbox.TabIndex = 9;
            this.ResultTextbox.TextChanged += new System.EventHandler(this.ResultTextbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(436, 514);
            this.Controls.Add(this.ResultTextbox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.FontBox);
            this.Controls.Add(this.ColorBox);
            this.Controls.Add(this.txtNhapten);
            this.Controls.Add(this.InsertBox);
            this.Name = "Form1";
            this.Text = "Định dạng (Formater)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ColorBox.ResumeLayout(false);
            this.ColorBox.PerformLayout();
            this.FontBox.ResumeLayout(false);
            this.FontBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InsertBox;
        private System.Windows.Forms.TextBox txtNhapten;
        private System.Windows.Forms.GroupBox ColorBox;
        private System.Windows.Forms.RadioButton Orange;
        private System.Windows.Forms.RadioButton Blue;
        private System.Windows.Forms.RadioButton Green;
        private System.Windows.Forms.RadioButton Red;
        private System.Windows.Forms.GroupBox FontBox;
        private System.Windows.Forms.CheckBox Underline;
        private System.Windows.Forms.CheckBox Italic;
        private System.Windows.Forms.CheckBox Bold;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox ResultTextbox;
    }
}


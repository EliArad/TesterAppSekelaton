namespace WindowsFormsApp4
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.macButton1 = new MACButtonLib.MACButton();
            this.macButton2 = new MACButtonLib.MACButton();
            this.toggleSwitch1 = new JCS.ToggleSwitch();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(270, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(398, 7);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 20);
            this.textBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Test Name";
            // 
            // macButton1
            // 
            this.macButton1.BackColor = System.Drawing.Color.Transparent;
            this.macButton1.ButtonColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(162)))), ((int)(((byte)(214)))));
            this.macButton1.ButtonColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.macButton1.ButtonColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(122)))), ((int)(((byte)(87)))));
            this.macButton1.ButtonColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(162)))), ((int)(((byte)(214)))));
            this.macButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.macButton1.Location = new System.Drawing.Point(747, 3);
            this.macButton1.Name = "macButton1";
            this.macButton1.Size = new System.Drawing.Size(75, 27);
            this.macButton1.TabIndex = 9;
            this.macButton1.Text = "Settings";
            this.macButton1.TextColorDefault = System.Drawing.Color.Black;
            this.macButton1.TextColorDisabled = System.Drawing.Color.Black;
            this.macButton1.TextColorHover = System.Drawing.Color.White;
            this.macButton1.TextColorNormal = System.Drawing.Color.Black;
            // 
            // macButton2
            // 
            this.macButton2.BackColor = System.Drawing.Color.Transparent;
            this.macButton2.ButtonColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(162)))), ((int)(((byte)(214)))));
            this.macButton2.ButtonColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
            this.macButton2.ButtonColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(122)))), ((int)(((byte)(87)))));
            this.macButton2.ButtonColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(162)))), ((int)(((byte)(214)))));
            this.macButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.macButton2.Location = new System.Drawing.Point(837, 2);
            this.macButton2.Name = "macButton2";
            this.macButton2.Size = new System.Drawing.Size(75, 27);
            this.macButton2.TabIndex = 10;
            this.macButton2.Text = "Run Test";
            this.macButton2.TextColorDefault = System.Drawing.Color.Black;
            this.macButton2.TextColorDisabled = System.Drawing.Color.Black;
            this.macButton2.TextColorHover = System.Drawing.Color.White;
            this.macButton2.TextColorNormal = System.Drawing.Color.Black;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(931, 3);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleSwitch1.Size = new System.Drawing.Size(50, 19);
            this.toggleSwitch1.TabIndex = 11;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(524, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(217, 23);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Value = 50;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.macButton2);
            this.Controls.Add(this.macButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1015, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private MACButtonLib.MACButton macButton1;
        private MACButtonLib.MACButton macButton2;
        private JCS.ToggleSwitch toggleSwitch1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

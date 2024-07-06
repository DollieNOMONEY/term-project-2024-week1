namespace Pomodoro
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
            Time = new Label();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            Start = new Button();
            Stop = new Button();
            label3 = new Label();
            label4 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Time.Location = new Point(27, 135);
            Time.Name = "Time";
            Time.Size = new Size(57, 25);
            Time.TabIndex = 0;
            Time.Text = "Time:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 14F);
            numericUpDown1.Location = new Point(90, 133);
            numericUpDown1.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(43, 32);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(139, 135);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 2;
            label1.Text = "minutes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tokyo 2097", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(323, 204);
            label2.Name = "label2";
            label2.Size = new Size(142, 46);
            label2.TabIndex = 3;
            label2.Text = "25:00";
            // 
            // Start
            // 
            Start.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Start.Location = new Point(268, 266);
            Start.Name = "Start";
            Start.Size = new Size(117, 35);
            Start.TabIndex = 4;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            // 
            // Stop
            // 
            Stop.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Stop.Location = new Point(404, 266);
            Stop.Name = "Stop";
            Stop.Size = new Size(117, 35);
            Stop.TabIndex = 5;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(27, 169);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 6;
            label3.Text = "Short Break:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(27, 207);
            label4.Name = "label4";
            label4.Size = new Size(113, 28);
            label4.TabIndex = 7;
            label4.Text = "Long Break:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 14F);
            numericUpDown2.Location = new Point(146, 208);
            numericUpDown2.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(43, 32);
            numericUpDown2.TabIndex = 8;
            numericUpDown2.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // numericUpDown3
            // 
            numericUpDown3.Font = new Font("Segoe UI", 14F);
            numericUpDown3.Location = new Point(146, 170);
            numericUpDown3.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(43, 32);
            numericUpDown3.TabIndex = 9;
            numericUpDown3.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(714, 23);
            textBox1.TabIndex = 10;
            textBox1.Text = "Baking a cake";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 323);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Stop);
            Controls.Add(Start);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(Time);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Time;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private Button Start;
        private Button Stop;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private TextBox textBox1;
    }
}

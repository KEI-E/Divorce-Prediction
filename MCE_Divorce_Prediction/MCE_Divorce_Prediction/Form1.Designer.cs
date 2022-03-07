
namespace MCE_Divorce_Prediction
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtbox_Result = new System.Windows.Forms.TextBox();
            this.cmbxQ1 = new System.Windows.Forms.ComboBox();
            this.cmbxQ2 = new System.Windows.Forms.ComboBox();
            this.cmbxQ3 = new System.Windows.Forms.ComboBox();
            this.cmbxQ4 = new System.Windows.Forms.ComboBox();
            this.cmbxQ5 = new System.Windows.Forms.ComboBox();
            this.cmbxQ6 = new System.Windows.Forms.ComboBox();
            this.cmbxQ7 = new System.Windows.Forms.ComboBox();
            this.cmbxQ8 = new System.Windows.Forms.ComboBox();
            this.cmbxQ9 = new System.Windows.Forms.ComboBox();
            this.cmbxQ10 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Neural Network";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.init_Nn);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 178);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "Train Model";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.train_Nn);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(814, 126);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 53);
            this.button3.TabIndex = 2;
            this.button3.Text = "Get Result";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtbox_Result
            // 
            this.txtbox_Result.Location = new System.Drawing.Point(799, 75);
            this.txtbox_Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbox_Result.Name = "txtbox_Result";
            this.txtbox_Result.ReadOnly = true;
            this.txtbox_Result.Size = new System.Drawing.Size(132, 22);
            this.txtbox_Result.TabIndex = 3;
            // 
            // cmbxQ1
            // 
            this.cmbxQ1.FormattingEnabled = true;
            this.cmbxQ1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmbxQ1.Location = new System.Drawing.Point(188, 104);
            this.cmbxQ1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxQ1.Name = "cmbxQ1";
            this.cmbxQ1.Size = new System.Drawing.Size(160, 24);
            this.cmbxQ1.TabIndex = 4;
            this.cmbxQ1.Text = "0";
            // 
            // cmbxQ2
            // 
            this.cmbxQ2.FormattingEnabled = true;
            this.cmbxQ2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmbxQ2.Location = new System.Drawing.Point(188, 182);
            this.cmbxQ2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxQ2.Name = "cmbxQ2";
            this.cmbxQ2.Size = new System.Drawing.Size(160, 24);
            this.cmbxQ2.TabIndex = 5;
            this.cmbxQ2.Text = "0";
            // 
            // cmbxQ3
            // 
            this.cmbxQ3.FormattingEnabled = true;
            this.cmbxQ3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmbxQ3.Location = new System.Drawing.Point(188, 259);
            this.cmbxQ3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxQ3.Name = "cmbxQ3";
            this.cmbxQ3.Size = new System.Drawing.Size(160, 24);
            this.cmbxQ3.TabIndex = 6;
            this.cmbxQ3.Text = "0";
            // 
            // cmbxQ4
            // 
            this.cmbxQ4.FormattingEnabled = true;
            this.cmbxQ4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmbxQ4.Location = new System.Drawing.Point(188, 332);
            this.cmbxQ4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxQ4.Name = "cmbxQ4";
            this.cmbxQ4.Size = new System.Drawing.Size(160, 24);
            this.cmbxQ4.TabIndex = 7;
            this.cmbxQ4.Text = "0";
            // 
            // cmbxQ5
            // 
            this.cmbxQ5.FormattingEnabled = true;
            this.cmbxQ5.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmbxQ5.Location = new System.Drawing.Point(188, 411);
            this.cmbxQ5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxQ5.Name = "cmbxQ5";
            this.cmbxQ5.Size = new System.Drawing.Size(160, 24);
            this.cmbxQ5.TabIndex = 8;
            this.cmbxQ5.Text = "0";
            // 
            // cmbxQ6
            // 
            this.cmbxQ6.FormattingEnabled = true;
            this.cmbxQ6.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmbxQ6.Location = new System.Drawing.Point(187, 495);
            this.cmbxQ6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxQ6.Name = "cmbxQ6";
            this.cmbxQ6.Size = new System.Drawing.Size(160, 24);
            this.cmbxQ6.TabIndex = 9;
            this.cmbxQ6.Text = "0";
            // 
            // cmbxQ7
            // 
            this.cmbxQ7.FormattingEnabled = true;
            this.cmbxQ7.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmbxQ7.Location = new System.Drawing.Point(187, 581);
            this.cmbxQ7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxQ7.Name = "cmbxQ7";
            this.cmbxQ7.Size = new System.Drawing.Size(160, 24);
            this.cmbxQ7.TabIndex = 10;
            this.cmbxQ7.Text = "0";
            // 
            // cmbxQ8
            // 
            this.cmbxQ8.FormattingEnabled = true;
            this.cmbxQ8.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmbxQ8.Location = new System.Drawing.Point(187, 648);
            this.cmbxQ8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxQ8.Name = "cmbxQ8";
            this.cmbxQ8.Size = new System.Drawing.Size(160, 24);
            this.cmbxQ8.TabIndex = 11;
            this.cmbxQ8.Text = "0";
            // 
            // cmbxQ9
            // 
            this.cmbxQ9.FormattingEnabled = true;
            this.cmbxQ9.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmbxQ9.Location = new System.Drawing.Point(187, 724);
            this.cmbxQ9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxQ9.Name = "cmbxQ9";
            this.cmbxQ9.Size = new System.Drawing.Size(160, 24);
            this.cmbxQ9.TabIndex = 12;
            this.cmbxQ9.Text = "0";
            // 
            // cmbxQ10
            // 
            this.cmbxQ10.FormattingEnabled = true;
            this.cmbxQ10.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cmbxQ10.Location = new System.Drawing.Point(188, 801);
            this.cmbxQ10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbxQ10.Name = "cmbxQ10";
            this.cmbxQ10.Size = new System.Drawing.Size(160, 24);
            this.cmbxQ10.TabIndex = 13;
            this.cmbxQ10.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Q1. If one of us apologizes when our discussion deteriorates, the discussion ends" +
    ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Q2. We don\'t have time at home as partners.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(536, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Q3. We are like two strangers who share the same environment at home rather than " +
    "family.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 313);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Q4. Most of our goals are common to my spouse.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 392);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Q5. My spouse and I have similar sense of entertainment.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 475);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(531, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Q6. I can use negative statements about my spouse\'s personality during our discus" +
    "sions.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 549);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Q7. My discussion with my spouse is not calm.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(183, 628);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(318, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Q8. I\'d rather stay silent than discuss with my spouse.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 704);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(199, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Q9. I feel right in our discussions.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 782);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(387, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Q10. I\'m not afraid to tell my spouse about her/his incompetence.";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(64, 369);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 63);
            this.button4.TabIndex = 24;
            this.button4.Text = "Save Weights";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(64, 453);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 63);
            this.button5.TabIndex = 25;
            this.button5.Text = "Load Weights";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(260, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(459, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Rate: (0=Never, 1=Seldom, 2=Averagely, 3=Frequently, 4=Always)";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 844);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxQ10);
            this.Controls.Add(this.cmbxQ9);
            this.Controls.Add(this.cmbxQ8);
            this.Controls.Add(this.cmbxQ7);
            this.Controls.Add(this.cmbxQ6);
            this.Controls.Add(this.cmbxQ5);
            this.Controls.Add(this.cmbxQ4);
            this.Controls.Add(this.cmbxQ3);
            this.Controls.Add(this.cmbxQ2);
            this.Controls.Add(this.cmbxQ1);
            this.Controls.Add(this.txtbox_Result);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtbox_Result;
        private System.Windows.Forms.ComboBox cmbxQ1;
        private System.Windows.Forms.ComboBox cmbxQ2;
        private System.Windows.Forms.ComboBox cmbxQ3;
        private System.Windows.Forms.ComboBox cmbxQ4;
        private System.Windows.Forms.ComboBox cmbxQ5;
        private System.Windows.Forms.ComboBox cmbxQ6;
        private System.Windows.Forms.ComboBox cmbxQ7;
        private System.Windows.Forms.ComboBox cmbxQ8;
        private System.Windows.Forms.ComboBox cmbxQ9;
        private System.Windows.Forms.ComboBox cmbxQ10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label11;
    }
}


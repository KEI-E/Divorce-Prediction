
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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Neural Network";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.init_Nn);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 51);
            this.button2.TabIndex = 1;
            this.button2.Text = "Train Model";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.train_Nn);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(588, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Get Result";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtbox_Result
            // 
            this.txtbox_Result.Location = new System.Drawing.Point(577, 213);
            this.txtbox_Result.Name = "txtbox_Result";
            this.txtbox_Result.ReadOnly = true;
            this.txtbox_Result.Size = new System.Drawing.Size(100, 20);
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
            this.cmbxQ1.Location = new System.Drawing.Point(141, 50);
            this.cmbxQ1.Name = "cmbxQ1";
            this.cmbxQ1.Size = new System.Drawing.Size(121, 21);
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
            this.cmbxQ2.Location = new System.Drawing.Point(141, 114);
            this.cmbxQ2.Name = "cmbxQ2";
            this.cmbxQ2.Size = new System.Drawing.Size(121, 21);
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
            this.cmbxQ3.Location = new System.Drawing.Point(141, 176);
            this.cmbxQ3.Name = "cmbxQ3";
            this.cmbxQ3.Size = new System.Drawing.Size(121, 21);
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
            this.cmbxQ4.Location = new System.Drawing.Point(141, 236);
            this.cmbxQ4.Name = "cmbxQ4";
            this.cmbxQ4.Size = new System.Drawing.Size(121, 21);
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
            this.cmbxQ5.Location = new System.Drawing.Point(141, 300);
            this.cmbxQ5.Name = "cmbxQ5";
            this.cmbxQ5.Size = new System.Drawing.Size(121, 21);
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
            this.cmbxQ6.Location = new System.Drawing.Point(140, 368);
            this.cmbxQ6.Name = "cmbxQ6";
            this.cmbxQ6.Size = new System.Drawing.Size(121, 21);
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
            this.cmbxQ7.Location = new System.Drawing.Point(140, 438);
            this.cmbxQ7.Name = "cmbxQ7";
            this.cmbxQ7.Size = new System.Drawing.Size(121, 21);
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
            this.cmbxQ8.Location = new System.Drawing.Point(140, 492);
            this.cmbxQ8.Name = "cmbxQ8";
            this.cmbxQ8.Size = new System.Drawing.Size(121, 21);
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
            this.cmbxQ9.Location = new System.Drawing.Point(140, 554);
            this.cmbxQ9.Name = "cmbxQ9";
            this.cmbxQ9.Size = new System.Drawing.Size(121, 21);
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
            this.cmbxQ10.Location = new System.Drawing.Point(141, 617);
            this.cmbxQ10.Name = "cmbxQ10";
            this.cmbxQ10.Size = new System.Drawing.Size(121, 21);
            this.cmbxQ10.TabIndex = 13;
            this.cmbxQ10.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Q1. If one of us apologizes when our discussion deteriorates, the discussion ends" +
    ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Q2. I know we can ignore our differences, even if things get hard sometimes.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Q3. The time I spent with my wife is special for us.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Q4. We don\'t have time at home as partners.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Q5. I enjoy our holidays with my wife.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(503, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Q6. I think that one day in the future, when I look back, I see that my spouse an" +
    "d I have been in harmony\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(137, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Q7. Most of our goals for people (children, friends, etc.) are the same.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 476);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(336, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Q8. My spouse and I have similar ideas about how marriage should be";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(137, 538);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(372, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Q9. My spouse and I have similar ideas about how roles should be in marriage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 601);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Q10. My spouse and I have similar values in trust.";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(48, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 51);
            this.button4.TabIndex = 24;
            this.button4.Text = "Save Weights";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(48, 368);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 51);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 686);
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
    }
}


namespace LabExercise2
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
            this.btnArray1 = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnArray5 = new System.Windows.Forms.Button();
            this.btnArray4 = new System.Windows.Forms.Button();
            this.btnArray3 = new System.Windows.Forms.Button();
            this.btnArray2 = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumEl = new System.Windows.Forms.Label();
            this.lblAvgEl = new System.Windows.Forms.Label();
            this.lblSumEl = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnArray1
            // 
            this.btnArray1.Location = new System.Drawing.Point(49, 104);
            this.btnArray1.Name = "btnArray1";
            this.btnArray1.Size = new System.Drawing.Size(100, 23);
            this.btnArray1.TabIndex = 0;
            this.btnArray1.Text = "Add to Array #1";
            this.btnArray1.UseVisualStyleBackColor = true;
            this.btnArray1.Click += new System.EventHandler(this.btnArray1_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(413, 70);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(89, 23);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display Array";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnArray5
            // 
            this.btnArray5.Location = new System.Drawing.Point(49, 220);
            this.btnArray5.Name = "btnArray5";
            this.btnArray5.Size = new System.Drawing.Size(100, 23);
            this.btnArray5.TabIndex = 4;
            this.btnArray5.Text = "Add to Array #5";
            this.btnArray5.UseVisualStyleBackColor = true;
            this.btnArray5.Click += new System.EventHandler(this.btnArray5_Click);
            // 
            // btnArray4
            // 
            this.btnArray4.Location = new System.Drawing.Point(49, 191);
            this.btnArray4.Name = "btnArray4";
            this.btnArray4.Size = new System.Drawing.Size(100, 23);
            this.btnArray4.TabIndex = 5;
            this.btnArray4.Text = "Add to Array #4";
            this.btnArray4.UseVisualStyleBackColor = true;
            this.btnArray4.Click += new System.EventHandler(this.btnArray4_Click);
            // 
            // btnArray3
            // 
            this.btnArray3.Location = new System.Drawing.Point(49, 162);
            this.btnArray3.Name = "btnArray3";
            this.btnArray3.Size = new System.Drawing.Size(100, 23);
            this.btnArray3.TabIndex = 6;
            this.btnArray3.Text = "Add to Array #3";
            this.btnArray3.UseVisualStyleBackColor = true;
            this.btnArray3.Click += new System.EventHandler(this.btnArray3_Click);
            // 
            // btnArray2
            // 
            this.btnArray2.Location = new System.Drawing.Point(49, 133);
            this.btnArray2.Name = "btnArray2";
            this.btnArray2.Size = new System.Drawing.Size(100, 23);
            this.btnArray2.TabIndex = 7;
            this.btnArray2.Text = "Add to Array #2";
            this.btnArray2.UseVisualStyleBackColor = true;
            this.btnArray2.Click += new System.EventHandler(this.btnArray2_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(49, 73);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 8;
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(178, 73);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(218, 173);
            this.lstDisplay.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "# Of Elements:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sum of Elements:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Average of Elements:";
            // 
            // lblNumEl
            // 
            this.lblNumEl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumEl.Location = new System.Drawing.Point(410, 133);
            this.lblNumEl.Name = "lblNumEl";
            this.lblNumEl.Size = new System.Drawing.Size(100, 23);
            this.lblNumEl.TabIndex = 13;
            // 
            // lblAvgEl
            // 
            this.lblAvgEl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvgEl.Location = new System.Drawing.Point(410, 254);
            this.lblAvgEl.Name = "lblAvgEl";
            this.lblAvgEl.Size = new System.Drawing.Size(100, 23);
            this.lblAvgEl.TabIndex = 14;
            // 
            // lblSumEl
            // 
            this.lblSumEl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSumEl.Location = new System.Drawing.Point(410, 191);
            this.lblSumEl.Name = "lblSumEl";
            this.lblSumEl.Size = new System.Drawing.Size(100, 23);
            this.lblSumEl.TabIndex = 15;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 281);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(545, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 303);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblSumEl);
            this.Controls.Add(this.lblAvgEl);
            this.Controls.Add(this.lblNumEl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnArray2);
            this.Controls.Add(this.btnArray3);
            this.Controls.Add(this.btnArray4);
            this.Controls.Add(this.btnArray5);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnArray1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnArray1;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnArray5;
        private System.Windows.Forms.Button btnArray4;
        private System.Windows.Forms.Button btnArray3;
        private System.Windows.Forms.Button btnArray2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumEl;
        private System.Windows.Forms.Label lblAvgEl;
        private System.Windows.Forms.Label lblSumEl;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}


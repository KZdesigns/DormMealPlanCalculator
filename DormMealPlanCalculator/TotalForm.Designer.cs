namespace DormMealPlanCalculator
{
    partial class TotalForm
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
            this.totalChargesFormLabel = new System.Windows.Forms.Label();
            this.totalChargesGroupBox = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.selectedMealPlanLabel = new System.Windows.Forms.Label();
            this.selectedDromLabel = new System.Windows.Forms.Label();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.totalChargesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalChargesFormLabel
            // 
            this.totalChargesFormLabel.AutoSize = true;
            this.totalChargesFormLabel.Location = new System.Drawing.Point(163, 38);
            this.totalChargesFormLabel.Name = "totalChargesFormLabel";
            this.totalChargesFormLabel.Size = new System.Drawing.Size(113, 13);
            this.totalChargesFormLabel.TabIndex = 0;
            this.totalChargesFormLabel.Text = "Student Total Charges";
            // 
            // totalChargesGroupBox
            // 
            this.totalChargesGroupBox.Controls.Add(this.totalLabel);
            this.totalChargesGroupBox.Controls.Add(this.selectedMealPlanLabel);
            this.totalChargesGroupBox.Controls.Add(this.selectedDromLabel);
            this.totalChargesGroupBox.Location = new System.Drawing.Point(99, 72);
            this.totalChargesGroupBox.Name = "totalChargesGroupBox";
            this.totalChargesGroupBox.Size = new System.Drawing.Size(274, 161);
            this.totalChargesGroupBox.TabIndex = 1;
            this.totalChargesGroupBox.TabStop = false;
            this.totalChargesGroupBox.Text = "Student Total Per Semester";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(64, 109);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 13);
            this.totalLabel.TabIndex = 2;
            // 
            // selectedMealPlanLabel
            // 
            this.selectedMealPlanLabel.AutoSize = true;
            this.selectedMealPlanLabel.Location = new System.Drawing.Point(64, 67);
            this.selectedMealPlanLabel.Name = "selectedMealPlanLabel";
            this.selectedMealPlanLabel.Size = new System.Drawing.Size(0, 13);
            this.selectedMealPlanLabel.TabIndex = 1;
            // 
            // selectedDromLabel
            // 
            this.selectedDromLabel.AutoSize = true;
            this.selectedDromLabel.Location = new System.Drawing.Point(64, 30);
            this.selectedDromLabel.Name = "selectedDromLabel";
            this.selectedDromLabel.Size = new System.Drawing.Size(0, 13);
            this.selectedDromLabel.TabIndex = 0;
            // 
            // goBackBtn
            // 
            this.goBackBtn.Location = new System.Drawing.Point(201, 278);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(75, 23);
            this.goBackBtn.TabIndex = 2;
            this.goBackBtn.Text = "Go Back";
            this.goBackBtn.UseVisualStyleBackColor = true;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(282, 278);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(125, 23);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save and Exit";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // TotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 328);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.goBackBtn);
            this.Controls.Add(this.totalChargesGroupBox);
            this.Controls.Add(this.totalChargesFormLabel);
            this.Name = "TotalForm";
            this.Text = "Student Total";
            this.totalChargesGroupBox.ResumeLayout(false);
            this.totalChargesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalChargesFormLabel;
        private System.Windows.Forms.GroupBox totalChargesGroupBox;
        private System.Windows.Forms.Button goBackBtn;
        private System.Windows.Forms.Button saveBtn;
        public System.Windows.Forms.Label totalLabel;
        public System.Windows.Forms.Label selectedMealPlanLabel;
        public System.Windows.Forms.Label selectedDromLabel;
    }
}
namespace Prog2
{
    partial class Prog2
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
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.classStandingBox = new System.Windows.Forms.GroupBox();
            this.seniorRadio = new System.Windows.Forms.RadioButton();
            this.juniorRadio = new System.Windows.Forms.RadioButton();
            this.sophomoreRadio = new System.Windows.Forms.RadioButton();
            this.freshmanRadio = new System.Windows.Forms.RadioButton();
            this.classStandingBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastNameInput
            // 
            this.lastNameInput.Location = new System.Drawing.Point(128, 20);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(100, 20);
            this.lastNameInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Last Name:";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(105, 174);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(68, 206);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(148, 13);
            this.outputDescriptionLabel.TabIndex = 5;
            this.outputDescriptionLabel.Text = "You May Register Starting at: ";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(38, 229);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(208, 23);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classStandingBox
            // 
            this.classStandingBox.Controls.Add(this.freshmanRadio);
            this.classStandingBox.Controls.Add(this.sophomoreRadio);
            this.classStandingBox.Controls.Add(this.juniorRadio);
            this.classStandingBox.Controls.Add(this.seniorRadio);
            this.classStandingBox.Location = new System.Drawing.Point(46, 51);
            this.classStandingBox.Name = "classStandingBox";
            this.classStandingBox.Size = new System.Drawing.Size(192, 107);
            this.classStandingBox.TabIndex = 7;
            this.classStandingBox.TabStop = false;
            this.classStandingBox.Text = "Class Standing";
            // 
            // seniorRadio
            // 
            this.seniorRadio.AutoSize = true;
            this.seniorRadio.Location = new System.Drawing.Point(9, 16);
            this.seniorRadio.Name = "seniorRadio";
            this.seniorRadio.Size = new System.Drawing.Size(55, 17);
            this.seniorRadio.TabIndex = 0;
            this.seniorRadio.TabStop = true;
            this.seniorRadio.Text = "Senior";
            this.seniorRadio.UseVisualStyleBackColor = true;
            // 
            // juniorRadio
            // 
            this.juniorRadio.AutoSize = true;
            this.juniorRadio.Location = new System.Drawing.Point(9, 39);
            this.juniorRadio.Name = "juniorRadio";
            this.juniorRadio.Size = new System.Drawing.Size(53, 17);
            this.juniorRadio.TabIndex = 1;
            this.juniorRadio.TabStop = true;
            this.juniorRadio.Text = "Junior";
            this.juniorRadio.UseVisualStyleBackColor = true;
            // 
            // sophomoreRadio
            // 
            this.sophomoreRadio.AutoSize = true;
            this.sophomoreRadio.Location = new System.Drawing.Point(9, 62);
            this.sophomoreRadio.Name = "sophomoreRadio";
            this.sophomoreRadio.Size = new System.Drawing.Size(79, 17);
            this.sophomoreRadio.TabIndex = 2;
            this.sophomoreRadio.TabStop = true;
            this.sophomoreRadio.Text = "Sophomore";
            this.sophomoreRadio.UseVisualStyleBackColor = true;
            // 
            // freshmanRadio
            // 
            this.freshmanRadio.AutoSize = true;
            this.freshmanRadio.Location = new System.Drawing.Point(9, 85);
            this.freshmanRadio.Name = "freshmanRadio";
            this.freshmanRadio.Size = new System.Drawing.Size(71, 17);
            this.freshmanRadio.TabIndex = 3;
            this.freshmanRadio.TabStop = true;
            this.freshmanRadio.Text = "Freshman";
            this.freshmanRadio.UseVisualStyleBackColor = true;
            // 
            // Prog2
            // 
            this.AcceptButton = this.enterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.classStandingBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameInput);
            this.Name = "Prog2";
            this.Text = "Program 2";
            this.classStandingBox.ResumeLayout(false);
            this.classStandingBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.GroupBox classStandingBox;
        private System.Windows.Forms.RadioButton freshmanRadio;
        private System.Windows.Forms.RadioButton sophomoreRadio;
        private System.Windows.Forms.RadioButton juniorRadio;
        private System.Windows.Forms.RadioButton seniorRadio;
    }
}


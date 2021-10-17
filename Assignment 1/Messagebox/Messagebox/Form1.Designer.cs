
namespace Messagebox
{
    partial class instructionManual
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
            this.insManual = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.nameCheck = new System.Windows.Forms.CheckBox();
            this.courseCheck = new System.Windows.Forms.CheckBox();
            this.univCheck = new System.Windows.Forms.CheckBox();
            this.yearCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // insManual
            // 
            this.insManual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.insManual.AutoSize = true;
            this.insManual.Location = new System.Drawing.Point(34, 9);
            this.insManual.Name = "insManual";
            this.insManual.Size = new System.Drawing.Size(227, 30);
            this.insManual.TabIndex = 0;
            this.insManual.Text = "Check the information you want to know,\r\nthen press the submit button";
            // 
            // submitButton
            // 
            this.submitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitButton.Location = new System.Drawing.Point(110, 132);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // nameCheck
            // 
            this.nameCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nameCheck.AutoSize = true;
            this.nameCheck.Checked = true;
            this.nameCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.nameCheck.Location = new System.Drawing.Point(42, 55);
            this.nameCheck.Name = "nameCheck";
            this.nameCheck.Size = new System.Drawing.Size(80, 19);
            this.nameCheck.TabIndex = 2;
            this.nameCheck.Text = "Full Name";
            this.nameCheck.UseVisualStyleBackColor = true;
            this.nameCheck.CheckedChanged += new System.EventHandler(this.nameCheck_CheckedChanged);
            // 
            // courseCheck
            // 
            this.courseCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.courseCheck.AutoSize = true;
            this.courseCheck.Location = new System.Drawing.Point(42, 93);
            this.courseCheck.Name = "courseCheck";
            this.courseCheck.Size = new System.Drawing.Size(63, 19);
            this.courseCheck.TabIndex = 3;
            this.courseCheck.Text = "Course";
            this.courseCheck.UseVisualStyleBackColor = true;
            this.courseCheck.CheckedChanged += new System.EventHandler(this.courseCheck_CheckedChanged);
            // 
            // univCheck
            // 
            this.univCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.univCheck.AutoSize = true;
            this.univCheck.Location = new System.Drawing.Point(157, 93);
            this.univCheck.Name = "univCheck";
            this.univCheck.Size = new System.Drawing.Size(78, 19);
            this.univCheck.TabIndex = 4;
            this.univCheck.Text = "University";
            this.univCheck.UseVisualStyleBackColor = true;
            this.univCheck.CheckedChanged += new System.EventHandler(this.univCheck_CheckedChanged);
            // 
            // yearCheck
            // 
            this.yearCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.yearCheck.AutoSize = true;
            this.yearCheck.Location = new System.Drawing.Point(157, 55);
            this.yearCheck.Name = "yearCheck";
            this.yearCheck.Size = new System.Drawing.Size(78, 19);
            this.yearCheck.TabIndex = 5;
            this.yearCheck.Text = "Year Level";
            this.yearCheck.UseVisualStyleBackColor = true;
            this.yearCheck.CheckedChanged += new System.EventHandler(this.yearCheck_CheckedChanged);
            // 
            // instructionManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 167);
            this.Controls.Add(this.yearCheck);
            this.Controls.Add(this.univCheck);
            this.Controls.Add(this.courseCheck);
            this.Controls.Add(this.nameCheck);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.insManual);
            this.MaximumSize = new System.Drawing.Size(315, 206);
            this.MinimumSize = new System.Drawing.Size(270, 206);
            this.Name = "instructionManual";
            this.Text = "Assignment #1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label insManual;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.CheckBox nameCheck;
        private System.Windows.Forms.CheckBox courseCheck;
        private System.Windows.Forms.CheckBox univCheck;
        private System.Windows.Forms.CheckBox yearCheck;
    }
}


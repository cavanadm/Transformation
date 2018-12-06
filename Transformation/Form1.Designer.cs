namespace Transformation
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
            this.transformbtn = new System.Windows.Forms.Button();
            this.transformTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // transformbtn
            // 
            this.transformbtn.Location = new System.Drawing.Point(12, 13);
            this.transformbtn.Name = "transformbtn";
            this.transformbtn.Size = new System.Drawing.Size(343, 23);
            this.transformbtn.TabIndex = 0;
            this.transformbtn.Text = "Transform XML";
            this.transformbtn.UseVisualStyleBackColor = true;
            this.transformbtn.Click += new System.EventHandler(this.transformbtn_Click);
            // 
            // transformTxtBox
            // 
            this.transformTxtBox.Location = new System.Drawing.Point(12, 42);
            this.transformTxtBox.Multiline = true;
            this.transformTxtBox.Name = "transformTxtBox";
            this.transformTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.transformTxtBox.Size = new System.Drawing.Size(343, 279);
            this.transformTxtBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 333);
            this.Controls.Add(this.transformTxtBox);
            this.Controls.Add(this.transformbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button transformbtn;
        private System.Windows.Forms.TextBox transformTxtBox;
    }
}


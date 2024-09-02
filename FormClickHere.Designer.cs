
namespace TestPluginWindowHello
{
    partial class FormClickHere
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
            this.clickHereButton = new System.Windows.Forms.Button();
            this.label1Txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clickHereButton
            // 
            this.clickHereButton.Location = new System.Drawing.Point(345, 100);
            this.clickHereButton.Name = "clickHereButton";
            this.clickHereButton.Size = new System.Drawing.Size(75, 23);
            this.clickHereButton.TabIndex = 0;
            this.clickHereButton.Text = "Click here !";
            this.clickHereButton.UseVisualStyleBackColor = true;
            this.clickHereButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1Txt
            // 
            this.label1Txt.AutoSize = true;
            this.label1Txt.Location = new System.Drawing.Point(368, 126);
            this.label1Txt.Name = "label1Txt";
            this.label1Txt.Size = new System.Drawing.Size(41, 13);
            this.label1Txt.TabIndex = 1;
            this.label1Txt.Text = "label12";
            this.label1Txt.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormClickHere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1Txt);
            this.Controls.Add(this.clickHereButton);
            this.Name = "FormClickHere";
            this.Text = "Hello World form !";
            this.Load += new System.EventHandler(this.FormClickHere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clickHereButton;
        private System.Windows.Forms.Label label1Txt;
    }
}
namespace WindowsFormsApplication2
{
    partial class myFirstForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myFirstForm));
            this.label1 = new System.Windows.Forms.Label();
            this.Boop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(69, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 209);
            this.label1.TabIndex = 0;
            // 
            // Boop
            // 
            this.Boop.Location = new System.Drawing.Point(170, 263);
            this.Boop.Name = "Boop";
            this.Boop.Size = new System.Drawing.Size(174, 63);
            this.Boop.TabIndex = 1;
            this.Boop.Text = "Boop";
            this.Boop.UseVisualStyleBackColor = true;
            this.Boop.Click += new System.EventHandler(this.button1_Click);
            // 
            // myFirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 348);
            this.Controls.Add(this.Boop);
            this.Controls.Add(this.label1);
            this.Name = "myFirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Boop;
    }
}


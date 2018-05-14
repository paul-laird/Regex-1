namespace Regex
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
            this.btnMatch = new System.Windows.Forms.Button();
            this.txtNeedle = new System.Windows.Forms.TextBox();
            this.txtHaystack = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(125, 206);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(100, 23);
            this.btnMatch.TabIndex = 0;
            this.btnMatch.Text = "Find Matches";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNeedle
            // 
            this.txtNeedle.Location = new System.Drawing.Point(125, 56);
            this.txtNeedle.Name = "txtNeedle";
            this.txtNeedle.Size = new System.Drawing.Size(100, 20);
            this.txtNeedle.TabIndex = 1;
            // 
            // txtHaystack
            // 
            this.txtHaystack.Location = new System.Drawing.Point(125, 110);
            this.txtHaystack.Name = "txtHaystack";
            this.txtHaystack.Size = new System.Drawing.Size(100, 20);
            this.txtHaystack.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Needle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Haystack:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 358);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHaystack);
            this.Controls.Add(this.txtNeedle);
            this.Controls.Add(this.btnMatch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.TextBox txtNeedle;
        private System.Windows.Forms.TextBox txtHaystack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


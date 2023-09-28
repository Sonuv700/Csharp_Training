
namespace RemotingClient
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
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.textnum1 = new System.Windows.Forms.TextBox();
            this.textnum2 = new System.Windows.Forms.TextBox();
            this.textresult = new System.Windows.Forms.TextBox();
            this.btnhighestnum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(67, 88);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(119, 20);
            this.lblnum1.TabIndex = 0;
            this.lblnum1.Text = "Enter number 1";
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(67, 226);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(119, 20);
            this.lblnum2.TabIndex = 1;
            this.lblnum2.Text = "Enter number 2";
            // 
            // textnum1
            // 
            this.textnum1.Location = new System.Drawing.Point(379, 88);
            this.textnum1.Name = "textnum1";
            this.textnum1.Size = new System.Drawing.Size(100, 26);
            this.textnum1.TabIndex = 2;
            // 
            // textnum2
            // 
            this.textnum2.Location = new System.Drawing.Point(379, 226);
            this.textnum2.Name = "textnum2";
            this.textnum2.Size = new System.Drawing.Size(100, 26);
            this.textnum2.TabIndex = 3;
            // 
            // textresult
            // 
            this.textresult.Location = new System.Drawing.Point(629, 159);
            this.textresult.Name = "textresult";
            this.textresult.Size = new System.Drawing.Size(100, 26);
            this.textresult.TabIndex = 4;
            // 
            // btnhighestnum
            // 
            this.btnhighestnum.Location = new System.Drawing.Point(216, 330);
            this.btnhighestnum.Name = "btnhighestnum";
            this.btnhighestnum.Size = new System.Drawing.Size(201, 33);
            this.btnhighestnum.TabIndex = 5;
            this.btnhighestnum.Text = "Highest Number";
            this.btnhighestnum.UseVisualStyleBackColor = true;
            this.btnhighestnum.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhighestnum);
            this.Controls.Add(this.textresult);
            this.Controls.Add(this.textnum2);
            this.Controls.Add(this.textnum1);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.lblnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.TextBox textnum1;
        private System.Windows.Forms.TextBox textnum2;
        private System.Windows.Forms.TextBox textresult;
        private System.Windows.Forms.Button btnhighestnum;
    }
}


namespace SharpRPC
{
    partial class MessageShow
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
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.ForeColor = System.Drawing.Color.White;
            this.message.Location = new System.Drawing.Point(12, 45);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(32, 15);
            this.message.TabIndex = 0;
            this.message.Text = "Error";
            // 
            // MessageShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(69)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(364, 109);
            this.Controls.Add(this.message);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageShow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label message;
    }
}
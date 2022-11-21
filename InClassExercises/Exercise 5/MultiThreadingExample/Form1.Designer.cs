namespace MultiThreadingExample
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
            this.startBT = new System.Windows.Forms.Button();
            this.taskPB = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // startBT
            // 
            this.startBT.Location = new System.Drawing.Point(644, 53);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(144, 54);
            this.startBT.TabIndex = 0;
            this.startBT.Text = "Start";
            this.startBT.UseVisualStyleBackColor = true;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // taskPB
            // 
            this.taskPB.Location = new System.Drawing.Point(12, 53);
            this.taskPB.Name = "taskPB";
            this.taskPB.Size = new System.Drawing.Size(598, 54);
            this.taskPB.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.taskPB);
            this.Controls.Add(this.startBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startBT;
        private System.Windows.Forms.ProgressBar taskPB;
    }
}


namespace WfClock
{
    partial class formClock
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelShoweTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelShoweTime
            // 
            this.labelShoweTime.AutoSize = true;
            this.labelShoweTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelShoweTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShoweTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelShoweTime.Location = new System.Drawing.Point(0, 0);
            this.labelShoweTime.Name = "labelShoweTime";
            this.labelShoweTime.Size = new System.Drawing.Size(106, 44);
            this.labelShoweTime.TabIndex = 0;
            this.labelShoweTime.Text = "Time";
            this.labelShoweTime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseClick);
            // 
            // formClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(809, 134);
            this.Controls.Add(this.labelShoweTime);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "formClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Clock_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Clock_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelShoweTime;
    }
}


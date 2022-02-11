namespace Forms
{
    partial class EventForm
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEvent = new System.Windows.Forms.Label();
            this.btnSave = new Forms.CustomButtons();
            this.txtEvent = new CustomControls.RJControls.RJTextBox();
            this.txtDate = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(31, 24);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 21);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblEvent.Location = new System.Drawing.Point(31, 147);
            this.lblEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(48, 21);
            this.lblEvent.TabIndex = 3;
            this.lblEvent.Text = "Event";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(303, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEvent
            // 
            this.txtEvent.BackColor = System.Drawing.SystemColors.Window;
            this.txtEvent.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEvent.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEvent.BorderRadius = 15;
            this.txtEvent.BorderSize = 2;
            this.txtEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEvent.Location = new System.Drawing.Point(15, 174);
            this.txtEvent.Margin = new System.Windows.Forms.Padding(6);
            this.txtEvent.Multiline = false;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtEvent.PasswordChar = false;
            this.txtEvent.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEvent.PlaceholderText = "";
            this.txtEvent.Size = new System.Drawing.Size(438, 39);
            this.txtEvent.TabIndex = 1;
            this.txtEvent.Texts = "";
            this.txtEvent.UnderlinedStyle = false;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtDate.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDate.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDate.BorderRadius = 15;
            this.txtDate.BorderSize = 2;
            this.txtDate.Enabled = false;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDate.Location = new System.Drawing.Point(15, 51);
            this.txtDate.Margin = new System.Windows.Forms.Padding(6);
            this.txtDate.Multiline = false;
            this.txtDate.Name = "txtDate";
            this.txtDate.Padding = new System.Windows.Forms.Padding(15, 11, 15, 11);
            this.txtDate.PasswordChar = false;
            this.txtDate.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDate.PlaceholderText = "";
            this.txtDate.Size = new System.Drawing.Size(438, 39);
            this.txtDate.TabIndex = 0;
            this.txtDate.Texts = "";
            this.txtDate.UnderlinedStyle = false;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 348);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.txtDate);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtDate;
        private CustomControls.RJControls.RJTextBox txtEvent;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEvent;
        private CustomButtons btnSave;
    }
}
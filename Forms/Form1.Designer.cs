namespace Forms
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.iconMenu = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.Button();
            this.homeUserControl1 = new Forms.HomeUserControl();
            this.calendarUserControl1 = new Forms.CalendarUserControl();
            this.sidebar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.sidebar.Controls.Add(this.panelMenu);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(197, 495);
            this.sidebar.MinimumSize = new System.Drawing.Size(55, 495);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(197, 495);
            this.sidebar.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.labelMenu);
            this.panelMenu.Controls.Add(this.iconMenu);
            this.panelMenu.Location = new System.Drawing.Point(3, 3);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(194, 105);
            this.panelMenu.TabIndex = 2;
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelMenu.ForeColor = System.Drawing.Color.White;
            this.labelMenu.Location = new System.Drawing.Point(48, 37);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(62, 28);
            this.labelMenu.TabIndex = 3;
            this.labelMenu.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Home);
            this.panel1.Location = new System.Drawing.Point(3, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 51);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Calendar);
            this.panel3.Location = new System.Drawing.Point(3, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 51);
            this.panel3.TabIndex = 3;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.lblhora.Location = new System.Drawing.Point(853, 441);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(64, 25);
            this.lblhora.TabIndex = 1;
            this.lblhora.Text = "label1";
            this.lblhora.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblhora.Click += new System.EventHandler(this.lblhora_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblfecha.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblfecha.Location = new System.Drawing.Point(854, 466);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(53, 20);
            this.lblfecha.TabIndex = 2;
            this.lblfecha.Text = "label2";
            this.lblfecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // iconMenu
            // 
            this.iconMenu.Image = global::Forms.Properties.Resources.menu_50px;
            this.iconMenu.Location = new System.Drawing.Point(9, 39);
            this.iconMenu.Name = "iconMenu";
            this.iconMenu.Size = new System.Drawing.Size(33, 26);
            this.iconMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMenu.TabIndex = 0;
            this.iconMenu.TabStop = false;
            this.iconMenu.Click += new System.EventHandler(this.iconMenu_Click);
            // 
            // Home
            // 
            this.Home.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Image = global::Forms.Properties.Resources.home_24px;
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(-20, -8);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Home.Size = new System.Drawing.Size(214, 67);
            this.Home.TabIndex = 1;
            this.Home.Text = "         Home";
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Calendar
            // 
            this.Calendar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Calendar.ForeColor = System.Drawing.Color.White;
            this.Calendar.Image = global::Forms.Properties.Resources.calendar_24px;
            this.Calendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Calendar.Location = new System.Drawing.Point(-20, -8);
            this.Calendar.Name = "Calendar";
            this.Calendar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Calendar.Size = new System.Drawing.Size(214, 67);
            this.Calendar.TabIndex = 1;
            this.Calendar.Text = "         Calendar";
            this.Calendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Calendar.UseVisualStyleBackColor = false;
            // 
            // homeUserControl1
            // 
            this.homeUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeUserControl1.Location = new System.Drawing.Point(197, 0);
            this.homeUserControl1.Name = "homeUserControl1";
            this.homeUserControl1.Size = new System.Drawing.Size(781, 495);
            this.homeUserControl1.TabIndex = 3;
            // 
            // calendarUserControl1
            // 
            this.calendarUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarUserControl1.Location = new System.Drawing.Point(197, 0);
            this.calendarUserControl1.Name = "calendarUserControl1";
            this.calendarUserControl1.Size = new System.Drawing.Size(781, 495);
            this.calendarUserControl1.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(978, 495);
            this.ControlBox = false;
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.calendarUserControl1);
            this.Controls.Add(this.homeUserControl1);
            this.Controls.Add(this.sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.sidebar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
      
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Calendar;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.PictureBox iconMenu;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private HomeUserControl homeUserControl1;
        private CalendarUserControl calendarUserControl1;
    }
}


namespace Forms
{
    partial class Main
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
            this.iconMenu = new System.Windows.Forms.PictureBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.listViewUserControl = new Forms.ListViewUserControl();
            this.sidebar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMenu)).BeginInit();
            this.panelHome.SuspendLayout();
            this.panelCalendar.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.sidebar.Controls.Add(this.panelMenu);
            this.sidebar.Controls.Add(this.panelHome);
            this.sidebar.Controls.Add(this.panelCalendar);
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
            this.labelMenu.Location = new System.Drawing.Point(48, 41);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(50, 21);
            this.labelMenu.TabIndex = 3;
            this.labelMenu.Text = "Menu";
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
            // panelHome
            // 
            this.panelHome.Controls.Add(this.btnHome);
            this.panelHome.Location = new System.Drawing.Point(3, 114);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(186, 51);
            this.panelHome.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::Forms.Properties.Resources.home_24px;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-20, -8);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(214, 67);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "         Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.Home_Click);
            // 
            // panelCalendar
            // 
            this.panelCalendar.Controls.Add(this.btnCalendar);
            this.panelCalendar.Location = new System.Drawing.Point(3, 171);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(186, 51);
            this.panelCalendar.TabIndex = 3;
            // 
            // btnCalendar
            // 
            this.btnCalendar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCalendar.ForeColor = System.Drawing.Color.White;
            this.btnCalendar.Image = global::Forms.Properties.Resources.calendar_24px;
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(-20, -8);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCalendar.Size = new System.Drawing.Size(214, 67);
            this.btnCalendar.TabIndex = 1;
            this.btnCalendar.Text = "         Calendar";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // listViewUserControl
            // 
            this.listViewUserControl.AutoSize = true;
            this.listViewUserControl.Location = new System.Drawing.Point(194, 0);
            this.listViewUserControl.Margin = new System.Windows.Forms.Padding(2);
            this.listViewUserControl.Name = "listViewUserControl";
            this.listViewUserControl.Size = new System.Drawing.Size(784, 495);
            this.listViewUserControl.TabIndex = 3;
            this.listViewUserControl.Load += new System.EventHandler(this.homeUserControl1_Load);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(978, 495);
            this.ControlBox = false;
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.listViewUserControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.sidebar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconMenu)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panelCalendar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
      
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelCalendar;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.PictureBox iconMenu;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Timer sidebarTimer;
        private ListViewUserControl listViewUserControl;
    }
}


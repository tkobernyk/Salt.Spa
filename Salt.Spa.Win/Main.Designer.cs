using System;
using DevExpress.XtraScheduler;

namespace Salt.Spa.Win
{
    partial class FrmMain
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
            DevExpress.XtraScheduler.TimeRuler timeRuler4 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler5 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler6 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.adornerUIManager1 = new DevExpress.Utils.VisualEffects.AdornerUIManager(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSaltSPAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbsMain = new System.Windows.Forms.TabControl();
            this.tbSaltRoom = new System.Windows.Forms.TabPage();
            this.gcCurrentState = new DevExpress.XtraGrid.GridControl();
            this.gvCurrentState = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gbPlaces = new System.Windows.Forms.GroupBox();
            this.tbScheduler = new System.Windows.Forms.TabPage();
            this.dnCalendar = new DevExpress.XtraScheduler.DateNavigator();
            this.schDailyScheduler = new DevExpress.XtraScheduler.SchedulerControl();
            this.tbSearch = new System.Windows.Forms.TabPage();
            this.gbCustomerGrid = new System.Windows.Forms.GroupBox();
            this.lblSessions = new System.Windows.Forms.Label();
            this.gcSessions = new DevExpress.XtraGrid.GridControl();
            this.gvSessions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCustomers = new DevExpress.XtraGrid.GridControl();
            this.gvCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gbParameters = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSubscription = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblSubscription = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.pnlNotification = new System.Windows.Forms.Panel();
            this.customerSource = new System.Windows.Forms.BindingSource(this.components);
            this.sessionSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adornerUIManager1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tbsMain.SuspendLayout();
            this.tbSaltRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCurrentState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCurrentState)).BeginInit();
            this.tbScheduler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dnCalendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnCalendar.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schDailyScheduler)).BeginInit();
            this.tbSearch.SuspendLayout();
            this.gbCustomerGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSessions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSessions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).BeginInit();
            this.gbParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adornerUIManager1
            // 
            this.adornerUIManager1.Owner = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCustomerToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.addToolStripMenuItem.Text = "&Додати";
            // 
            // newCustomerToolStripMenuItem
            // 
            this.newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            this.newCustomerToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newCustomerToolStripMenuItem.Text = "Новий клієнт";
            this.newCustomerToolStripMenuItem.Click += new System.EventHandler(this.newCustomerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSaltSPAToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutSaltSPAToolStripMenuItem
            // 
            this.aboutSaltSPAToolStripMenuItem.Name = "aboutSaltSPAToolStripMenuItem";
            this.aboutSaltSPAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutSaltSPAToolStripMenuItem.Text = "A&bout Salt SPA";
            // 
            // tbsMain
            // 
            this.tbsMain.Controls.Add(this.tbSaltRoom);
            this.tbsMain.Controls.Add(this.tbScheduler);
            this.tbsMain.Controls.Add(this.tbSearch);
            this.tbsMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbsMain.Location = new System.Drawing.Point(0, 24);
            this.tbsMain.Name = "tbsMain";
            this.tbsMain.SelectedIndex = 0;
            this.tbsMain.Size = new System.Drawing.Size(1006, 510);
            this.tbsMain.TabIndex = 3;
            // 
            // tbSaltRoom
            // 
            this.tbSaltRoom.Controls.Add(this.gcCurrentState);
            this.tbSaltRoom.Controls.Add(this.gbPlaces);
            this.tbSaltRoom.Location = new System.Drawing.Point(4, 22);
            this.tbSaltRoom.Name = "tbSaltRoom";
            this.tbSaltRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tbSaltRoom.Size = new System.Drawing.Size(998, 484);
            this.tbSaltRoom.TabIndex = 1;
            this.tbSaltRoom.Text = "Соляна Кімната";
            this.tbSaltRoom.UseVisualStyleBackColor = true;
            // 
            // gcCurrentState
            // 
            this.gcCurrentState.Location = new System.Drawing.Point(271, 6);
            this.gcCurrentState.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.gcCurrentState.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gcCurrentState.MainView = this.gvCurrentState;
            this.gcCurrentState.Name = "gcCurrentState";
            this.gcCurrentState.Size = new System.Drawing.Size(731, 426);
            this.gcCurrentState.TabIndex = 21;
            this.gcCurrentState.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCurrentState});
            // 
            // gvCurrentState
            // 
            this.gvCurrentState.GridControl = this.gcCurrentState;
            this.gvCurrentState.Name = "gvCurrentState";
            this.gvCurrentState.OptionsBehavior.AutoSelectAllInEditor = false;
            this.gvCurrentState.OptionsBehavior.Editable = false;
            this.gvCurrentState.OptionsCustomization.AllowGroup = false;
            this.gvCurrentState.OptionsView.ShowGroupPanel = false;
            // 
            // gbPlaces
            // 
            this.gbPlaces.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbPlaces.Location = new System.Drawing.Point(3, 3);
            this.gbPlaces.Name = "gbPlaces";
            this.gbPlaces.Size = new System.Drawing.Size(261, 478);
            this.gbPlaces.TabIndex = 20;
            this.gbPlaces.TabStop = false;
            this.gbPlaces.Text = "groupBox1";
            // 
            // tbScheduler
            // 
            this.tbScheduler.Controls.Add(this.dnCalendar);
            this.tbScheduler.Controls.Add(this.schDailyScheduler);
            this.tbScheduler.Location = new System.Drawing.Point(4, 22);
            this.tbScheduler.Name = "tbScheduler";
            this.tbScheduler.Padding = new System.Windows.Forms.Padding(3);
            this.tbScheduler.Size = new System.Drawing.Size(998, 484);
            this.tbScheduler.TabIndex = 0;
            this.tbScheduler.Text = "Планувальник";
            this.tbScheduler.UseVisualStyleBackColor = true;
            // 
            // dnCalendar
            // 
            this.dnCalendar.CalendarAppearance.DayCellSpecial.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.dnCalendar.CalendarAppearance.DayCellSpecial.Options.UseFont = true;
            this.dnCalendar.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dnCalendar.DateTime = new System.DateTime(2018, 11, 4, 0, 0, 0, 0);
            this.dnCalendar.EditValue = new System.DateTime(2018, 11, 4, 0, 0, 0, 0);
            this.dnCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dnCalendar.Location = new System.Drawing.Point(3, 6);
            this.dnCalendar.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.dnCalendar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.dnCalendar.Name = "dnCalendar";
            this.dnCalendar.SchedulerControl = this.schDailyScheduler;
            this.dnCalendar.Size = new System.Drawing.Size(250, 250);
            this.dnCalendar.TabIndex = 2;
            // 
            // schDailyScheduler
            // 
            this.schDailyScheduler.DataStorage = this.schedulerStorage1;
            this.schDailyScheduler.Location = new System.Drawing.Point(259, 6);
            this.schDailyScheduler.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.schDailyScheduler.LookAndFeel.UseDefaultLookAndFeel = false;
            this.schDailyScheduler.Name = "schDailyScheduler";
            this.schDailyScheduler.Size = new System.Drawing.Size(731, 426);
            this.schDailyScheduler.Start = new System.DateTime(2018, 9, 4, 0, 0, 0, 0);
            this.schDailyScheduler.TabIndex = 1;
            this.schDailyScheduler.Views.DayView.ShowWorkTimeOnly = true;
            this.schDailyScheduler.Views.DayView.TimeRulers.Add(timeRuler4);
            this.schDailyScheduler.Views.DayView.TimeScale = System.TimeSpan.Parse("00:15:00");
            this.schDailyScheduler.Views.DayView.TimeSlots.Add(new DevExpress.XtraScheduler.TimeSlot(System.TimeSpan.Parse("00:15:00"), "15 minutes"));
            this.schDailyScheduler.Views.DayView.WorkTime = new DevExpress.XtraScheduler.TimeOfDayInterval(System.TimeSpan.Parse("10:00:00"), System.TimeSpan.Parse("19:00:00"));
            this.schDailyScheduler.Views.FullWeekView.Enabled = true;
            this.schDailyScheduler.Views.FullWeekView.TimeRulers.Add(timeRuler5);
            this.schDailyScheduler.Views.WeekView.Enabled = false;
            this.schDailyScheduler.Views.WorkWeekView.TimeRulers.Add(timeRuler6);
            // 
            // tbSearch
            // 
            this.tbSearch.Controls.Add(this.gbCustomerGrid);
            this.tbSearch.Controls.Add(this.gbParameters);
            this.tbSearch.Location = new System.Drawing.Point(4, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(998, 484);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.Text = "Пошук";
            this.tbSearch.UseVisualStyleBackColor = true;
            // 
            // gbCustomerGrid
            // 
            this.gbCustomerGrid.Controls.Add(this.lblSessions);
            this.gbCustomerGrid.Controls.Add(this.gcSessions);
            this.gbCustomerGrid.Controls.Add(this.gcCustomers);
            this.gbCustomerGrid.Location = new System.Drawing.Point(261, 3);
            this.gbCustomerGrid.Name = "gbCustomerGrid";
            this.gbCustomerGrid.Size = new System.Drawing.Size(729, 346);
            this.gbCustomerGrid.TabIndex = 1;
            this.gbCustomerGrid.TabStop = false;
            this.gbCustomerGrid.Text = "Знайдені клієнти";
            this.gbCustomerGrid.Visible = false;
            // 
            // lblSessions
            // 
            this.lblSessions.AutoSize = true;
            this.lblSessions.Location = new System.Drawing.Point(6, 166);
            this.lblSessions.Name = "lblSessions";
            this.lblSessions.Size = new System.Drawing.Size(47, 13);
            this.lblSessions.TabIndex = 2;
            this.lblSessions.Text = "Сеанси:";
            // 
            // gcSessions
            // 
            this.gcSessions.Location = new System.Drawing.Point(3, 186);
            this.gcSessions.MainView = this.gvSessions;
            this.gcSessions.Name = "gcSessions";
            this.gcSessions.Size = new System.Drawing.Size(695, 171);
            this.gcSessions.TabIndex = 1;
            this.gcSessions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSessions});
            // 
            // gvSessions
            // 
            this.gvSessions.GridControl = this.gcSessions;
            this.gvSessions.Name = "gvSessions";
            this.gvSessions.OptionsBehavior.Editable = false;
            this.gvSessions.OptionsCustomization.AllowFilter = false;
            this.gvSessions.OptionsCustomization.AllowGroup = false;
            this.gvSessions.OptionsView.ShowGroupPanel = false;
            // 
            // gcCustomers
            // 
            this.gcCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCustomers.Location = new System.Drawing.Point(3, 16);
            this.gcCustomers.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.gcCustomers.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gcCustomers.MainView = this.gvCustomers;
            this.gcCustomers.Name = "gcCustomers";
            this.gcCustomers.Size = new System.Drawing.Size(723, 147);
            this.gcCustomers.TabIndex = 0;
            this.gcCustomers.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.False;
            this.gcCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCustomers});
            // 
            // gvCustomers
            // 
            this.gvCustomers.GridControl = this.gcCustomers;
            this.gvCustomers.Name = "gvCustomers";
            this.gvCustomers.OptionsBehavior.Editable = false;
            this.gvCustomers.OptionsCustomization.AllowFilter = false;
            this.gvCustomers.OptionsCustomization.AllowGroup = false;
            this.gvCustomers.OptionsView.ShowGroupPanel = false;
            this.gvCustomers.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvCustomers_RowClick);
            // 
            // gbParameters
            // 
            this.gbParameters.Controls.Add(this.btnEdit);
            this.gbParameters.Controls.Add(this.btnLock);
            this.gbParameters.Controls.Add(this.txtPhone);
            this.gbParameters.Controls.Add(this.lblPhone);
            this.gbParameters.Controls.Add(this.btnSearch);
            this.gbParameters.Controls.Add(this.txtSubscription);
            this.gbParameters.Controls.Add(this.txtLastName);
            this.gbParameters.Controls.Add(this.lblSubscription);
            this.gbParameters.Controls.Add(this.lblLastName);
            this.gbParameters.Location = new System.Drawing.Point(3, 3);
            this.gbParameters.Name = "gbParameters";
            this.gbParameters.Size = new System.Drawing.Size(252, 250);
            this.gbParameters.TabIndex = 0;
            this.gbParameters.TabStop = false;
            this.gbParameters.Text = "Параметри пошуку";
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Location = new System.Drawing.Point(167, 112);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Змінити";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnLock
            // 
            this.btnLock.Enabled = false;
            this.btnLock.Location = new System.Drawing.Point(86, 112);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 23);
            this.btnLock.TabIndex = 7;
            this.btnLock.Text = "Загублено";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(123, 77);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(121, 20);
            this.txtPhone.TabIndex = 6;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 80);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(96, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Номер телефона:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(5, 112);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Знайти";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSubscription
            // 
            this.txtSubscription.Location = new System.Drawing.Point(123, 50);
            this.txtSubscription.Name = "txtSubscription";
            this.txtSubscription.Size = new System.Drawing.Size(121, 20);
            this.txtSubscription.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(123, 24);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(121, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // lblSubscription
            // 
            this.lblSubscription.AutoSize = true;
            this.lblSubscription.Location = new System.Drawing.Point(6, 53);
            this.lblSubscription.Name = "lblSubscription";
            this.lblSubscription.Size = new System.Drawing.Size(108, 13);
            this.lblSubscription.TabIndex = 1;
            this.lblSubscription.Text = "Номер абонемента:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 27);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(59, 13);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "Прізвище:";
            // 
            // pnlNotification
            // 
            this.pnlNotification.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNotification.Location = new System.Drawing.Point(0, 484);
            this.pnlNotification.Name = "pnlNotification";
            this.pnlNotification.Size = new System.Drawing.Size(1006, 50);
            this.pnlNotification.TabIndex = 4;
            this.pnlNotification.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 534);
            this.Controls.Add(this.pnlNotification);
            this.Controls.Add(this.tbsMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Salt SPA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adornerUIManager1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbsMain.ResumeLayout(false);
            this.tbSaltRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCurrentState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCurrentState)).EndInit();
            this.tbScheduler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dnCalendar.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnCalendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schDailyScheduler)).EndInit();
            this.tbSearch.ResumeLayout(false);
            this.gbCustomerGrid.ResumeLayout(false);
            this.gbCustomerGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSessions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSessions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).EndInit();
            this.gbParameters.ResumeLayout(false);
            this.gbParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.Utils.VisualEffects.AdornerUIManager adornerUIManager1;
        private System.Windows.Forms.TabControl tbsMain;
        private System.Windows.Forms.TabPage tbScheduler;
        private DateNavigator dnCalendar;
        private SchedulerControl schDailyScheduler;
        private System.Windows.Forms.TabPage tbSaltRoom;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCustomerToolStripMenuItem;
        private System.Windows.Forms.TabPage tbSearch;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSaltSPAToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSubscription;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblSubscription;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Panel pnlNotification;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox gbCustomerGrid;
        private System.Windows.Forms.BindingSource customerSource;
        private DevExpress.XtraGrid.GridControl gcCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCustomers;
        private DevExpress.XtraGrid.GridControl gcSessions;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSessions;
        private System.Windows.Forms.BindingSource sessionSource;
        private System.Windows.Forms.Label lblSessions;
        private DevExpress.XtraGrid.GridControl gcCurrentState;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCurrentState;
        private System.Windows.Forms.GroupBox gbPlaces;
    }
}


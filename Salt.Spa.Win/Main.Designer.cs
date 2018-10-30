﻿using System;
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
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.adornerUIManager1 = new DevExpress.Utils.VisualEffects.AdornerUIManager(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клієнтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.додатиКлієнтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSaltSPAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbsMain = new System.Windows.Forms.TabControl();
            this.tbSaltRoom = new System.Windows.Forms.TabPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSit6 = new System.Windows.Forms.Button();
            this.btnSit7 = new System.Windows.Forms.Button();
            this.btnSit8 = new System.Windows.Forms.Button();
            this.btnSit9 = new System.Windows.Forms.Button();
            this.btnSit10 = new System.Windows.Forms.Button();
            this.btnSit5 = new System.Windows.Forms.Button();
            this.btnSit4 = new System.Windows.Forms.Button();
            this.btnSit3 = new System.Windows.Forms.Button();
            this.btnSit2 = new System.Windows.Forms.Button();
            this.btnSit1 = new System.Windows.Forms.Button();
            this.tbScheduler = new System.Windows.Forms.TabPage();
            this.dnCalendar = new DevExpress.XtraScheduler.DateNavigator();
            this.schDailyScheduler = new DevExpress.XtraScheduler.SchedulerControl();
            this.tbSearch = new System.Windows.Forms.TabPage();
            this.gbCustomerGrid = new System.Windows.Forms.GroupBox();
            this.gcSessions = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCustomers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adornerUIManager1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tbsMain.SuspendLayout();
            this.tbSaltRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.tbScheduler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dnCalendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnCalendar.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schDailyScheduler)).BeginInit();
            this.tbSearch.SuspendLayout();
            this.gbCustomerGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSessions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.gbParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adornerUIManager1
            // 
            this.adornerUIManager1.Owner = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клієнтиToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // клієнтиToolStripMenuItem
            // 
            this.клієнтиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.додатиКлієнтаToolStripMenuItem});
            this.клієнтиToolStripMenuItem.Name = "клієнтиToolStripMenuItem";
            this.клієнтиToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.клієнтиToolStripMenuItem.Text = "Клієнти";
            // 
            // додатиКлієнтаToolStripMenuItem
            // 
            this.додатиКлієнтаToolStripMenuItem.Name = "додатиКлієнтаToolStripMenuItem";
            this.додатиКлієнтаToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.додатиКлієнтаToolStripMenuItem.Text = "Додати К&лієнта";
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
            this.tbsMain.Size = new System.Drawing.Size(1006, 438);
            this.tbsMain.TabIndex = 3;
            // 
            // tbSaltRoom
            // 
            this.tbSaltRoom.Controls.Add(this.groupControl1);
            this.tbSaltRoom.Location = new System.Drawing.Point(4, 22);
            this.tbSaltRoom.Name = "tbSaltRoom";
            this.tbSaltRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tbSaltRoom.Size = new System.Drawing.Size(998, 412);
            this.tbSaltRoom.TabIndex = 1;
            this.tbSaltRoom.Text = "Соляна Кімната";
            this.tbSaltRoom.UseVisualStyleBackColor = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnSit6);
            this.groupControl1.Controls.Add(this.btnSit7);
            this.groupControl1.Controls.Add(this.btnSit8);
            this.groupControl1.Controls.Add(this.btnSit9);
            this.groupControl1.Controls.Add(this.btnSit10);
            this.groupControl1.Controls.Add(this.btnSit5);
            this.groupControl1.Controls.Add(this.btnSit4);
            this.groupControl1.Controls.Add(this.btnSit3);
            this.groupControl1.Controls.Add(this.btnSit2);
            this.groupControl1.Controls.Add(this.btnSit1);
            this.groupControl1.Location = new System.Drawing.Point(8, 17);
            this.groupControl1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.groupControl1.LookAndFeel.TouchUIMode = DevExpress.Utils.DefaultBoolean.False;
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(559, 343);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnSit6
            // 
            this.btnSit6.BackColor = System.Drawing.Color.Red;
            this.btnSit6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSit6.Location = new System.Drawing.Point(5, 199);
            this.btnSit6.Name = "btnSit6";
            this.btnSit6.Size = new System.Drawing.Size(100, 100);
            this.btnSit6.TabIndex = 9;
            this.btnSit6.Text = "Місце 6";
            this.btnSit6.UseVisualStyleBackColor = false;
            // 
            // btnSit7
            // 
            this.btnSit7.BackColor = System.Drawing.Color.White;
            this.btnSit7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSit7.Location = new System.Drawing.Point(111, 199);
            this.btnSit7.Name = "btnSit7";
            this.btnSit7.Size = new System.Drawing.Size(100, 100);
            this.btnSit7.TabIndex = 8;
            this.btnSit7.Text = "Місце 7";
            this.btnSit7.UseVisualStyleBackColor = false;
            // 
            // btnSit8
            // 
            this.btnSit8.BackColor = System.Drawing.Color.White;
            this.btnSit8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSit8.Location = new System.Drawing.Point(217, 199);
            this.btnSit8.Name = "btnSit8";
            this.btnSit8.Size = new System.Drawing.Size(100, 100);
            this.btnSit8.TabIndex = 7;
            this.btnSit8.Text = "Місце 8";
            this.btnSit8.UseVisualStyleBackColor = false;
            // 
            // btnSit9
            // 
            this.btnSit9.BackColor = System.Drawing.Color.White;
            this.btnSit9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSit9.Location = new System.Drawing.Point(323, 199);
            this.btnSit9.Name = "btnSit9";
            this.btnSit9.Size = new System.Drawing.Size(100, 100);
            this.btnSit9.TabIndex = 6;
            this.btnSit9.Text = "Місце 9";
            this.btnSit9.UseVisualStyleBackColor = false;
            // 
            // btnSit10
            // 
            this.btnSit10.BackColor = System.Drawing.Color.White;
            this.btnSit10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSit10.Location = new System.Drawing.Point(429, 199);
            this.btnSit10.Name = "btnSit10";
            this.btnSit10.Size = new System.Drawing.Size(100, 100);
            this.btnSit10.TabIndex = 5;
            this.btnSit10.Text = "Місце 10";
            this.btnSit10.UseVisualStyleBackColor = false;
            // 
            // btnSit5
            // 
            this.btnSit5.BackColor = System.Drawing.Color.Orange;
            this.btnSit5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSit5.Location = new System.Drawing.Point(429, 52);
            this.btnSit5.Name = "btnSit5";
            this.btnSit5.Size = new System.Drawing.Size(100, 100);
            this.btnSit5.TabIndex = 4;
            this.btnSit5.Text = "Місце 5";
            this.btnSit5.UseVisualStyleBackColor = false;
            // 
            // btnSit4
            // 
            this.btnSit4.BackColor = System.Drawing.Color.Orange;
            this.btnSit4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSit4.Location = new System.Drawing.Point(323, 52);
            this.btnSit4.Name = "btnSit4";
            this.btnSit4.Size = new System.Drawing.Size(100, 100);
            this.btnSit4.TabIndex = 3;
            this.btnSit4.Text = "Місце 4";
            this.btnSit4.UseVisualStyleBackColor = false;
            // 
            // btnSit3
            // 
            this.btnSit3.BackColor = System.Drawing.Color.LightGreen;
            this.btnSit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSit3.Location = new System.Drawing.Point(217, 52);
            this.btnSit3.Name = "btnSit3";
            this.btnSit3.Size = new System.Drawing.Size(100, 100);
            this.btnSit3.TabIndex = 2;
            this.btnSit3.Text = "Місце 3";
            this.btnSit3.UseVisualStyleBackColor = false;
            // 
            // btnSit2
            // 
            this.btnSit2.BackColor = System.Drawing.Color.LightGreen;
            this.btnSit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSit2.Location = new System.Drawing.Point(111, 52);
            this.btnSit2.Name = "btnSit2";
            this.btnSit2.Size = new System.Drawing.Size(100, 100);
            this.btnSit2.TabIndex = 1;
            this.btnSit2.Text = "Місце 2";
            this.btnSit2.UseVisualStyleBackColor = false;
            // 
            // btnSit1
            // 
            this.btnSit1.BackColor = System.Drawing.Color.LightGreen;
            this.btnSit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSit1.Location = new System.Drawing.Point(5, 52);
            this.btnSit1.Name = "btnSit1";
            this.btnSit1.Size = new System.Drawing.Size(100, 100);
            this.btnSit1.TabIndex = 0;
            this.btnSit1.Text = "Місце 1";
            this.btnSit1.UseVisualStyleBackColor = false;
            // 
            // tbScheduler
            // 
            this.tbScheduler.Controls.Add(this.dnCalendar);
            this.tbScheduler.Controls.Add(this.schDailyScheduler);
            this.tbScheduler.Location = new System.Drawing.Point(4, 22);
            this.tbScheduler.Name = "tbScheduler";
            this.tbScheduler.Padding = new System.Windows.Forms.Padding(3);
            this.tbScheduler.Size = new System.Drawing.Size(998, 412);
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
            this.schDailyScheduler.Size = new System.Drawing.Size(700, 440);
            this.schDailyScheduler.Start = new System.DateTime(2018, 9, 4, 0, 0, 0, 0);
            this.schDailyScheduler.TabIndex = 1;
            this.schDailyScheduler.Views.DayView.ShowWorkTimeOnly = true;
            this.schDailyScheduler.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schDailyScheduler.Views.DayView.TimeScale = System.TimeSpan.Parse("00:15:00");
            this.schDailyScheduler.Views.DayView.TimeSlots.Add(new DevExpress.XtraScheduler.TimeSlot(System.TimeSpan.Parse("00:15:00"), "15 minutes"));
            this.schDailyScheduler.Views.DayView.WorkTime = new DevExpress.XtraScheduler.TimeOfDayInterval(System.TimeSpan.Parse("10:00:00"), System.TimeSpan.Parse("19:00:00"));
            this.schDailyScheduler.Views.FullWeekView.Enabled = true;
            this.schDailyScheduler.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schDailyScheduler.Views.WeekView.Enabled = false;
            this.schDailyScheduler.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            // 
            // tbSearch
            // 
            this.tbSearch.Controls.Add(this.gbCustomerGrid);
            this.tbSearch.Controls.Add(this.gbParameters);
            this.tbSearch.Location = new System.Drawing.Point(4, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(998, 412);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.Text = "Пошук";
            this.tbSearch.UseVisualStyleBackColor = true;
            // 
            // gbCustomerGrid
            // 
            this.gbCustomerGrid.Controls.Add(this.gcSessions);
            this.gbCustomerGrid.Controls.Add(this.gcCustomers);
            this.gbCustomerGrid.Location = new System.Drawing.Point(289, 3);
            this.gbCustomerGrid.Name = "gbCustomerGrid";
            this.gbCustomerGrid.Size = new System.Drawing.Size(701, 346);
            this.gbCustomerGrid.TabIndex = 1;
            this.gbCustomerGrid.TabStop = false;
            this.gbCustomerGrid.Text = "Знайдені клієнти";
            // 
            // gcSessions
            // 
            this.gcSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSessions.Location = new System.Drawing.Point(3, 120);
            this.gcSessions.MainView = this.gridView2;
            this.gcSessions.Name = "gcSessions";
            this.gcSessions.Size = new System.Drawing.Size(695, 223);
            this.gcSessions.TabIndex = 1;
            this.gcSessions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcSessions;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsCustomization.AllowFilter = false;
            this.gridView2.OptionsCustomization.AllowGroup = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gcCustomers
            // 
            this.gcCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcCustomers.Location = new System.Drawing.Point(3, 16);
            this.gcCustomers.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.gcCustomers.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gcCustomers.MainView = this.gridView1;
            this.gcCustomers.Name = "gcCustomers";
            this.gcCustomers.Size = new System.Drawing.Size(695, 104);
            this.gcCustomers.TabIndex = 0;
            this.gcCustomers.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.False;
            this.gcCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcCustomers;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
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
            this.gbParameters.Size = new System.Drawing.Size(250, 250);
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
            // 
            // btnLock
            // 
            this.btnLock.Enabled = false;
            this.btnLock.Location = new System.Drawing.Point(86, 112);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 23);
            this.btnLock.TabIndex = 7;
            this.btnLock.Text = "Блокувати";
            this.btnLock.UseVisualStyleBackColor = true;
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
            this.pnlNotification.Location = new System.Drawing.Point(0, 412);
            this.pnlNotification.Name = "pnlNotification";
            this.pnlNotification.Size = new System.Drawing.Size(1006, 50);
            this.pnlNotification.TabIndex = 4;
            this.pnlNotification.Visible = false;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(Salt.Spa.Win.FrmMain);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 462);
            this.Controls.Add(this.pnlNotification);
            this.Controls.Add(this.tbsMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Salt SPA";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adornerUIManager1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbsMain.ResumeLayout(false);
            this.tbSaltRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.tbScheduler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dnCalendar.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dnCalendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schDailyScheduler)).EndInit();
            this.tbSearch.ResumeLayout(false);
            this.gbCustomerGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSessions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.gbParameters.ResumeLayout(false);
            this.gbParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клієнтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem додатиКлієнтаToolStripMenuItem;
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
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnSit6;
        private System.Windows.Forms.Button btnSit7;
        private System.Windows.Forms.Button btnSit8;
        private System.Windows.Forms.Button btnSit9;
        private System.Windows.Forms.Button btnSit10;
        private System.Windows.Forms.Button btnSit5;
        private System.Windows.Forms.Button btnSit4;
        private System.Windows.Forms.Button btnSit3;
        private System.Windows.Forms.Button btnSit2;
        private System.Windows.Forms.Button btnSit1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.GroupBox gbCustomerGrid;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DevExpress.XtraGrid.GridControl gcCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gcSessions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}

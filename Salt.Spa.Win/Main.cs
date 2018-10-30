using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using Salt.Spa.Dal.Entity;

namespace Salt.Spa.Win
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            schDailyScheduler.EditAppointmentFormShowing += schDailyScheduler_EditAppointmentFormShowing;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            InitPosition(tbsMain, schDailyScheduler, dnCalendar);
            InitPosition(tbsMain, gbCustomerGrid, gbParameters);
            InitTop(gcCustomers, gcSessions);
        }
        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            InitPosition(tbsMain, schDailyScheduler, dnCalendar);
            InitPosition(tbsMain, gbCustomerGrid, gbParameters);
            InitTop(gcCustomers, gcSessions);
        }

        private void schDailyScheduler_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            var scheduler = ((SchedulerControl)(sender));
            CustomAppointmentForm form = new CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }

        }
        private void InitPosition(Control parent, Control target, Control additional)
        {
            target.Height = parent.Height - 90;
            target.Left = additional.Right + 10;
            target.Width = parent.Width - additional.Width - 30;
        }
        private void InitTop(Control top, Control bottom)
        {
            bottom.Top = top.Bottom + 20;
        }
        private void schDailyScheduler_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            //e.Menu = new SchedulerPopupMenu();
        }
    }
}

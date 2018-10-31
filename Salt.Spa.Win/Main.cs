using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using Salt.Spa.Dal.Entity;
using Salt.Spa.DataManager.dto;
using Salt.Spa.DataManager.Interfaces;
using Salt.Spa.Unity;

namespace Salt.Spa.Win
{
    public partial class FrmMain : Form
    {
        private int _customerId;
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
            {
                e.DialogResult = form.ShowDialog();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var manager = Resolver.Get<IFactory<CustomerSubscription>>();
            var cs = new CustomerSubscription
            {
                LastName = txtLastName.Text,
                Phone = txtPhone.Text,
                SubscriptionNumber = txtSubscription.Text
            };
            var customers = manager.GetOrCreateCustomer(cs).ToList();
            if (customers.Count() > 0)
            {
                gbCustomerGrid.Visible = true;
                btnLock.Enabled = true;
                btnEdit.Enabled = true;
                clientBindingSource.DataSource = customers;
                gcCustomers.DataSource = clientBindingSource;
                _customerId = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CustomerId").ToString());
            }
            else
            {
                gbCustomerGrid.Visible = false;
                btnLock.Enabled = false;
                btnEdit.Enabled = false;
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            _customerId = Convert.ToInt32(gridView1.GetRowCellValue(e.RowHandle, "CustomerId").ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using Salt.Spa.DataManager.dto;
using Salt.Spa.DataManager.Interfaces;
using Salt.Spa.Infrastructure.Entity;
using Salt.Spa.Unity;

namespace Salt.Spa.Win
{
    public partial class FrmMain : Form
    {
        private IManager<CustomerSession> _sessionManager;
        private IManager<CustomerSubscription> _customerManager;
        private IManager<SubscriptionSubscription> _subscriptionManager;
        public FrmMain()
        {
            InitializeComponent();
            schDailyScheduler.EditAppointmentFormShowing += schDailyScheduler_EditAppointmentFormShowing;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            InitPosition(tbsMain, schDailyScheduler, dnCalendar);
            InitPosition(tbsMain, gbCustomerGrid, gbParameters);
            InitTop(gbCustomerGrid, gcCustomers, gcSessions);

            _customerManager = Resolver.Get<IManager<CustomerSubscription>>();
            _sessionManager = Resolver.Get<IManager<CustomerSession>>();
            _subscriptionManager = Resolver.Get<IManager<SubscriptionSubscription>>();
        }
        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            InitPosition(tbsMain, schDailyScheduler, dnCalendar);
            InitPosition(tbsMain, gbCustomerGrid, gbParameters);
            InitTop(gbCustomerGrid, gcCustomers, gcSessions);
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
        private void schDailyScheduler_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            //e.Menu = new SchedulerPopupMenu();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var customers = _customerManager.Search(GetParameters()).ToList();
            if (customers.Count() > 0)
            {
                SetDataSource(customers, customerSource, gcCustomers);
                InitSessionsGridControl(GetValueFromGridViewByCoumnName<int>(gvCustomers, gvCustomers.FocusedRowHandle, "CustomerId"));
                SetBtnLockText(GetValueFromGridViewByCoumnName<SubscriptionStatus>(gvCustomers, gvCustomers.FocusedRowHandle, "Status") == SubscriptionStatus.Active);
            }
            ShowHideGrids(customers.Count() > 0);
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            var subscriptionNumber = GetValueFromGridViewByCoumnName<string>(gvCustomers, gvCustomers.FocusedRowHandle, "SubscriptionNumber");
            var status = GetValueFromGridViewByCoumnName<SubscriptionStatus>(gvCustomers, gvCustomers.FocusedRowHandle, "Status");
            var subSubscription = _subscriptionManager.Search(new SubscriptionSubscription {Number = subscriptionNumber}).FirstOrDefault();
            if (subSubscription != null)
            {
                subSubscription.Status = status;
                _subscriptionManager.CreateOrUpdate(subSubscription);
            }
            gvCustomers.SetRowCellValue(gvCustomers.FocusedRowHandle, "Status", status == SubscriptionStatus.Lost ? SubscriptionStatus.Active : SubscriptionStatus.Lost);
            SetBtnLockText(status != SubscriptionStatus.Lost);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var customerId = GetValueFromGridViewByCoumnName<int>(gvCustomers, gvCustomers.FocusedRowHandle, "CustomerId");
            var cs = _customerManager.Search(new CustomerSubscription { CustomerId = customerId }).Single();
            ShowAddForm(cs);
        }
        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAddForm(new CustomerSubscription());
        }

        private void gvCustomers_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            InitSessionsGridControl(GetValueFromGridViewByCoumnName<int>(gvCustomers, e.RowHandle, "CustomerId"));
            SetBtnLockText(GetValueFromGridViewByCoumnName<SubscriptionStatus>(gvCustomers, e.RowHandle, "Status") != SubscriptionStatus.Lost);
        }
        private void ShowHideGrids(bool enable)
        {
            gbCustomerGrid.Visible = enable;
            btnLock.Enabled = enable;
            btnEdit.Enabled = enable;
        }

        private CustomerSubscription GetParameters()
        {
            return new CustomerSubscription
            {
                LastName = txtLastName.Text,
                Phone = txtPhone.Text,
                SubscriptionNumber = txtSubscription.Text
            };
        }

        private void SetDataSource<T>(T dataSource, BindingSource bs, DevExpress.XtraGrid.GridControl gc) where T : IEnumerable<IViewModel>
        {
            bs.DataSource = dataSource;
            gc.DataSource = bs;
        }

        private T GetValueFromGridViewByCoumnName<T>(DevExpress.XtraGrid.Views.Grid.GridView gv, int rowHandle, string columnName)
        {var value = gv.GetRowCellValue(rowHandle, columnName).ToString();
            if (typeof(T).IsEnum)
            {
                return (T)Enum.Parse(typeof(T), value);
            }
            return (T)Convert.ChangeType(value, typeof(T));
        }

        private void InitSessionsGridControl(int customerId)
        {
            var sessions = _sessionManager.Search(new CustomerSession { CustomerId = customerId });
            SetDataSource(sessions, sessionSource, gcSessions);
        }

        private void SetBtnLockText(bool isActive)
        {
            btnLock.Text = isActive ? "Загублено" : "Знайдено";
        }

        private void InitPosition(Control parent, Control target, Control additional)
        {
            target.Height = parent.Height - 90;
            target.Left = additional.Right + 10;
            target.Width = parent.Width - additional.Width - 30;
        }
        private void InitTop(Control parent, Control top, Control bottom)
        {
            bottom.Top = top.Bottom + 20;
            bottom.Width = parent.Width - 6;
            bottom.Height = parent.Height - (top.Bottom + 20) - 5;
        }

        private void ShowAddForm(CustomerSubscription cs)
        {
            using (AddCustomerSubscriptionForm addForm = new AddCustomerSubscriptionForm(cs))
            {
                addForm.ShowDialog();
            }
        }}
}

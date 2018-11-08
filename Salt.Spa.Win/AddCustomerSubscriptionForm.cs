using System.Windows.Forms;
using Salt.Spa.DataManager.dto;
using Salt.Spa.Infrastructure.Entity;

namespace Salt.Spa.Win
{
    public partial class AddCustomerSubscriptionForm : Form
    {
        private CustomerSubscription _cs;
        public AddCustomerSubscriptionForm(CustomerSubscription cs)
        {
            _cs = cs;
            InitializeComponent();
        }

        private void AddCustomerSubscriptionForm_Load(object sender, System.EventArgs e)
        {
            InitForm(_cs);
            btnSave.Text = _cs.Status != SubscriptionStatus.None ? "Змінити" : "Додати";}

        private void InitForm(CustomerSubscription cs)
        {
            txtFirstName.Text = cs.FirstName;
            txtLastName.Text = cs.LastName;
            txtPhone.Text = cs.Phone;
            ddlSubscriptions.Text = cs.SubscriptionNumber;
            txtSessionsCount.Text = $"{cs.SessionsCount}";
        }
    }
}

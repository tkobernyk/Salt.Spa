using System.Windows.Forms;
using Salt.Spa.DataManager.dto;

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
    }
}

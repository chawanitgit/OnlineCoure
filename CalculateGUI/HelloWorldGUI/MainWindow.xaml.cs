using System.Windows;

namespace HelloWorldGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtIncome.Text = "";
            txtExpense.Text = "";
            txtWishlist.Text = "";
            txtTotalCollect.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtIncome.Text == "" ||txtExpense.Text == "" ||txtWishlist.Text == "")
            {
                MessageBox.Show("Please input all information.");
            }
            else
            {
                float income = float.Parse(txtIncome.Text);
                float expense = float.Parse(txtExpense.Text);
                float wishlist = float.Parse(txtWishlist.Text);
                float diffIncome = wishlist / (income - expense);

                txtTotalCollect.Text = diffIncome.ToString();
            }
        }
    }
}

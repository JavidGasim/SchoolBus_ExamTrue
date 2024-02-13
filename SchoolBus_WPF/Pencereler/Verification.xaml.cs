using SchoolBus_DataAccess.Contexts;
using SchoolBus_Model.Entities.Concrete;
using System.Windows;
using System.Windows.Controls;


namespace SchoolBus_WPF;

public partial class Verification : Window
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int num {  get; set; }
    public Verification()
    {
        InitializeComponent();
    }

    private void verificate_txtbox_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (verificate_txtbox.Text.Length == 0)
        {
            verificate_lbl.Visibility = Visibility.Visible;
        }

        else
        {
            verificate_lbl.Visibility = Visibility.Collapsed;
        }
    }

    private void back_btn_verif_Click(object sender, RoutedEventArgs e)
    {
        SignUp signUp = new SignUp();
        signUp.Show();    
        this.Close();
    }

    private void finish_btn_Click(object sender, RoutedEventArgs e)
    {
        if (verificate_txtbox.Text == num.ToString())
        {
            using (var dbContext = new SchoolBusDB())
            {
                var admin = new Admin()
                {
                    FirstName = FirstName, LastName = LastName, Email = Email, Password = Password
                };

                dbContext.Admins.Add(admin);
                dbContext.SaveChanges();
            }
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        else
        {
            MessageBox.Show("Code is not true");
        }
    }
}

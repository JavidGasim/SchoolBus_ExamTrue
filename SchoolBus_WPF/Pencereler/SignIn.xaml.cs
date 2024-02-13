using SchoolBus_DataAccess.Contexts;
using SchoolBus_DataAccess.Repositories.Concrete;
using System.Windows;
using System.Windows.Controls;

namespace SchoolBus_WPF;

public partial class MainWindow : Window
{
    private readonly AdminRepository adminRepository;
    public int count { get; set; }
    public MainWindow()
    {
        InitializeComponent();

        adminRepository = new AdminRepository();
    }

    private void email_txtbox_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (email_txtbox.Text.Length == 0)
        {
            email_lbl.Visibility = Visibility.Visible;
        }

        else
        {
            email_lbl.Visibility = Visibility.Collapsed;
        }
    }

    private void password_txtbox_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (password_txtbox.Text.Length == 0)
        {
            password_lbl.Visibility = Visibility.Visible;
        }

        else
        {
            password_lbl.Visibility = Visibility.Collapsed;
        }
    }

    private void sign_up_btn_Click(object sender, RoutedEventArgs e)
    {
        SignUp signUp = new SignUp();
        signUp.Show();
        this.Close();
    }

    private void enter_btn_Click(object sender, RoutedEventArgs e)
    {
        count = 0;
        var admins = adminRepository.GetAll().ToList();

        for (int i = 0; i < admins.Count(); i++)
        {
            if (admins[i].Email == email_txtbox.Text && admins[i].Password == password_txtbox.Text)
            {
                SchoolBus schoolBus = new SchoolBus();
                schoolBus.Show();
                this.Close();
                break;
            }

            else
            {
                count++;
            }
        }
        
        if (count == admins.Count())
        {
            MessageBox.Show("Your Email or Password is Wrong");
        }
    }
}
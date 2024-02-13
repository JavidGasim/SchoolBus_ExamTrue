using SchoolBus_DataAccess.Contexts;
using SchoolBus_Model.Entities.Concrete;
using System.Windows;
using System.Windows.Controls;

namespace SchoolBus_WPF.Pencereler;

public partial class DriverAddPage : Window
{
    public DriverAddPage()
    {
        InitializeComponent();
    }

    private void firstname_txtbox_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (firstname_txtbox.Text.Length == 0)
        {
            firstname_lbl.Visibility = Visibility.Visible;
        }

        else
        {
            firstname_lbl.Visibility = Visibility.Collapsed;
        }
    }

    private void lastname_txtbox_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (lastname_txtbox.Text.Length == 0)
        {
            lastname_lbl.Visibility = Visibility.Visible;
        }

        else
        {
            lastname_lbl.Visibility = Visibility.Collapsed;
        }
    }

    private void phone_txtbox_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (phone_txtbox.Text.Length == 0)
        {
            phone_lbl.Visibility = Visibility.Visible;
        }

        else
        {
            phone_lbl.Visibility = Visibility.Collapsed;
        }
    }

    private void home_txtbox_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (home_txtbox.Text.Length == 0)
        {
            home_lbl.Visibility = Visibility.Visible;
        }

        else
        {
            home_lbl.Visibility = Visibility.Collapsed;
        }
    }

    private void license_txtbox_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (license_txtbox.Text.Length == 0)
        {
            license_lbl.Visibility = Visibility.Visible;
        }

        else
        {
            license_lbl.Visibility = Visibility.Collapsed;
        }
    }

    private void add_btn_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (firstname_txtbox is not null && lastname_txtbox is not null && phone_txtbox is not null && home_txtbox is not null && license_txtbox is not null)
            {
                using (var dbContext = new SchoolBusDB())
                {
                    var newClass = new Driver()
                    {
                        FirstName = firstname_txtbox.Text,
                        LastName = lastname_txtbox.Text,
                        Phone = phone_txtbox.Text,
                        HomeAddress = home_txtbox.Text,
                        License = license_txtbox.Text,
                    };

                    dbContext.Drivers.Add(newClass);
                    dbContext.SaveChanges();

                    MessageBox.Show("Creating Succesful");
                    DriverPage driverPage = new DriverPage();
                    driverPage.Show();
                    this.Close();
                }
            }

            else
            {
                MessageBox.Show("Empty Box");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }
}

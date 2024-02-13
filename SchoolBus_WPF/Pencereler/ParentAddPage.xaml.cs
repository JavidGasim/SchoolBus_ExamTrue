using SchoolBus_DataAccess.Contexts;
using SchoolBus_Model.Entities.Concrete;
using System.Windows;
using System.Windows.Controls;

namespace SchoolBus_WPF.Pencereler;


public partial class ParentAddPage : Window
{
    public ParentAddPage()
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

    private void add_btn_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (firstname_txtbox is not null && lastname_txtbox is not null && phone_txtbox is not null)
            {
                using (var dbContext = new SchoolBusDB())
                {
                    var newParent = new Parent()
                    {
                        FirstName = firstname_txtbox.Text,
                        LastName = lastname_txtbox.Text,
                        Phone = phone_txtbox.Text,
                    };

                    dbContext.Parents.Add(newParent);
                    dbContext.SaveChanges();

                    MessageBox.Show("Creating Succesful");
                    ParentPage parentPage = new ParentPage();
                    parentPage.Show();
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

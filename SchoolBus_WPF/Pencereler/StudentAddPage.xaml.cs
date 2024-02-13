using SchoolBus_DataAccess.Contexts;
using SchoolBus_Model.Entities.Concrete;
using System.Windows;
using System.Windows.Controls;

namespace SchoolBus_WPF.Pencereler;

public partial class StudentAddPage : Window
{
    public StudentAddPage()
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

    private void pname_txtbox_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (pname_txtbox.Text.Length == 0)
        {
            pname_lbl.Visibility = Visibility.Visible;
        }

        else
        {
            pname_lbl.Visibility = Visibility.Collapsed;
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

    private void add_btn_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (firstname_txtbox is not null && lastname_txtbox is not null && pname_txtbox is not null && home_txtbox is not null)
            {
                using (var dbContext = new SchoolBusDB())
                {
                    var newStudent = new Student()
                    {
                        FirstName = firstname_txtbox.Text,
                        LastName = lastname_txtbox.Text,
                        ParentName = pname_txtbox.Text,
                        HomeAddress = home_txtbox.Text,
                    };

                    dbContext.Students.Add(newStudent);
                    dbContext.SaveChanges();

                    MessageBox.Show("Creating Succesful");
                    StudentPage studentPage = new StudentPage();
                    studentPage.Show();
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

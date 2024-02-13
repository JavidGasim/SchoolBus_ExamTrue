using SchoolBus_DataAccess.Contexts;
using SchoolBus_Model.Entities.Concrete;
using System.Windows;
using System.Windows.Controls;

namespace SchoolBus_WPF.Pencereler;


public partial class CarAddPage : Window
{
    public CarAddPage()
    {
        InitializeComponent();
    }

    private void carname_txtbox_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (carname_txtbox.Text.Length == 0)
        {
            carname_lbl.Visibility = Visibility.Visible;
        }

        else
        {
            carname_lbl.Visibility = Visibility.Collapsed;
        }
    }

    private void carnum_txtbox_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (carnum_txtbox.Text.Length == 0)
        {
            carnum_lbl.Visibility = Visibility.Visible;
        }

        else
        {
            carnum_lbl.Visibility = Visibility.Collapsed;
        }
    }

    private void maxseat_txtbox_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (maxseat_txtbox.Text.Length == 0)
        {
            maxseat_lbl.Visibility = Visibility.Visible;
        }

        else
        {
            maxseat_lbl.Visibility = Visibility.Collapsed;
        }
    }

    private void add_btn_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (carname_txtbox is not null && carnum_txtbox is not null && maxseat_txtbox is not null)
            {
                using (var dbContext = new SchoolBusDB())
                {
                    var newClass = new Car()
                    {
                        CarName = carname_txtbox.Text,
                        CarNumber = carnum_txtbox.Text,
                        SeatCount = Convert.ToInt32(maxseat_txtbox.Text),
                    };

                    dbContext.Cars.Add(newClass);
                    dbContext.SaveChanges();

                    MessageBox.Show("Creating Succesful");
                    CarPage carPage = new CarPage();
                    carPage.Show();
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

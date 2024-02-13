using SchoolBus_DataAccess.Contexts;
using SchoolBus_Model.Entities.Concrete;
using System.Windows;
using System.Windows.Controls;

namespace SchoolBus_WPF;

public partial class Create_RidePage : Window
{
    public Create_RidePage()
    {
        InitializeComponent();
    }

    private void logout_btn_Click(object sender, RoutedEventArgs e)
    {
        MainWindow signIn = new MainWindow();
        signIn.Show();
        this.Close();
    }

    private void create_ride_btn_Click(object sender, RoutedEventArgs e)
    {
        Create_RidePage create_RidePage = new Create_RidePage();
        this.Close();
        create_RidePage.Show();
    }

    private void rides_btn_Click(object sender, RoutedEventArgs e)
    {
        RidesPage ridesPage = new RidesPage();
        this.Close();
        ridesPage.Show();
    }

    private void class_btn_Click(object sender, RoutedEventArgs e)
    {
        ClassPage classPage = new ClassPage();
        this.Close();
        classPage.Show();
    }

    private void student_btn_Click(object sender, RoutedEventArgs e)
    {
        StudentPage studentPage = new StudentPage();
        this.Close();
        studentPage.Show();
    }

    private void parent_btn_Click(object sender, RoutedEventArgs e)
    {
        ParentPage parentPage = new ParentPage();
        this.Close();
        parentPage.Show();
    }

    private void driver_btn_Click(object sender, RoutedEventArgs e)
    {
        DriverPage driverPage = new DriverPage();
        this.Close();
        driverPage.Show();
    }

    private void car_btn_Click(object sender, RoutedEventArgs e)
    {
        CarPage carPage = new CarPage();
        this.Close();
        carPage.Show();
    }

    private void create_btn_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (fromwhere_txtbox is not null && towhere_txtbox is not null && car_name_txtbox is not null && car_num_txtbox is not null && st_attend_txtbox is not null && maxseat_txtbox is not null && Convert.ToInt32(st_attend_txtbox.Text) <= Convert.ToInt32(maxseat_txtbox.Text))
            {
                using (var dbContext = new SchoolBusDB())
                {
                    var newRide = new Ride()
                    {
                        FromWhere = fromwhere_txtbox.Text,
                        ToWhere = towhere_txtbox.Text,
                        CarName = car_name_txtbox.Text,
                        CarNumber = car_num_txtbox.Text,
                        StudentAttend = Convert.ToInt32(st_attend_txtbox.Text),
                        MaxSeat = Convert.ToInt32(maxseat_txtbox.Text)
                    };

                    dbContext.Rides.Add(newRide);
                    dbContext.SaveChanges();

                    MessageBox.Show("Creating Succesful");
                }
            }

            else
            {
                MessageBox.Show("Empty Box");
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Something is false");
        }
    }
}

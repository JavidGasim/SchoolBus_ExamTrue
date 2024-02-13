using SchoolBus_DataAccess.Contexts;
using SchoolBus_DataAccess.Repositories.Concrete;
using SchoolBus_Model.Entities.Concrete;
using System.Collections.ObjectModel;
using System.Windows;

namespace SchoolBus_WPF;

public partial class RidesPage : Window
{
    public ObservableCollection<Ride> MyData { get; set; }

    public RidesPage()
    {
        InitializeComponent();

        using (var context = new SchoolBusDB())
        {
            var data = context.Rides.ToList();
            MyData = new ObservableCollection<Ride>();

            foreach (var item in data)
            {
                MyData.Add(item);
            }

            listview1.ItemsSource = MyData;
        }
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

    private void remove_Click(object sender, RoutedEventArgs e)
    {
        using (var context = new SchoolBusDB())
        {
            var data = context.Rides.ToList();
            Ride? ride = listview1.SelectedItem as Ride;

            foreach (var item in data)
            {
                if (item.Id == ride.Id)
                {
                    context.Remove(item);
                    context.SaveChanges();
                    RidesPage ridesPage = new RidesPage();
                    this.Close();
                    ridesPage.Show();
                }
            }
        }
    }
}

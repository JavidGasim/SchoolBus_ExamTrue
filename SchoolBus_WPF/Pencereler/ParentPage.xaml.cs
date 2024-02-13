using SchoolBus_DataAccess.Contexts;
using SchoolBus_Model.Entities.Concrete;
using SchoolBus_WPF.Pencereler;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace SchoolBus_WPF;

public partial class ParentPage : Window
{
    public ObservableCollection<Parent> MyData { get; set; }

    public ParentPage()
    {
        InitializeComponent();

        using (var context = new SchoolBusDB())
        {
            var data = context.Parents.ToList();
            MyData = new ObservableCollection<Parent>();

            foreach (var item in data)
            {
                MyData.Add(item);
            }

            listview2.ItemsSource = MyData;
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
            var data = context.Parents.ToList();
            Parent? c = listview2.SelectedItem as Parent;
            foreach (var item in data)
            {
                if (item.Id == c.Id)
                {
                    context.Remove(item);
                    context.SaveChanges();
                    ParentPage parentPage = new ParentPage();
                    this.Close();
                    parentPage.Show();
                }
            }
        }
    }

    private void add_btn_Click(object sender, RoutedEventArgs e)
    {
        ParentAddPage parentAddPage = new ParentAddPage();
        this.Close();
        parentAddPage.Show();
    }
}

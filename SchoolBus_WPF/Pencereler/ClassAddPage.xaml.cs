using SchoolBus_DataAccess.Contexts;
using SchoolBus_Model.Entities.Concrete;
using System.Windows;

namespace SchoolBus_WPF;

public partial class ClassAddPage : Window
{
    public ClassAddPage()
    {
        InitializeComponent();
    }

    private void add_btn_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            if (class_txtbox is not null)
            {
                using (var dbContext = new SchoolBusDB())
                {
                    var newClass = new Class()
                    {
                        ClassName = class_txtbox.Text,
                    };

                    dbContext.Classes.Add(newClass);
                    dbContext.SaveChanges();

                    MessageBox.Show("Creating Succesful");
                    ClassPage classPage = new ClassPage();
                    classPage.Show();
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

    private void class_txtbox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
    {
        if (class_txtbox.Text.Length == 0)
        {
            class_lbl.Visibility = Visibility.Visible;
        }

        else
        {
            class_lbl.Visibility = Visibility.Collapsed;
        }
    }
}

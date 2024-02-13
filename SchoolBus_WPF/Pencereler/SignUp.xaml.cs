using System.Net.Mail;
using System.Net;
using System.Windows;
using System.Windows.Controls;

namespace SchoolBus_WPF;

public partial class SignUp : Window
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int sixDigitRandomNumber { get; set; }
    public SignUp()
    {
        InitializeComponent();
    }

    private void email_txtboxsignup_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (email_txtbox_signup.Text.Length == 0)
        {
            email_lbl_signup.Visibility = Visibility.Visible;
        }

        else
        {
            email_lbl_signup.Visibility = Visibility.Collapsed;
            Email = email_txtbox_signup.Text;
        }
    }

    private void password_txtboxsignup_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (password_txtbox_signup.Text.Length == 0)
        {
            password_lbl_signup.Visibility = Visibility.Visible;
        }

        else
        {
            password_lbl_signup.Visibility = Visibility.Collapsed;
            Password = password_txtbox_signup.Text;
        }
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
            FirstName = firstname_txtbox.Text;
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
            LastName = lastname_txtbox.Text;
        }
    }
    private void back_btn_Click(object sender, RoutedEventArgs e)
    {
        MainWindow signIn = new MainWindow();
        signIn.Show();
        this.Close();
    }

    private void nxt_btn_signup_Click(object sender, RoutedEventArgs e)
    {
        if (FirstName is not null && LastName is not null && Email is not null && Password is not null)
        {
            Random random = new Random();
            sixDigitRandomNumber = random.Next(100000, 1000000);

            string senderEmail = "projectproject611@gmail.com";
            string senderPassword = "xwuv uauv jljd cyni";

            // Receiver's email address
            string receiverEmail = Email;

            // SMTP server and port
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;

            // Create a new SmtpClient instance
            SmtpClient client = new SmtpClient(smtpServer, smtpPort);
            client.EnableSsl = true; // Enable SSL/TLS

            // Authenticate with the SMTP server
            client.Credentials = new NetworkCredential(senderEmail, senderPassword);

            // Create a new MailMessage instance
            MailMessage message = new MailMessage(senderEmail, receiverEmail);
            message.Subject = "SchoolBus Verification";
            message.Body = sixDigitRandomNumber.ToString();

            try
            {
                // Send the email
                client.Send(message);
                Verification verification = new Verification();
                verification.FirstName = FirstName;
                verification.LastName = LastName;
                verification.Email = Email;
                verification.Password = Password;
                verification.num = sixDigitRandomNumber;
                verification.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't send message");
            }

            
        }

        else
        {
            MessageBox.Show("Your Firstname (Lastname, Email or Password) is Empty");
        }
    }
}

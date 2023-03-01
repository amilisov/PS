using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;
using Welcome.Others;
using System.Net.Mail;

namespace Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Jeff",new PasswordClass("1234",1),UserRolesEnum.PROFESSOR,"0000001",new MailAddress("Jeff1@mail.mail"));
            UserViewModel viewModel = new UserViewModel(user);
            UserView userView = new UserView(viewModel);

            userView.Display();
        }
    }
}
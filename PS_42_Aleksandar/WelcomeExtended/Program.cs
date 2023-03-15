using static WelcomeExtended.Others.Delegates;
using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

namespace WelcomeExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Jhon", new Welcome.Others.PasswordClass("1111", 4), Welcome.Others.UserRolesEnum.STUDENT, "15153456", new System.Net.Mail.MailAddress("jhonny@uni.uni"));
            UserViewModel viewModel = new UserViewModel(user);
            UserView view = new UserView(viewModel);

            var log = new ActionOnError(Log);

            view.Display();
            for (int i = 0; i <3; i++)
            {
                try
                {
                    view.DisplayError("krash");
                }
                catch (Exception e)
                {
                    log(e.Message);
                }
                finally
                {
                    Console.WriteLine("Executed in any case!");
                }
            }
            
        }
    }
}
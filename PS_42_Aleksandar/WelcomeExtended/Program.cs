using static WelcomeExtended.Others.Delegates;
using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;

namespace WelcomeExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var user1 = new User("Jhon", new Welcome.Others.PasswordClass("1111", 4), Welcome.Others.UserRolesEnum.STUDENT, 15153456, new System.Net.Mail.MailAddress("jhonny@uni.uni"));
                var user2 = new User("asd", new Welcome.Others.PasswordClass("2222", 4), Welcome.Others.UserRolesEnum.STUDENT, 15153457, new System.Net.Mail.MailAddress("dsf@uni.uni"));
                var user3 = new User("hdf", new Welcome.Others.PasswordClass("3333", 4), Welcome.Others.UserRolesEnum.STUDENT, 15153458, new System.Net.Mail.MailAddress("sd@uni.uni"));

                UserData userData = new UserData();

                userData.AddUser(user1);
                userData.AddUser(user2);
                userData.AddUser(user3);

                UserHelper.ValidateCredentials("asd", "Pass");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            UserHelper.GetUser("asd", "Pass")?.ToString();
        }
    }
}
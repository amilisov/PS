using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.ViewModel;

namespace Welcome.View
{
    public class UserView
    {
        UserViewModel _viewModel;   

        public UserView(UserViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void Display()
        {
            Console.WriteLine(
                $"Welcome\n" +
                $"User: {_viewModel.Names}\n" +
                $"Role: {_viewModel.Role}\n" +
                $"Email: {_viewModel.Email}\n"
                );
        }

        public void Display2()
        {
            Console.WriteLine(
                $"Welcome " +
                $"User: {_viewModel.Names} " +
                $"Role: {_viewModel.Role} " +
                $"Email: {_viewModel.Email}"
                );
        }

        public void DisplayError(string error)
        {
            throw new Exception(error);
        }
    }
}

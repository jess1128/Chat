using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Chat.Mobile.Standard.ViewModels
{
    public class EntryPageViewModel : ViewModel
    {
        private string _username;
        public string Username
        {get => _username; set { _username = value; PropertyChange(); }}

        private string _password;
        public string Password
        {get => _password; set { _password = value; PropertyChange(); }}

        private Command _loginCommand;
        public Command LoginCommand
        {get => _loginCommand; set { _loginCommand = value; PropertyChange(); }}

        private Command _registerCommand;
        public Command RegisterCommand
        { get => _registerCommand; set { _registerCommand = value; PropertyChange(); }}

        public EntryPageViewModel()
        {
            LoginCommand = new Command(async (param) => await ExecuteLoginCommand(param));
            RegisterCommand = new Command(async (param) => await ExecuteRegisterCommand(param));
        }

        private async Task ExecuteRegisterCommand(object param)
        {
            await Task.Run(() => { });
        }

        private async Task ExecuteLoginCommand(object param)
        {
            await Task.Run(() => { });
        }
    }
}

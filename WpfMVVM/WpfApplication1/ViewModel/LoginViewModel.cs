using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApplication1.Common;
using WpfApplication1.Models;

namespace WpfApplication1.ViewModel
{
    public class LoginViewModel:ViewModelBase
    {
        private string _userName = string.Empty;
        private string _userPwd = string.Empty;

        public string UserName
        {
            get { return this._userName;}
            set { Set(ref _userName, value);}
        }

        public string UserPwd
        {
            get { return this._userPwd; }
            set { Set(ref _userPwd, value); }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        private void Login()
        {
            UserModel user = new UserModel { UserName = this.UserName, UserPwd = this.UserPwd };
            if (string.IsNullOrEmpty(this.UserName))
            {
                MessageBox.Show("请输入用户名！");
                return;
            }
            if (string.IsNullOrEmpty(this.UserPwd))
            {
                MessageBox.Show("请输入密码！");
                return;
            }
            Messenger.Default.Send(user, MessengerChannelName.OPEN_MAIN_WINDOW);
        }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(() =>
            {
                Login();
            });

            CancelCommand = new RelayCommand(()=>
            {
                Messenger.Default.Send("", MessengerChannelName.CLOSE_LOGIN_WINDOW);
            });
        }
    }
}

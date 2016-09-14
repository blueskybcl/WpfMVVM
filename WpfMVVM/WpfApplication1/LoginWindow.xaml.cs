using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApplication1.Common;
using WpfApplication1.Models;

namespace WpfApplication1
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            Messenger.Default.Register<UserModel>(this, MessengerChannelName.OPEN_MAIN_WINDOW, (user) =>
             {
                 MainWindow mainWindow = new MainWindow(user);
                 mainWindow.Show();
                 this.Close();
             });

            Messenger.Default.Register<string>(this, MessengerChannelName.CLOSE_LOGIN_WINDOW, (str) =>
            {
                MessageBox.Show("即将推出登录窗口");
                this.Close();
            });
        }
    }
}

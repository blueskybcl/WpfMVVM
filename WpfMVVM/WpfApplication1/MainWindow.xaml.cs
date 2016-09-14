using GalaSoft.MvvmLight.Messaging;
using System.Windows;
using WpfApplication1.Common;
using WpfApplication1.Models;

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserModel _currentUser = default(UserModel);
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(UserModel user)
        {
            InitializeComponent();
            this._currentUser = user;
            Messenger.Default.Register<string>(this, MessengerChannelName.CLOSE_MAIN_WINDOW, (str) =>
            {
                MessageBox.Show("将要退出主窗口");
                this.Close();
            });
        }
    }
}

using MahApps.Metro.Controls;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Application.Persistence.Desktop;
using Application.Persistence.Desktop.Models;
using System.Data.Entity;

namespace GameIndustry_v2.WPF
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : MetroWindow
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                using (ModelContainer db = new ModelContainer())
                {
                    if (txtLogin.Text != null && password.Password != null)
                    {
                        foreach (Users user in db.Users)
                        {

                            if (txtLogin.Text.Equals(user.Username) &&
                                     password.Password.Equals(user.Password) && user.Role.Equals("Admin"))
                            {
                                MessageBox.Show("Вход успешен!");
                                StartWindowUser Sform = new StartWindowUser();
                                this.Hide();
                                Sform.Show();
                                return;
                            }
                            else if (txtLogin.Text.Equals(user.Username) &&
                                     password.Password.Equals(user.Password) && user.Role.Equals("Studio"))
                            {
                                MessageBox.Show("Вход успешен!");
                                StartWindowStudio form = new StartWindowStudio();
                                this.Hide();
                                form.Show();
                                return;
                            }
                            else if (txtLogin.Text.Equals(user.Username) &&
                                     password.Password.Equals(user.Password) && user.Role.Equals("User"))
                            {
                                MessageBox.Show("Вход успешен!");
                                StartWindowUser form = new StartWindowUser();
                                this.Hide();
                                form.Show();
                                return;
                            }
                        }

                        MessageBox.Show("Логин или пароль указан неверно!");
                    }
                    else
                        MessageBox.Show("Введите все поля");
                }
        
        }
    }
}

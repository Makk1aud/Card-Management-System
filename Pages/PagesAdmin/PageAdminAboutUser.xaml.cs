﻿using Card_management_system.Classes;
using Card_management_system.DataApp;
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

namespace Card_management_system.Pages.PagesAdmin
{
    public partial class PageAdminAboutUser : Page
    {
        Users users;
        public PageAdminAboutUser(Users users)
        {
            InitializeComponent();
            this.users = users;
            dataGridListOfCards.ItemsSource = PageClass.connectDB.Client.Where(x => x.userid== users.id).ToList();
        }

        private void buttonSaveChanges_Click(object sender, RoutedEventArgs e)
        {
            DataBaseCardManagement.SaveChangesDataBase("Успешно");
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            PageClass.frameObject.GoBack();
        }
    }
}

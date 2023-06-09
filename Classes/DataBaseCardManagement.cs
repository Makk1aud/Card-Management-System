﻿using Card_management_system.DataApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Xml.Serialization;

namespace Card_management_system.Classes
{
    static class DataBaseCardManagement
    {
        public static void SaveChangesDataBase(string message)
        {
            try
            {
                PageClass.connectDB.SaveChanges();
                MessageBox.Show(message, 
                    "Объявление", 
                    MessageBoxButton.OK, 
                    MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool CheckDistinctEmailData(string stringData) => PageClass.connectDB.Users.Count(x => x.login == stringData) > 0;
    }
}

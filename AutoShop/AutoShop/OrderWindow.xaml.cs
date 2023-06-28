using AutoShop.DB;
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

namespace AutoShop
{
    /// <summary>
    /// Логика взаимодействия для OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        AppC AC;
        public OrderWindow()
        {
            InitializeComponent();
            AC = new AppC();
            //первоначально открывается окно добавления клиента
            ClientGrid.Visibility = Visibility.Visible;
            OrderGrid.Visibility = Visibility.Hidden;
            //весь сохраненный текст (который мы сохраняли в MainWindow.cs) мы вносим в ProductLabel(все продукты из корзины) и
            //FinnalyPrice(общая стоимость)
            ProductLabel.Text = RemClass.OrderRem;
            FinnalyPriceDB.Content = RemClass.FinPriceOrder;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            //кнопка назад. стираем все сохраненное и возвращаемся в MainWindow
            RemClass.FinPriceOrder = 0;
            RemClass.OrderRem = "";
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            //при нажатии кнопки "далее" добавляем клиента в базу данных, сохраняем в наш класс с переменными, закрываем окно с клиентами и открываем окно с оформлением заказа
            Client client = new Client(FIOText.Text, EmailText.Text, NumPhoneText.Text, AddressText.Text);
            AC.Clients.Add(client);           
            AC.SaveChanges();
            RemClass.RemClientID = client.ID;
            ClientGrid.Visibility = Visibility.Hidden;
            OrderGrid.Visibility = Visibility.Visible;
        }

        private void NextButton_OrderGrid_Click(object sender, RoutedEventArgs e)
        {
            //кнопка далле в окне оформления заказа.
            //ищем провадера(получается нас) по сохраненному логину в бд
            var me = AC.Providers.Where(c => c.login == RemClass.savelogin).FirstOrDefault();
            //ищем корзину по сохраненной корзине в бд
            var sc = AC.ShoppingCarts.Where(c => c.products == RemClass.OrderRem).FirstOrDefault();
            //добавляем заказ
            Order order = new Order(RemClass.RemClientID, me.ID, sc.ID, DateTime.Now.ToString(), "",1,RemClass.FinPriceOrder, CommentText.Text);
            AC.Orders.Add(order);
            AC.SaveChanges();
            //стираем все сохраненное и возвращаемся в MainWindow
            RemClass.FinPriceOrder = 0;
            RemClass.OrderRem = "";
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            //если окно закрывается то стираем все сохраненное
            RemClass.FinPriceOrder = 0;
            RemClass.OrderRem = "";
        }
    }
}

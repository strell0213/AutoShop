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
    /// Логика взаимодействия для AboutWindow.xaml
    /// </summary>
    public partial class AboutWindow : Window
    {
        AppC AC;
        public AboutWindow()
        {
            //окно подробного заказа
            InitializeComponent();
            AC = new AppC();
            //список статусов из бд добавляем в комбобокс
            var stbox = AC.Statuse.Select(c => c.statusName).ToList();
            ChangeStatusBox.ItemsSource = stbox;
            
            string dateend;
            //ищем заказ на который нажали
            int idor = Convert.ToInt32(RemClass.OrderRem);
            var main = AC.Orders.Where(c => c.ID == idor).FirstOrDefault();
            //ищем клиента из заказа
            var cli = AC.Clients.Where(c => c.ID == main.IDClient).FirstOrDefault();
            //ищем провайдера из заказа
            var prov = AC.Providers.Where(c => c.ID ==main.IDProvider).FirstOrDefault();
            //ищем текущий статус заказа
            var st = AC.Statuse.Where(c => c.ID == main.StatusID).FirstOrDefault();
            //если даты окончания заказа нет то он будет как "выполняется заказ"
            if (main.dateEnd == "")
            {
                dateend = "Выполняется заказ";
            }
            else { 
                dateend = main.dateEnd;
            }
            //вносим все в текст
            AboutTextBlock.Text = "Заказ: "+main.ID.ToString()+"\nКлиент: "+cli.fIO+"\nПровайдер: "+prov.fIO+"\nДата оформления:" +
                " "+main.dateStart+"\nДата окончания: "+dateend+"\nСтатус: "+st.statusName+"\nСтоимость: "+main.FinallyPrice+" рублей\nКомментариии: "+main.discription;

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            //кнопка назад. возвращаемся в MainWindow
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ChangeStatusBox_DropDownClosed(object sender, EventArgs e)
        {
            //изменение статуса при закрытии комбобокса
            var buttondel = (ComboBox)sender;
            if (buttondel.SelectedItem != null)
            {
                //ищем заказ на который нажали
                int idor = Convert.ToInt32(RemClass.OrderRem);
                var main = AC.Orders.Where(c => c.ID == idor).FirstOrDefault();
                //присваеваем выбранный статус в заказ
                main.StatusID = buttondel.SelectedIndex + 1;
                //открываем текст "Успешно!"
                SText.Visibility = Visibility.Visible;
                //если выбранный элемент по индексу равен 4 (Готов) то добавляем заказ время окончания
                 if (buttondel.SelectedIndex + 1 == 4)
                {
                    main.dateEnd = DateTime.Now.ToString();
                }
                AC.SaveChanges();
            }
            else { 
                
            }
        }
    }
}

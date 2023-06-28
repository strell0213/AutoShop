using AutoShop.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;


namespace AutoShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        //код подключения к базе данных находиться в App.config (<connectionStrings>) и в классе AC.cs
        //используемые пакеты:
        //EntityFrameWork и System.Data.SQLite (посмотреть можно в Пакет > Усправление пакетами NuGet > Установлено)
        //Класс для таблицы в базе данных находится в папке DB
        AppC AC;
        int[] sc = new int[200];
        int allsale = 0;
        int todaySale = 0;
        int allpriceprod = 0;
        int payback = 0;
        public MainWindow()
        {
            InitializeComponent();
            //комнда что бы первоначально открывалось окно с логином и паролем
            LoginGrid.Visibility = Visibility.Visible;
            AC = new AppC();
        }

        private void ShoppingCartButton_Click(object sender, RoutedEventArgs e)
        {
            //открытие корзины. если он закрыт то открывается и наоборот
            if (ShoppingCartGrid.Visibility == Visibility.Hidden)
            {
                ShoppingCartGrid.Visibility = Visibility.Visible;
            }
            else { 
                ShoppingCartGrid.Visibility = Visibility.Hidden;
            }
        }

        private void OpenHimiaListButton_Click(object sender, RoutedEventArgs e)
        {
            //ищем в базе даннных все продукты с типом 1(автохимия) и заносим все в список автохимии AutoHimiaList
            var r = AC.Products.Where(c => c.TypeID == 1).ToList();
            AutoHimiaList.ItemsSource = r;

            //открываем список автохимии и закрываем все остальные, а так же перекрашиваем кнопку "автохимия" в зеленый цвет а все оста
            //льные в белый цвет
            AutoHimiaList.Visibility = Visibility.Visible;
            AcessList.Visibility = Visibility.Hidden;
            AutolampsList.Visibility = Visibility.Hidden;
            ToolsList.Visibility = Visibility.Hidden;
            OrdersList.Visibility = Visibility.Hidden;
            OpenHimiaListButton.Foreground = new SolidColorBrush(Colors.Green);
            OpenAccessoriesListButton.Foreground = new SolidColorBrush(Colors.White);
            OpenAutoLampsButton.Foreground = new SolidColorBrush(Colors.White);
            OpenToolsListButton.Foreground= new SolidColorBrush(Colors.White);
            OrderListButton.Foreground = new SolidColorBrush(Colors.White);

        }

        private void QntyHimBox_DropDownOpened(object sender, EventArgs e)
        {
            //если комбобокс открывается то
            var buttondel = (ComboBox)sender;
            var or = (Product)buttondel.DataContext;
            //заносим все количество из базы данных в комбобокс, обозначеным как buttondel
            for (int i = 1; i <= Convert.ToInt32(or.quantity); i++)
            {
                buttondel.Items.Add(i.ToString());
            }
        }

        private void AHToShopCartButton_Click(object sender, RoutedEventArgs e)
        {
            //функция добовления в корзину
            if (RemClass.ComboQnt > 0)
            {
                //определяем товар на котором была кнопка "В корзину"
                var buttondel = (Button)sender;
                var or = (Product)buttondel.DataContext;
                //в лейбл добавляем: уже имеющиеся текст + название продукта + его количество
                SCLabel.Text = SCLabel.Text + or.nameProduct + " (x" + RemClass.ComboQnt + "),";
                
                //в интовый массив sc добавляем общюю стоимость это нужно если выбрано больше одного товара
                for (int i = 1; i <= sc.Length; i++)
                {
                    if (sc[i] == 0)
                    {
                        sc[i] = or.Price * RemClass.ComboQnt;
                        break;
                    }
                }

                //вычитаем выбранное количество и вычитаем из общего что бы не было бесконечного количества товаров
                int q = Convert.ToInt32(or.quantity);
                q = q - RemClass.ComboQnt;
                or.quantity = q.ToString();
                AC.SaveChanges();

                RemClass.ComboQnt = 0;
            }
            else
            {
                MessageBox.Show("Выберите количество товара!","АвтоЛайн");
            }
        }

        private void QntyHimBox_DropDownClosed(object sender, EventArgs e)
        {
            //если окно комбобокса закрывается то выбранный элемент записывается в ComboQnt(это обычный стринг), это нужно для дальнейшего использования количества товара
            try
            {
                var buttondel = (ComboBox)sender;
                RemClass.ComboQnt = Convert.ToInt32(buttondel.SelectedItem.ToString());

            }
            catch { }
        }

        private void OpenAccessoriesListButton_Click(object sender, RoutedEventArgs e)
        {
            //ищем в базе даннных все продукты с типом 2(Аксессуары) и заносим все в список автохимии AcessList
            var r = AC.Products.Where(c => c.TypeID == 2).ToList();
            AcessList.ItemsSource = r;

            //открываем список аксессуаров и закрываем все остальные, а так же перекрашиваем кнопку "аксессуары" в зеленый цвет а все оста
            //льные в белый цвет
            AcessList.Visibility = Visibility.Visible;
            AutoHimiaList.Visibility = Visibility.Hidden;
            AutolampsList.Visibility = Visibility.Hidden;
            ToolsList.Visibility = Visibility.Hidden;
            OrdersList.Visibility = Visibility.Hidden;
            OpenHimiaListButton.Foreground = new SolidColorBrush(Colors.White);
            OpenAccessoriesListButton.Foreground = new SolidColorBrush(Colors.Green);
            OpenAutoLampsButton.Foreground = new SolidColorBrush(Colors.White);
            OpenToolsListButton.Foreground = new SolidColorBrush(Colors.White);
            OrderListButton.Foreground = new SolidColorBrush(Colors.White);
        }

        private void OpenAutoLampsButton_Click(object sender, RoutedEventArgs e)
        {
            //ищем в базе даннных все продукты с типом 3(Автолампы) и заносим все в список автохимии AutolampsList
            var r = AC.Products.Where(c => c.TypeID == 3).ToList();
            AutolampsList.ItemsSource = r;

            //открываем список автоламп и закрываем все остальные, а так же перекрашиваем кнопку "автолампы" в зеленый цвет а все оста
            //льные в белый цвет
            AcessList.Visibility = Visibility.Hidden;
            AutoHimiaList.Visibility = Visibility.Hidden;
            AutolampsList.Visibility = Visibility.Visible;
            ToolsList.Visibility = Visibility.Hidden;
            OrdersList.Visibility = Visibility.Hidden;
            OpenHimiaListButton.Foreground = new SolidColorBrush(Colors.White);
            OpenAccessoriesListButton.Foreground = new SolidColorBrush(Colors.White);
            OpenAutoLampsButton.Foreground = new SolidColorBrush(Colors.Green);
            OpenToolsListButton.Foreground = new SolidColorBrush(Colors.White);
            OrderListButton.Foreground = new SolidColorBrush(Colors.White);
        }

        private void OpenToolsListButton_Click(object sender, RoutedEventArgs e)
        {
            //ищем в базе даннных все продукты с типом 4(Инструменты) и заносим все в список автохимии ToolsList
            var r = AC.Products.Where(c => c.TypeID == 4).ToList();
            ToolsList.ItemsSource = r;

            //открываем список инструментов и закрываем все остальные, а так же перекрашиваем кнопку "инструментов" в зеленый цвет а все оста
            //льные в белый цвет
            AcessList.Visibility = Visibility.Hidden;
            AutoHimiaList.Visibility = Visibility.Hidden;
            AutolampsList.Visibility = Visibility.Hidden;
            ToolsList.Visibility = Visibility.Visible;
            OrdersList.Visibility = Visibility.Hidden;
            OpenHimiaListButton.Foreground = new SolidColorBrush(Colors.White);
            OpenAccessoriesListButton.Foreground = new SolidColorBrush(Colors.White);
            OpenAutoLampsButton.Foreground = new SolidColorBrush(Colors.White);
            OpenToolsListButton.Foreground = new SolidColorBrush(Colors.Green);
            OrderListButton.Foreground = new SolidColorBrush(Colors.White);
        }

        private void OrderListButton_Click(object sender, RoutedEventArgs e)
        {
            //ищем в базе данных все существующие заказы и так же заносим в список заказов (OrdersList)
            var r = AC.Orders.ToList();
            OrdersList.ItemsSource = r;

            //открываем список заказов и закрываем все остальные, а так же перекрашиваем кнопку "Заказы" в зеленый цвет а все оста
            //льные в белый цвет
            OrdersList.Visibility = Visibility.Visible;
            AcessList.Visibility = Visibility.Hidden;
            AutoHimiaList.Visibility = Visibility.Hidden;
            AutolampsList.Visibility = Visibility.Hidden;
            ToolsList.Visibility = Visibility.Hidden;
            OpenHimiaListButton.Foreground = new SolidColorBrush(Colors.White);
            OpenAccessoriesListButton.Foreground = new SolidColorBrush(Colors.White);
            OpenAutoLampsButton.Foreground = new SolidColorBrush(Colors.White);
            OpenToolsListButton.Foreground = new SolidColorBrush(Colors.White);
            OrderListButton.Foreground = new SolidColorBrush(Colors.Green);
        }

        private void DoOrderButton_Click(object sender, RoutedEventArgs e)
        {
            //из интового массива берем все значениям и прибавляем друг к другу 
            for (int i = 0; i < sc.Length; i++) { 
                RemClass.FinPriceOrder += sc[i];
            }
            //текст с товарами в корзине заносим в свой стринг для добавления в базу данных с корзинами
            RemClass.OrderRem = SCLabel.Text.ToString();
            ShoppingCart shoppingCart = new ShoppingCart(RemClass.OrderRem);
            AC.ShoppingCarts.Add(shoppingCart);
            AC.SaveChanges();

            //открываем окно с оформлением заказов
            OrderWindow orderWindow = new OrderWindow();
            orderWindow.Show();
            this.Close();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            //авторизация. ищем логин схожий на написанное в LoginText
            var r = AC.Providers.Where(c=> c.login == LoginText.Text).FirstOrDefault();
            //если такой есть
            if (r != null)
            {
                //проверяем написанный пароль с тем что нашли в базу данных
                if (PasswordText.Password == r.password)
                {
                    //если все успешно то сохраняем логин в стринг для дальнейшего использования и закрываем окно авторизации
                    RemClass.savelogin = r.login;
                    LoginGrid.Visibility = Visibility.Hidden;
                    FIOTextBlock.Text = r.fIO;
                }
                else {
                    MessageBox.Show("Пароль не верный!");
                }
            }
            else {
                MessageBox.Show("Такого пользователя не существует!","АвтоЛайн");
            }
        }

        private void AboutOrderButton_Click(object sender, RoutedEventArgs e)
        {
            //кнопка "Подробнее" в списке заказов. Определяем выбранный элемент
            var buttondel = (Button)sender;
            var or = (Order)buttondel.DataContext;
            //сохраняем в OrderRem для использования его в окне AboutWindow
            RemClass.OrderRem = or.ID.ToString();
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.Show();
            this.Close();
        }

        private void StaticButton_Head_Click(object sender, RoutedEventArgs e)
        {
            //кнопка статистики. в этом коде происходят подсчеты всего в рублях
            if (StatGrid.Visibility == Visibility.Hidden)
            {
                StatGrid.Visibility = Visibility.Visible;
                //подсчет всех проданных товаров. allsale это int который я написал в самом верху, в него будет итоговая стоимость 
                allsale = 0;
                //берем список всех заказов и через цикл прибавляем все в allsale
                var r = AC.Orders.ToList();
                for (int i = 0; i < r.Count; i++)
                {
                    allsale += r[i].FinallyPrice;
                }
                //заносим в текст
                AllSaleText.Text = "Всего продано (руб.): " + allsale.ToString();

                //подсчет всех проданных товаров за сегодня. todaysale это int который я написал в самом верху, в него будет итоговая стоимость
                todaySale = 0;
                //берем сегоднянюю дату, которая выводится как (дд.мм.гггг чч.мм.сс). через цыкл мы убираем час, минуты и секунды
                string da = DateTime.Today.ToString();
                string da1 = "";
                for (int i = 0; i <= da.Length; i++) {
                    if (i == 10)
                    {
                        break;
                    }
                    else {
                        da1 += da[i];
                    }
                }
                //проверяем товары которые совпадают с сегодняшней датой и если такие есть то вносим итоговую стоимость
                var r1 = AC.Orders.Where(c => c.dateStart.Contains(da1)).ToList();
                for (int i = 0; i < r1.Count; i++)
                {
                    todaySale += r1[i].FinallyPrice;
                }
                TodaySaleText.Text = "Продано сегодня (руб.): " + todaySale.ToString();

                //подсчет всех существующих товаров (не учитывая заказы). allpriceprod это int который я написал в самом верху, в него будет итоговая стоимость
                var r2 = AC.Products.ToList();
                allpriceprod = 0;
                for (int i = 0; i < r2.Count; i++)
                {
                    allpriceprod += r2[i].Price * Convert.ToInt32(r2[i].quantity);
                }
                CountProductText.Text = "Общая стоимость товаров (Руб.): " + allpriceprod.ToString();

                //подсчитываем окуп с продаж
                if (allpriceprod > allsale)
                {
                    payback = allpriceprod - allsale;
                    OkupText.Text = "Окуп (руб.): -" + payback.ToString();
                }
                else if (allsale > allpriceprod)
                {
                    payback = allsale - allpriceprod;
                    OkupText.Text = "Окуп (руб.): " + payback.ToString();
                }
            }
            else {
                StatGrid.Visibility = Visibility.Hidden;
            }
        }

        private void WordButton_Click(object sender, RoutedEventArgs e)
        {
            //вывод отчета в ворд. тут я мало что могу обьяснить но на каждую строку нужен свой wrdSelection(я так понял с помощью него все записывается в ворд)
            //
            Word.Application wrdApp;
            Word._Document wrdDoc;
            Word.Selection wrdSelection;
            Object oMissing = System.Reflection.Missing.Value;
            Object oFalse = false;
            string strtoAdd;
            string strtoAdd2;
            string strtoAdd3;
            string strtoAdd4;

            wrdApp = new Word.Application();
            wrdApp.Visible = true;
            
            wrdDoc = wrdApp.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            wrdDoc.Select();

            strtoAdd = "Отчет по проданным товарам\n\n";
            wrdSelection = wrdApp.Selection;
            wrdSelection.ParagraphFormat.SpaceAfter = 0;
            wrdSelection.ParagraphFormat.Alignment =
                Word.WdParagraphAlignment.wdAlignParagraphCenter;
            wrdSelection.Font.Bold = 1;
            wrdSelection.Font.Size = 24;
            wrdSelection.Font.Name = "Times New Roman";
            wrdSelection.ParagraphFormat.LineSpacing = 11;
            wrdSelection.ParagraphFormat.LineUnitBefore = 0;
            wrdSelection.TypeText(strtoAdd);

            var r = AC.Providers.Where(c => c.login == RemClass.savelogin).FirstOrDefault();
            strtoAdd2 = r.fIO+"\n\n\n";
            wrdSelection.ParagraphFormat.SpaceAfter = 0;
            wrdSelection.ParagraphFormat.Alignment =
                Word.WdParagraphAlignment.wdAlignParagraphRight;
            wrdSelection.Font.Bold = 1;
            wrdSelection.Font.Size = 10;
            wrdSelection.Font.Name = "Times New Roman";
            wrdSelection.ParagraphFormat.LineSpacing = 11;
            wrdSelection.ParagraphFormat.LineUnitBefore = 0;
            wrdSelection.TypeText(strtoAdd2);

            strtoAdd3 = AllSaleText.Text + "\n\n" + TodaySaleText.Text + "\n\n"+ CountProductText.Text + "\n\n" + OkupText.Text+"\n\n\n\n";
            wrdSelection = wrdApp.Selection;
            wrdSelection.ParagraphFormat.SpaceAfter = 0;
            wrdSelection.ParagraphFormat.Alignment =
                Word.WdParagraphAlignment.wdAlignParagraphLeft;
            wrdSelection.Font.Bold = 1;
            wrdSelection.Font.Size = 14;
            wrdSelection.Font.Name = "Times New Roman";
            wrdSelection.ParagraphFormat.LineSpacing = 11;
            wrdSelection.ParagraphFormat.LineUnitBefore = 0;
            wrdSelection.TypeText(strtoAdd3);

            strtoAdd4 = "Подпись:_________________\tАвтоЛайн";
            wrdSelection = wrdApp.Selection;
            wrdSelection.ParagraphFormat.SpaceAfter = 0;
            wrdSelection.ParagraphFormat.Alignment =
                Word.WdParagraphAlignment.wdAlignParagraphLeft;
            wrdSelection.Font.Bold = 1;
            wrdSelection.Font.Size = 14;
            wrdSelection.Font.Name = "Times New Roman";
            wrdSelection.ParagraphFormat.LineSpacing = 11;
            wrdSelection.ParagraphFormat.LineUnitBefore = 0;
            wrdSelection.TypeText(strtoAdd4);

            wrdDoc.Saved = true;
            //AppDomain.CurrentDomain.BaseDirectory - путь до папки с программой
            object fileName = AppDomain.CurrentDomain.BaseDirectory + "_Отчет.doc";
            wrdDoc.SaveAs2(ref fileName, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);
            wrdDoc.Close(ref oFalse, ref oMissing, ref oMissing);
            wrdApp.Quit(ref oFalse, ref oMissing, ref oMissing);

            wrdDoc = null;
            wrdApp = null;
            MessageBox.Show("Документ сохранен: " + AppDomain.CurrentDomain.BaseDirectory,"АвтоЛайн");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        //public Window1()
        //{
        //    InitializeComponent();
        //}

        Dictionary<String, Hero> map = new Dictionary<String, Hero>();
        public Window1()
        {
            InitializeComponent();
            InitDictonary();
           
            listViewStudent.ItemsSource = map.Values;
        }
        private void InitDictonary()
        {
            Hero hero1 = new Hero(1, "刘备", "哭泣", true);
            map.Add(hero1.Name, hero1);
            Hero hero2 = new Hero(2, "官羽", "贪污", false);
            map.Add(hero2.Name, hero2);
            Hero hero3 = new Hero(3, "黄忠", "射击", true);
            map.Add(hero3.Name, hero3);
            Hero hero4 = new Hero(4, "魏延", "突击", true);
            map.Add(hero4.Name, hero4);
            Hero hero5 = new Hero(5, "马超", "单挑", false);
            map.Add(hero5.Name, hero5);
            Hero hero6 = new Hero(6, "曹仁", "防守", true);
            map.Add(hero6.Name, hero6);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            map["官羽"].Name = "关羽";
            map["官羽"].Skill = "单挑";
        }
      
    }
      
}

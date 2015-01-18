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

namespace CLRS.Para2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        public void Test1()
        {
            InsertionSort ins =new InsertionSort();
            var a = ins.GetAnInt(10);
            var list = a.ToList();
            Console.WriteLine("start");
            list.ForEach(m=>Console.Write(m+" "));
            Console.WriteLine();

            Console.WriteLine("sort un desc");
            int[] b = new int[a.Length];
            a.CopyTo(b,0);
            ins.SortUnDesc(b);
            var list2 = b.ToList();
            list2.ForEach(m=>Console.Write(m+" "));
            Console.WriteLine();

            Console.WriteLine("sort un asc");
            int[] c=new int[a.Length];
            a.CopyTo(c,0);
            ins.SortUnAsc(c);
            var list3 = c.ToList();
            list3.ForEach(m=>Console.Write(m+" "));

        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Test1();
        }
    }
}

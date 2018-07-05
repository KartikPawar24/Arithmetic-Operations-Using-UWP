using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Arithmetic_Operations_Using_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnadd_Click(object sender, RoutedEventArgs e)
        {
            float a = Convert.ToInt32(txtnum1.Text);
            float b = Convert.ToInt32(txtnum2.Text);
            tblresult.Text = (a + b).ToString();
        }

        private void btnsub__Click(object sender, RoutedEventArgs e)
        {
            float a = Convert.ToInt32(txtnum1.Text);
            float b = Convert.ToInt32(txtnum2.Text);
            tblresult.Text = (a - b).ToString();
        }

        private void btnmul_Click(object sender, RoutedEventArgs e)
        {
            float a = Convert.ToInt32(txtnum1.Text);
            float b = Convert.ToInt32(txtnum2.Text);
            tblresult.Text = (a * b).ToString();
        }

        private void btndiv_Click(object sender, RoutedEventArgs e)
        {
            float a = Convert.ToInt32(txtnum1.Text);
            float b = Convert.ToInt32(txtnum2.Text);
            tblresult.Text = (a / b).ToString();
        }

        private void btnrem_Click(object sender, RoutedEventArgs e)
        {
            int a = Convert.ToInt32(txtnum1.Text);
            int b = Convert.ToInt32(txtnum2.Text);
            tblresult.Text = (a % b).ToString();
        }

        private void btnclr_Click(object sender, RoutedEventArgs e)
        {
            txtnum1.Text = String.Empty;
            txtnum2.Text = String.Empty;
            tblresult.Text = String.Empty;
        }
    }
}

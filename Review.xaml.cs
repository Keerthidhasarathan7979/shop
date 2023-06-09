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
using System.Data.SqlClient;
using System.Data;


namespace Billing
{
    /// <summary>
    /// Interaction logic for Review.xaml
    /// </summary>
    public partial class Review : Window
    {
       
       
        public Review()
        {
            
            InitializeComponent();

           
        }
       

        //public void InitializeComponent()
        //{
        //    throw new NotImplementedException();
        //}

        private void c1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c1.Background = c1.Foreground;
        }



        private void c2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c2.Background = c2.Foreground;
            c1.Background = c2.Foreground;
        }

        private void c3_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c3.Background = c3.Foreground;
            c2.Background = c3.Foreground;
            c1.Background = c3.Foreground;
        }

        private void c4_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c4.Background = c4.Foreground;
            c3.Background = c4.Foreground;
            c2.Background = c4.Foreground;
            c1.Background = c4.Foreground;
        }

        private void c5_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c5.Background = c5.Foreground;
            c4.Background = c5.Foreground;
            c3.Background = c5.Foreground;
            c2.Background = c5.Foreground;
            c1.Background = c5.Foreground;
        }

        private void c11_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c11.Background = c11.Foreground;
        }

        private void c12_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c12.Background = c12.Foreground;
            c11.Background = c12.Foreground;
        }

        private void c13_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c13.Background = c13.Foreground;
            c12.Background = c13.Foreground;
            c11.Background = c13.Foreground;
        }

        private void c14_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c14.Background = c14.Foreground;
            c13.Background = c14.Foreground;
            c12.Background = c14.Foreground;
            c11.Background = c14.Foreground;
        }

        private void c15_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c15.Background = c15.Foreground;
            c14.Background = c15.Foreground;
            c13.Background = c15.Foreground;
            c12.Background = c15.Foreground;
            c11.Background = c15.Foreground;
        }

        private void c21_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c21.Background = c21.Foreground;
        }

        private void c22_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c22.Background = c22.Foreground;
            c21.Background = c22.Foreground;
        }

        private void c23_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c23.Background = c23.Foreground;
            c22.Background = c23.Foreground;
            c21.Background = c23.Foreground;
        }

        private void c24_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c24.Background = c24.Foreground;
            c23.Background = c24.Foreground;
            c22.Background = c24.Foreground;
            c21.Background = c24.Foreground;
        }

        private void c25_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            c25.Background = c25.Foreground;
            c24.Background = c25.Foreground;
            c23.Background = c25.Foreground;
            c22.Background = c25.Foreground;
            c21.Background = c25.Foreground;
        }

        private void c31_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c31.Background = c31.Foreground;
        }

        private void c32_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c32.Background = c32.Foreground;
            c31.Background = c32.Foreground;
        }

        private void c33_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c33.Background = c33.Foreground;
            c32.Background = c33.Foreground;
            c31.Background = c33.Foreground;
        }


        private void c34_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c34.Background = c34.Foreground;
            c33.Background = c34.Foreground;
            c32.Background = c34.Foreground;
            c31.Background = c34.Foreground;
        }

        private void c35_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c35.Background = c35.Foreground;
            c34.Background = c35.Foreground;
            c33.Background = c35.Foreground;
            c32.Background = c35.Foreground;
            c31.Background = c35.Foreground;

        }

        private void c41_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c41.Background = c41.Foreground;
        }

        private void c42_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c42.Background = c42.Foreground;
            c41.Background = c42.Foreground;
        }

        private void c43_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c43.Background = c43.Foreground;
            c42.Background = c43.Foreground;
            c41.Background = c43.Foreground;
        }

        private void c44_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c44.Background = c44.Foreground;
            c43.Background = c44.Foreground;
            c42.Background = c44.Foreground;
            c41.Background = c44.Foreground;
        }

        private void c45_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            c45.Background = c45.Foreground;
            c44.Background = c45.Foreground;
            c43.Background = c45.Foreground;
            c42.Background = c45.Foreground;
            c41.Background = c45.Foreground;
        }

       
    }


}   


   




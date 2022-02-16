using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace practicaMVC
{
    public class PracticaMVCControll
    {
        private MainWindow main;
        private Persona per;
        public PracticaMVCControll(MainWindow main)
        {
            this.main = main;
            per = new Persona();
            
        }

        public void Sumar()
        {
            double a = Convert.ToDouble(main.Num1.Text);
            double b = Convert.ToDouble(main.Num2.Text);
            double c = per.sum(a, b);
            main.Num3.Text = c.ToString();
            
        }
        public void buton_Click(object sender, RoutedEventArgs e)
        {
            Sumar();
        }

        public void Borrar(object sender, RoutedEventArgs e)
        {
            main.Num1.Clear();
            main.Num2.Clear();
            main.Num3.Clear();
        }


    }
}
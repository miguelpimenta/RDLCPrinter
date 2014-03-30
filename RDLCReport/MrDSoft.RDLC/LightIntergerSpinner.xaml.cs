﻿using System;
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

namespace DSoft.RDLCReport
{
    /// <summary>
    /// Logique d'interaction pour LightIntergerSpinner.xaml
    /// </summary>
    public partial class LightIntergerSpinner : UserControl
    {
        private int _minimum = 0;
        private int _maximum = 50;


        public LightIntergerSpinner()
        {
            InitializeComponent();
        }

        public int? Value
        {
            get
            {
                try
                {
                    return Convert.ToInt32(NumPager.Text);
                }
                catch
                {
                    return null;
                }
            }
            set
            {                
                NumPager.Text = value.ToString();
            }
        }

        public int Minimum
        {
            get
            {
                return this._minimum;
            }
            set
            {
                this._minimum = value;

                CheckRange();
            }
        }

        public int Maximum
        {
            get
            {
                return this._maximum;
            }
            set
            {
                this._maximum = value;

                CheckRange();
            }
        }

        private void CheckRange()
        {
            if (this.Value > this._maximum)
                this.Value = this._maximum;

            if (this.Value < this._minimum)
                this.Value = this._minimum;
        }

        private void SpinnerUp_Click(object sender, RoutedEventArgs e)
        {
            if (this.Value < this._maximum)
                this.Value += 1;
        }

        private void SpinnerDown_Click(object sender, RoutedEventArgs e)
        {
            if (this.Value > this._minimum)
                this.Value -= 1;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            CheckRange();
        }
    }
}
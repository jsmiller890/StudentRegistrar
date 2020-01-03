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

namespace WPFRegisterStudent
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Course choice;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Course course1 = new Course("IT 145");
            Course course2 = new Course("IT 200");
            Course course3 = new Course("IT 201");
            Course course4 = new Course("IT 270");
            Course course5 = new Course("IT 315");
            Course course6 = new Course("IT 328");
            Course course7 = new Course("IT 330");


            this.comboBox.Items.Add(course1);
            this.comboBox.Items.Add(course2);
            this.comboBox.Items.Add(course3);
            this.comboBox.Items.Add(course4);
            this.comboBox.Items.Add(course5);
            this.comboBox.Items.Add(course6);
            this.comboBox.Items.Add(course7);


            this.textBox.Text = "0";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            choice = (Course)(this.comboBox.SelectedItem);
            int totalCredits = Convert.ToInt32(textBox.Text);


            if (choice.IsRegisteredAlready() == false && totalCredits < 9)
            {
                this.listBox.Items.Add(choice);
                choice.SetToRegistered();
                totalCredits = totalCredits + 3;
                textBox.Text = Convert.ToString(totalCredits);
                label3.Content = String.Format("Registration confirmed for course {0}", choice);
            }
            else if (choice.IsRegisteredAlready() == true)
            {
                label3.Content = String.Format("You have already registered for this {0} course.", choice);
            }
            else if (totalCredits == 9)
            {
                label3.Content = ("You can not register for more than 9 credit hours.");
            }






            // TO DO - Create code to validate user selection (the choice object)
            // and to display an error or a registation confirmation message accordinlgy
            // Also update the total credit hours textbox if registration is confirmed for a selected course

        }

    }
}

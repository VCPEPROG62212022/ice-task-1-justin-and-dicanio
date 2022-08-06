using System;
using System.Collections.Generic;
using System.IO;
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

namespace prjICE_Task_1_Linq_and_TextFiles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
         

        }
        
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
          
            try//
            {
                //Directory/Text File Path
                string filePath = @"C:\Users\lab_services_student\source\repos\prjICE_Task_1_Linq_and_TextFiles\bin" + "\\Debug\\" + "Register.txt";
                StreamWriter write = new StreamWriter(filePath);
                using(write)
                {
                    
                    write.WriteLine("STUDENT NUMBER: " + txtStudentNumber.Text);
                    write.WriteLine("NAME AND SURNAME: " + txtFullName.Text);
                    write.WriteLine("AGE: " + txtAge.Text);
                    write.WriteLine("********************************************************");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("An error message has orrcured", "Information not found!");
            }
            
            
        }

        private void lstPrint_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StreamReader read = new StreamReader(@"C:\Users\lab_services_student\source\repos\prjICE_Task_1_Linq_and_TextFiles\bin" + "\\Debug\\" + "Register.txt");
            String s = read.ReadToEnd();
            Console.WriteLine(s);
            read.Close();

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter edit = new StreamWriter(@"C:\Users\lab_services_student\source\repos\prjICE_Task_1_Linq_and_TextFiles\bin" + "\\Debug\\" + "Register.txt" , true);
            for (int i = 0; i < 10; i++)
            {
                edit.Write(i);
            }
            edit.Close();
            
        }
    }
}

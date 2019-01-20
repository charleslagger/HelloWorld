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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = new HelloWorld.ViewModel.StudentViewModel();
        }

        //private void StudentViewControl_Loaded(object sender, RoutedEventArgs e)
        //{
        //    HelloWorld.ViewModel.StudentViewModel studentViewModelObject =
        //       new HelloWorld.ViewModel.StudentViewModel();
        //    //studentViewModelObject.LoadStudents();

        //    StudentViewControl.DataContext = studentViewModelObject;
        //}
    }
}

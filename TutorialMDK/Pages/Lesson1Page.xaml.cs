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

namespace TutorialMDK.Pages
{
    /// <summary>
    /// Логика взаимодействия для Lesson1Page.xaml
    /// </summary>
    public partial class Lesson1Page : Page
    {
        public Lesson1Page()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Lenovo\source\repos\TutorialMDK\TutorialMDK\Document\lesson1.txt");
            this.txtTextLesson.Text = sr.ReadToEnd();
        }
    }
}

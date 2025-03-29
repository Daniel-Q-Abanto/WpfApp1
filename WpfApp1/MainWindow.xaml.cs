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

namespace WpfApp1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Profesor> alumnos = new List<Profesor>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Profesor> profesores = new List<Profesor>();
            profesores.Add(new Profesor { Apellidos = "Quispe", Nombres="Daniel"});
            profesores.Add(new Profesor { Apellidos = "Quispe", Nombres = "Daniel" });

            dgProfesores.ItemsSource = profesores;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<Curso> cursos = new List<Curso>();
            cursos.Add(new Curso { NombreCurso = "Java", DescripcionCurso = "Curso de programacion", DocenteCurso = "Daniel" });
            cursos.Add(new Curso { NombreCurso = "Python", DescripcionCurso = "Curso de programacion", DocenteCurso = "Sebastian" });
            dgCurso.ItemsSource = cursos;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
           
            
            alumnos.Add(new Profesor { Nombres= txtNombres.Text, Apellidos=txtApellidos.Text});
            dgAlumnos.ItemsSource = null;
            dgAlumnos.ItemsSource = alumnos;

        }
    }
}

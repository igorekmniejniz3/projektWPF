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

namespace IgorWojcik10._05
{
    /// <summary>
    /// Logika interakcji dla klasy BookDetailsWindow.xaml
    /// </summary>
    public partial class BookDetailsWindow : Window
    {
        public BookDetailsWindow()
        {
            InitializeComponent();
        }

        public void DisplayBookDetails(Ksiazka book)
        {
            TitleTextBox.Text = book.Tytul;
            AuthorTextBox.Text = book.Autor;
            YearTextBox.Text = book.RokWydania.ToString();
            GenreTextBox.Text = book.Gatunek;
        }
    }
}

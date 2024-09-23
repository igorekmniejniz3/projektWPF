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
    public partial class AddBookWindow : Window
    {
        public event EventHandler<Ksiazka> BookAdded;

        public AddBookWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ksiazka = new Ksiazka
            {
                Tytul = txtTytul.Text,
                Autor = txtAutor.Text,
                RokWydania = int.TryParse(txtRokWydania.Text, out int rok) ? rok : 0,
                Gatunek = txtGatunek.Text
            };

            BookAdded?.Invoke(this, ksiazka);
            Close();
        }
        public Ksiazka ExistingBook { get; set; }

        public AddBookWindow(Ksiazka book = null)
        {
            InitializeComponent();
            ExistingBook = book;

            if (ExistingBook != null)
            {
                txtTytul.Text = ExistingBook.Tytul;
                txtAutor.Text = ExistingBook.Autor;
                txtRokWydania.Text = ExistingBook.RokWydania.ToString();
                txtGatunek.Text = ExistingBook.Gatunek;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            if (ExistingBook == null)
            {
                ExistingBook = new Ksiazka(); 
            }

            txtTytul.Text = ExistingBook.Tytul;
            txtAutor.Text = ExistingBook.Autor;
            txtRokWydania.Text = ExistingBook.RokWydania.ToString();
            txtGatunek.Text = ExistingBook.Gatunek;

            DialogResult = true;
        }
    }
}

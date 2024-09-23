using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IgorWojcik10._05
{
    public class Ksiazka
    {
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public int RokWydania { get; set; }
        public string Gatunek { get; set; }
    }
    public partial class MainWindow : Window
    {
        public ObservableCollection<Ksiazka> Ksiazki { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Ksiazki = new ObservableCollection<Ksiazka>();
            dataGridKsiazki.ItemsSource = Ksiazki;

            Ksiazki.Add(new Ksiazka { Tytul = "Pan Tadeusz", Autor = "Adam Mickiewicz", RokWydania = 1834, Gatunek = "Epopeja" });
            Ksiazki.Add(new Ksiazka { Tytul = "Lalka", Autor = "Bolesław Prus", RokWydania = 1890, Gatunek = "Powieść" });
        }

        private void MenuItem_Zamknij_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Dodaj_Click(object sender, RoutedEventArgs e)
        {
            var addBookWindow = new AddBookWindow();
            addBookWindow.BookAdded += (s, a) => Ksiazki.Add(a);
            addBookWindow.ShowDialog();
        }

        private void MenuItem_Usun_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridKsiazki.SelectedItem is Ksiazka selectedBook)
            {
                Ksiazki.Remove(selectedBook);
            }
        }
        private void DataGridKsiazki_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dataGridKsiazki.SelectedItem is Ksiazka selectedBook)
            {
                var editBookWindow = new AddBookWindow(selectedBook);
                if (editBookWindow.ShowDialog() == true)
                {
                    dataGridKsiazki.Items.Refresh();
                }
            }
        }
        private void FilterTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (FilterTextBox.Text == "Filtruj po tytule...")
            {
                FilterTextBox.Text = "";
            }
        }

        private void FilterTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FilterTextBox.Text))
            {
                FilterTextBox.Text = "Filtruj po tytule...";
            }
        }
        private void FilterTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string filterText = FilterTextBox.Text.ToLower();

            dataGridKsiazki.ItemsSource = Ksiazki.Where(k => k.Tytul.ToLower().Contains(filterText)
                                                        || k.Autor.ToLower().Contains(filterText)
                                                        || k.Gatunek.ToLower().Contains(filterText)).ToList();
        }
        private void DataGridKsiazki_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            var editedCellContent = e.EditingElement as TextBox;
            if (editedCellContent != null)
            {
                var editedBook = (Ksiazka)dataGridKsiazki.SelectedItem;
                switch (e.Column.Header.ToString())
                {
                    case "Tytuł":
                        editedBook.Tytul = editedCellContent.Text;
                        break;
                    case "Autor":
                        editedBook.Autor = editedCellContent.Text;
                        break;
                    case "Rok Wydania":
                        int rokWydania;
                        if (int.TryParse(editedCellContent.Text, out rokWydania))
                        {
                            editedBook.RokWydania = rokWydania;
                        }
                        break;
                    case "Gatunek":
                        editedBook.Gatunek = editedCellContent.Text;
                        break;
                    default:
                        break;
                }
            }
        }
        private void ShowBookDetails_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridKsiazki.SelectedItem is Ksiazka selectedBook)
            {
                var detailsWindow = new BookDetailsWindow();
                detailsWindow.DisplayBookDetails(selectedBook);
                detailsWindow.Show();
            }
        }

    }
}

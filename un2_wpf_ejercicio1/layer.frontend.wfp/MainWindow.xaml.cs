using System.Collections.Generic;
using System.IO;
using System.Linq;
using layer.backend.fakeRepository.Reader.Files;
using System.Windows;
using layer.backend.fakeRepository.Contracts;

namespace layer.frontend.wfp
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

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            LoadPathAndLoadFiles();
        }

        #region Metodos locales

        void LoadPathAndLoadFiles()
        {
            IFileReaderable objLoader = null;

            if (!string.IsNullOrEmpty(txtPath.Text))
            {
                objLoader = new FileReader();

                BindFilesInGrid(objLoader.
                    GetAllFilesFromPath(txtPath.Text));
            }

            
        }

        void BindFilesInGrid(IEnumerable<FileInfo> files )
        {
            if (object.ReferenceEquals(files, null))
            {
                //Mensaje al usuario.
            }
            else
            {
                if (files.Any())
                { 
                    //gvFiles.ItemsSource = files.ToList()
                    //    .Select(x=> x.FullName).ToList();

                    var auxList = files.ToList()
                        .Select(x => x.FullName).ToList();

                    //foreach (var item in files.ToList())
                    //{
                    //    //gvFiles.Items.Add(item);
                    //    dataGrid.Items.Add(item.Name);
                        
                    //}

                    dataGrid.ItemsSource = auxList;

                    //gvFiles.ItemsSource = auxList;
                }
                else
                {
                    //Mensaje al usuario.
                }
            }

            
        }

        #endregion

    }
}

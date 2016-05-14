
using atr.app.layer.backend.dto.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using atr.app.layer.backend.domain.Contracts;
using atr.app.layer.backend.domain.Source;

namespace atr.app.layer.front.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IEnumerable<LogDto> _LogsCollectionsDto = null;

        public MainWindow()
        {
            InitializeComponent();
        }


        #region Client Side Functions

        /// <summary>
        /// ATR: Habilita o deshabilita los controles requeridos para continuar, ante acciones inválidas.
        /// por parte del usuario. 
        /// </summary>
        /// <param name="IsEnabled"></param>
        void DisabledMainButtons(bool IsEnabled)
        {
            btnCleanNewSession.IsEnabled = IsEnabled;
            btnStarAnalysis.IsEnabled    = IsEnabled;
            chkError.IsEnabled           = IsEnabled;
            chkInfo.IsEnabled            = IsEnabled;
            chkWarn.IsEnabled            = IsEnabled;
        }

        /// <summary>
        /// ATR_ Carga, de acuerdo al path ingresado por pantalla, los archivos de logs requeridos.
        /// para analizar. 
        /// </summary>
        void LoadSource()
        {
            IDataLoaderable objLoader = null;

            if (string.IsNullOrEmpty(txtSource.Text) || string.Equals(txtSource.Text, "Select source", StringComparison.InvariantCulture))
            {
                MessageBox.Show("Seleccione una fuenta de datos válida.", "Error", MessageBoxButton.OK);
                txtSource.Text = string.Empty;
            }
            else
            {
                objLoader           = new DataLoader();
                _LogsCollectionsDto = objLoader.LoadAllData(txtSource.Text);

            }
               
        }







        #endregion


        #region Client Side Events

        private void btnStarAnalysis_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCleanNewSession_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            LoadSource();

            if (!object.ReferenceEquals(_LogsCollectionsDto, null))
            {
                if (!_LogsCollectionsDto.Any())
                {
                    MessageBox.Show("No se han detectado archivos logs validos.", "Error", MessageBoxButton.OK);
                    DisabledMainButtons(false);
                }
                else
                {
                    MessageBox.Show($"Archivos cargados exitosamente. {_LogsCollectionsDto.Count()} archivos encontrados.", "Info", MessageBoxButton.OK);
                    DisabledMainButtons(true);
                }

            }
            else
            {
                MessageBox.Show($"Formato de path no reconocido: {txtSource.Text}", "Error", MessageBoxButton.OK);
                DisabledMainButtons(false);

            }

        }

        #endregion

    }
}

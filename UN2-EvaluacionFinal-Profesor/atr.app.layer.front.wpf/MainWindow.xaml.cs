
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
        private IEnumerable<LogDto> _logsCollectionsDto = null;
        private AnalysisOptionsDto _analysisOptionsDto  = null;


        public MainWindow()
        {
            InitializeComponent();
            _analysisOptionsDto = new AnalysisOptionsDto();
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
            _analysisOptionsDto          = new AnalysisOptionsDto();

            chkError.IsChecked           = false;
            chkInfo.IsChecked = false;
            chkWarn.IsChecked = false;
        }

        /// <summary>
        /// ATR: Carga, en un grid, los archivos de logs encontrados.
        /// </summary>
        void BindLogFilesFinded()
        {
            gvLogsFilesFinded.ItemsSource = _logsCollectionsDto;
            
        }

        /// <summary>
        /// ATR: Valida, que para ejecutar el análisis, al menos una opción haya sido seleccionada por el usuario. 
        /// </summary>
        /// <returns></returns>
        bool CheckIfOneOptionIsEnabled()
        {
            return (bool) (chkWarn.IsChecked) || ((bool) (chkError.IsChecked)) || ((bool) (chkInfo.IsChecked));
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
                _logsCollectionsDto = objLoader.LoadAllData(txtSource.Text);

            }
               
        }


        void RunAnalysis()
        {
            
        }


        #endregion


        #region Client Side Events

        private void btnStarAnalysis_Click(object sender, RoutedEventArgs e)
        {
            if (!CheckIfOneOptionIsEnabled())
            {
                MessageBox.Show("Al menos una opción de análisis debe ser seleccionada.", "Error", MessageBoxButton.OK);
            }
            else
            {
                RunAnalysis();
            }

        }

        private void btnCleanNewSession_Click(object sender, RoutedEventArgs e)
        {
            DisabledMainButtons(false);

            txtSource.Text                = string.Empty;
            gvLogsFilesFinded.ItemsSource = null;
            gvAnalysisInside.ItemsSource  = null;
            _logsCollectionsDto           = null;

            chkError.IsChecked            = false;
            chkInfo.IsChecked             = false;
            chkWarn.IsChecked             = false;

        }
        private void chkError_Checked(object sender, RoutedEventArgs e)
        {
            _analysisOptionsDto.IsErrorAnalysisEnabled   = (bool) chkError.IsChecked;
            
        }

        private void chkWarn_Checked(object sender, RoutedEventArgs e)
        {
            _analysisOptionsDto.IsWarningAnalysisEnabled = (bool)chkWarn.IsChecked;
        }

        private void chkInfo_Checked(object sender, RoutedEventArgs e)
        {
            _analysisOptionsDto.IsInfoAnalysisEnabled = (bool)chkInfo.IsChecked;
        }

        private void btnLoadData_Click(object sender, RoutedEventArgs e)
        {
            LoadSource();

            if (!object.ReferenceEquals(_logsCollectionsDto, null))
            {
                if (!_logsCollectionsDto.Any())
                {
                    MessageBox.Show("No se han detectado archivos logs validos.", "Error", MessageBoxButton.OK);
                    DisabledMainButtons(false);
                }
                else
                {
                    MessageBox.Show($"Archivos cargados exitosamente. {_logsCollectionsDto.Count()} archivos encontrados.", "Info", MessageBoxButton.OK);
                    DisabledMainButtons(true);
                    BindLogFilesFinded();
                }

            }
            else
            {
                if (!string.IsNullOrEmpty(txtSource.Text))
                {
                    MessageBox.Show($"Formato de path no reconocido: {txtSource.Text}", "Error", MessageBoxButton.OK);
                }

                DisabledMainButtons(false);

            }

        }

        #endregion

        
    }
}

using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System;

namespace Partition_Model
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            DataContext = new MainViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void OnCalculateClick(object sender, RoutedEventArgs e)
        {
            var viewModel = (MainViewModel)DataContext;

            double lungShunt = viewModel.LungShunt;
            double lungMass = viewModel.LungMass;
            double liverVolume = viewModel.LiverVolume;
            double tnRatio = viewModel.TnRatio;
            double tumorVolume = viewModel.TumorVolume;
            double tumorDose = viewModel.TumorDose;

            //double doseActivity =  Math.Round(((((tnRatio * tumorVolume) + liverVolume) / (1 - (lungShunt / 100))) / 49670), 3);
            double doseActivity =  Math.Round(((tumorDose * tumorVolume * (tumorVolume * tnRatio + liverVolume) * 100) / (49.7 * tumorVolume * tnRatio * (100 - lungShunt)) / 1000), 3);
            viewModel.DoseActivity = doseActivity;
        }
    }
}
using System.Windows;

namespace PrintChart {

    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }

        private void button_ShowPrintPreview(object sender, RoutedEventArgs e) {
            chartControl1.ShowPrintPreview(this);
        }

        private void button_Print_Click(object sender, RoutedEventArgs e) {
            chartControl1.Print();
        }
    }
}

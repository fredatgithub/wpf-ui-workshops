using System.Windows;

namespace UIWorkshops.Demos.Windows
{
  /// <summary>
  /// Interaction logic for HoldSubmitButtonDemoWindow.xaml
  /// </summary>
  public partial class HoldSubmitButtonDemoWindow : Window
  {
    public HoldSubmitButtonDemoWindow()
    {
      InitializeComponent();
    }

    private void HoldSubmitButton_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Thanks for holding me.");
    }
  }
}

namespace  SA;
using System.Windows;
using System.Windows.Input;

public partial class WindowMain : Window {

    public WindowMain() {
        InitializeComponent();
        toggle.MouseDown += (_, _) => checkBox.IsChecked = !checkBox.IsChecked.Value;
        CommandBindings.Add(new CommandBinding(
            ApplicationCommands.Save,
            (_, _) => { },
            (_, eventArgs) => { eventArgs.CanExecute = checkBox.IsChecked == true; }));
    } //WindowMain

} //class WindowMain

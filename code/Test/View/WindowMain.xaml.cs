namespace  SA;

using System.Windows;
using System.Windows.Input;

public partial class WindowMain : Window {

    public WindowMain() {
        InitializeComponent();
        checkBox.IsThreeState = false;
            CommandBindings.Add(new CommandBinding(
            ApplicationCommands.Save,
            (_, _) => { },
            (_, eventArgs) => { eventArgs.CanExecute = checkBox.IsChecked == true; }));
        AddCommandBindings();
    } //WindowMain

    } //class WindowMain

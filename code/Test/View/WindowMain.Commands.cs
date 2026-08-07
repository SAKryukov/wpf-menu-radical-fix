namespace SA;
using System.Windows.Input;
public partial class WindowMain {

    void AddCommandBindings() {

        CommandBindings.Add(new CommandBinding(
            ApplicationCommands.PrintPreview,
            (_, _) => ShowDocumentation(DefinitionSet.Help),
            (_, eventArgs) => { eventArgs.CanExecute = true; }));
;
        CommandBindings.Add(new CommandBinding(
            ApplicationCommands.Help,
            (_, _) => ShowDocumentation(DefinitionSet.Repository),
            (_, eventArgs) => { eventArgs.CanExecute = true; }));

        CommandBindings.Add(new CommandBinding(
            ApplicationCommands.Close,
            (_, _) => Close(),
            (_, eventArgs) => { eventArgs.CanExecute = true; }));

    } //AddCommandBindings

    static void ShowDocumentation(string uri) =>
        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo {
            FileName = uri,
            UseShellExecute = true
        });        

} //class WindowMain

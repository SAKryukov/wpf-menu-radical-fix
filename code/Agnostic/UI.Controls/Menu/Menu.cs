namespace SA.Agnostic.UI.Controls;
using DependencyProperty = System.Windows.DependencyProperty;

public class Menu : System.Windows.Controls.Menu {

    public Menu() {
        this.Resources.MergedDictionaries.Add(MenuResourceHost.Instance.Resources);
        Nicety = Nicety.Initialize();
    } //Menu

    public static readonly DependencyProperty NicetyProperty = Nicety.RegisterDependencyProperty<Menu>();
    public Nicety Nicety {
        get => (Nicety)GetValue(NicetyProperty);
        set => SetValue(NicetyProperty, value);
    } //Nicety
    
} //Menu

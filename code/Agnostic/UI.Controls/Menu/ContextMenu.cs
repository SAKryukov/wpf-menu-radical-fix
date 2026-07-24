namespace SA.Agnostic.UI.Controls;
using DependencyProperty = System.Windows.DependencyProperty;

public class ContextMenu : System.Windows.Controls.ContextMenu {

    public ContextMenu() {
        this.Resources.MergedDictionaries.Add(MenuResourceHost.Instance.Resources);
        Nicety = Nicety.Initialize();
    } //ContextMenu

    public static readonly DependencyProperty NicetyProperty = Nicety.RegisterDependencyProperty<ContextMenu>();
    public Nicety Nicety {
        get => (Nicety)GetValue(NicetyProperty);
        set => SetValue(NicetyProperty, value);
    } //Nicety

    public static bool IsContextMenu { get => true; }
    
} //ContextMenu

namespace SA.Agnostic.UI.Controls;

public class Menu : System.Windows.Controls.Menu {

    public Menu() {
        Nicety = Nicety.Initialize();
        Resources.MergedDictionaries.Add(MenuResourceHost.Instance.Resources);
    } //Menu

    public Nicety Nicety {
        get => (Nicety)GetValue(Nicety.MenuNicetyProperty);
        set => SetValue(Nicety.MenuNicetyProperty, value);
    } //Nicety

    public static bool IsContextMenu { get => false; }
    
} //Menu

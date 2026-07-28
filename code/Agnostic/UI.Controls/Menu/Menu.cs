namespace SA.Agnostic.UI.Controls;

public class Menu : System.Windows.Controls.Menu {

    public Menu() {
        Nicety = Nicety.Initialize();
        Resources.MergedDictionaries.Add(MenuResourceHost.Instance.Resources);
    } //Menu

    public Nicety Nicety { set => SetValue(Nicety.MenuNicetyProperty, value); }
    public static bool IsContextMenu { get => false; }
    
} //Menu

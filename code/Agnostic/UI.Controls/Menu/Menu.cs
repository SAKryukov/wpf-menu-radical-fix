namespace SA.Agnostic.UI.Controls;

public class Menu : System.Windows.Controls.Menu {
    public Menu() =>
        Nicety = Nicety.ResouceInitializer<Menu>.Setup(this);
    public Nicety Nicety { set => SetValue(Nicety.MenuNicetyProperty, value); }
    public static bool IsContextMenu { get => false; }   
} //Menu

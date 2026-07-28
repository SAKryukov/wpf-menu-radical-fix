namespace SA.Agnostic.UI.Controls;

public class Menu : System.Windows.Controls.Menu {
<<<<<<< HEAD
    public Menu() =>
        Nicety = Nicety.ResouceInitializer<Menu>.Setup(this);
    public Nicety Nicety { set => SetValue(Nicety.MenuNicetyProperty, value); }
    public static bool IsContextMenu { get => false; }  
=======

    public Menu() {
        Nicety = Nicety.Initialize();
        Resources.MergedDictionaries.Add(MenuResourceHost.Instance.Resources);
    } //Menu

    public Nicety Nicety { set => SetValue(Nicety.MenuNicetyProperty, value); }
    public static bool IsContextMenu { get => false; }
    
>>>>>>> 6626abca9b7f4f0002f175868e7a0bc4a0300453
} //Menu

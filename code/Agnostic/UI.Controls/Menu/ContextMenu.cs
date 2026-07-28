namespace SA.Agnostic.UI.Controls;

public class ContextMenu : System.Windows.Controls.ContextMenu {
<<<<<<< HEAD
    public ContextMenu() =>
        Nicety = Nicety.ResouceInitializer<ContextMenu>.Setup(this);
    public Nicety Nicety { set => SetValue(Nicety.ContextMenuNicetyProperty, value); }
    public static bool IsContextMenu { get => true; }   
=======

    public ContextMenu() {
        Nicety = Nicety.Initialize();
        this.Resources.MergedDictionaries.Add(MenuResourceHost.Instance.Resources);
    } //ContextMenu

    public Nicety Nicety { set => SetValue(Nicety.ContextMenuNicetyProperty, value); }
    public static bool IsContextMenu { get => true; }
    
>>>>>>> 6626abca9b7f4f0002f175868e7a0bc4a0300453
} //ContextMenu

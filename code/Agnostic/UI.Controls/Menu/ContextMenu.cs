namespace SA.Agnostic.UI.Controls;

public class ContextMenu : System.Windows.Controls.ContextMenu {
    public ContextMenu() =>
        Nicety = Nicety.ResouceInitializer<ContextMenu>.Setup(this);
    public Nicety Nicety { set => SetValue(Nicety.ContextMenuNicetyProperty, value); }
    public static bool IsContextMenu { get => true; }   
} //ContextMenu

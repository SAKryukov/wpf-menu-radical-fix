namespace SA.Agnostic.UI.Controls;

public class ContextMenu : System.Windows.Controls.ContextMenu {

    public ContextMenu() {
        Nicety = Nicety.Initialize();
        this.Resources.MergedDictionaries.Add(MenuResourceHost.Instance.Resources);
    } //ContextMenu

    public Nicety Nicety { set => SetValue(Nicety.ContextMenuNicetyProperty, value); }
    public static bool IsContextMenu { get => true; }
    
} //ContextMenu

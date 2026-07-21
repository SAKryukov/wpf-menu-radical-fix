namespace SA.Agnostic.UI.Controls;

public partial class MenuResourceHost : Markup.ResourceHost {

    public MenuResourceHost() {
        InitializeComponent();
    } //MenuResourceHost

    internal readonly static MenuResourceHost Instance = new();
    
} //class MenuResourceHost
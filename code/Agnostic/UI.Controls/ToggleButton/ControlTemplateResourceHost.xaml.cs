namespace SA.Agnostic.UI.Controls;

public partial class ControlTemplateResourceHost : Markup.ResourceHost {

    public ControlTemplateResourceHost() {
        InitializeComponent();
    } //MenuResourceHost

    internal readonly static MenuResourceHost Instance = new();
    
} //class ControlTemplateResourceHost
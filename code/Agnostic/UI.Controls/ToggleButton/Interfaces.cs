namespace SA.Agnostic.UI.Controls;

interface IToggleButton {
    System.Windows.Controls.Viewbox Viewbox { get; }
    System.Windows.Shapes.Shape Frame { get; }
    System.Windows.Shapes.Shape TrueElement { get; }
    System.Windows.Shapes.Shape NullElement { get; }
} //IToggleButton

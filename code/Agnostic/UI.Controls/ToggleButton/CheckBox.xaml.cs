namespace SA.Agnostic.UI.Controls;
using Shape = System.Windows.Shapes.Shape;
using Viewbox = System.Windows.Controls.Viewbox;

public partial class GraphicalCheckBox : Viewbox, IToggleButton {
    
    public GraphicalCheckBox() => InitializeComponent();

    Viewbox IToggleButton.Viewbox { get => this; }
    Shape IToggleButton.Frame { get => frame; }
    Shape IToggleButton.TrueElement { get => isCheckedBool; }
    Shape IToggleButton.NullElement { get => isCheckedNull; }

} //class GraphicalCheckBox

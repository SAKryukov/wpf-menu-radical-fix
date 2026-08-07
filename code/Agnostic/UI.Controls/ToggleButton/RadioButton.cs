namespace SA.Agnostic.UI.Controls;
using Viewbox = System.Windows.Controls.Viewbox;
using Brush = System.Windows.Media.Brush;
using VerticalAlignment = System.Windows.VerticalAlignment;

public class RadioButton : System.Windows.Controls.RadioButton {
    
    public RadioButton() {
        IToggleButton implementation = new GraphicalRadioButton();
        Viewbox = implementation.Viewbox;
        ToggleButton toggleButton = new (this, implementation);
        toggleButton.Setup();
        VerticalAlignmentBox = VerticalAlignment.Center;
        VerticalAlignmentContent = VerticalAlignment.Center;
    } //RadioButton

    public Brush BackgroundNormal { set { SetValue(ToggleButton.BackgroundNormalProperty, value); } }
    public Brush BackgroundDisabled { set { SetValue(ToggleButton.BackgroundDisabledProperty, value); } }
    public Brush Frame { set { SetValue(ToggleButton.FrameProperty, value); } }
    public Brush FrameDisabled { set { SetValue(ToggleButton.FrameDisabledProperty, value); } }
    public Brush TrueValue { set { SetValue(ToggleButton.TrueValueProperty, value); } }
    public Brush TrueValueDisabled { set { SetValue(ToggleButton.TrueValueDisabledProperty, value); } }
    public Brush NullValue { set { SetValue(ToggleButton.NullValueProperty, value); } }
    public Brush NullValueDisabled { set { SetValue(ToggleButton.NullValueProperty, value); } }  
    public VerticalAlignment VerticalAlignmentBox {
        get { return (VerticalAlignment)GetValue(ToggleButton.VerticalAlignmentBoxProperty); }
        set { SetValue(ToggleButton.VerticalAlignmentBoxProperty, value); }
    } //VerticalAlignmentBox
    public VerticalAlignment VerticalAlignmentContent {
        get { return (VerticalAlignment)GetValue(ToggleButton.VerticalAlignmentContentProperty); }
        set { SetValue(ToggleButton.VerticalAlignmentContentProperty, value); }
    } //VerticalAlignmentContent
    
    public Viewbox Viewbox { get; init; }

} //class RadioButton

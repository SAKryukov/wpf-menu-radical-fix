namespace SA.Agnostic.UI.Controls;
using ToggleButtonElement = System.Windows.Controls.Primitives.ToggleButton;
using Brush = System.Windows.Media.Brush;
using DependencyProperty = System.Windows.DependencyProperty;
using VerticalAlignment = System.Windows.VerticalAlignment;

class ToggleButton { 
    
    internal ToggleButton(ToggleButtonElement element, IToggleButton toggleButton) {
        this.element = element;
        this.toggleButton = toggleButton;
    } //ToggleButton

    internal void Setup() {
        element.Template = new ControlTemplateResourceHost().GetObject<System.Windows.Controls.ControlTemplate>();        
        element.IsEnabledChanged += (_, _) => ChangeVisual();
        element.Checked += (_, _) => ChangeVisual();
        element.Unchecked += (_, _) => ChangeVisual();
        element.Indeterminate += (_, _) => ChangeVisual();
        ChangeVisual();
    } //Setup

    void ChangeVisual() {
        Brush trueElementBrush = element.IsEnabled
            ? GetBrush(TrueValueProperty) ?? DefinitionSet.Foreground
            : GetBrush(TrueValueDisabledProperty) ?? DefinitionSet.ForegroundDisabled;
        Brush nullElementBrush = element.IsEnabled
            ? GetBrush(NullValueProperty) ?? DefinitionSet.Foreground
            : GetBrush(NullValueDisabledProperty) ?? DefinitionSet.ForegroundDisabled;
        toggleButton.Frame.Fill = element.IsEnabled
            ? GetBrush(BackgroundNormalProperty) ?? DefinitionSet.Background
            : GetBrush(BackgroundDisabledProperty) ?? DefinitionSet.BackgroundDisabled;
        toggleButton.Frame.Stroke = element.IsEnabled
            ? GetBrush(FrameProperty) ?? DefinitionSet.Foreground
            : GetBrush(FrameDisabledProperty) ?? DefinitionSet.ForegroundDisabled;
        toggleButton.TrueElement.Fill = element.IsChecked == true
            ? trueElementBrush
            : DefinitionSet.Hidden;
        if (element.IsChecked == null) {
            toggleButton.NullElement.Fill = nullElementBrush;
            toggleButton.NullElement.Stroke = nullElementBrush;            
        } else {
            toggleButton.NullElement.Fill = DefinitionSet.Hidden;
            toggleButton.NullElement.Stroke = DefinitionSet.Hidden;    
        } //if
    } //ChangeVisual

    static DependencyProperty RegisterVerticalAlignmentProperty(string name) {
        DependencyProperty property = DependencyProperty.Register(name, typeof(VerticalAlignment), typeof(CheckBox));
        property.AddOwner(typeof(RadioButton));
        return property;
    } //RegisterVirticalAlignmentProperty
    static DependencyProperty RegisterBrushProperty(string name) {
        DependencyProperty property = DependencyProperty.Register(name, typeof(Brush), typeof(CheckBox));
        property.AddOwner(typeof(RadioButton));
        return property;
    } //RegisterBrushProperty
    Brush GetBrush(DependencyProperty property) => (Brush)element.GetValue(property);

    public static DependencyProperty BackgroundNormalProperty = RegisterBrushProperty(nameof(CheckBox.BackgroundNormal));
    public static DependencyProperty BackgroundDisabledProperty = RegisterBrushProperty(nameof(CheckBox.BackgroundDisabled));
    public static DependencyProperty FrameProperty = RegisterBrushProperty(nameof(CheckBox.Frame));
    public static DependencyProperty FrameDisabledProperty = RegisterBrushProperty(nameof(CheckBox.FrameDisabled));
    public static DependencyProperty TrueValueProperty = RegisterBrushProperty(nameof(CheckBox.TrueValue));
    public static DependencyProperty TrueValueDisabledProperty = RegisterBrushProperty(nameof(CheckBox.TrueValueDisabled));
    public static DependencyProperty NullValueProperty = RegisterBrushProperty(nameof(CheckBox.NullValue));
    public static DependencyProperty NullValueDisabledProperty = RegisterBrushProperty(nameof(CheckBox.NullValueDisabled));
    public static DependencyProperty VerticalAlignmentBoxProperty = RegisterVerticalAlignmentProperty(nameof(CheckBox.VerticalAlignmentBox));
    public static DependencyProperty VerticalAlignmentContentProperty = RegisterVerticalAlignmentProperty(nameof(CheckBox.VerticalAlignmentContent));
    
    readonly ToggleButtonElement element;
    readonly IToggleButton toggleButton;

} //class ToggleButton

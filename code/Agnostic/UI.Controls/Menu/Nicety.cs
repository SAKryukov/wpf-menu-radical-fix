namespace SA.Agnostic.UI.Controls;
using DependencyObject = System.Windows.DependencyObject;
using DependencyProperty = System.Windows.DependencyProperty;
using PropertyMetadata = System.Windows.PropertyMetadata;
using Brush = System.Windows.Media.Brush;
using Thickness = System.Windows.Thickness;
using HorizontalAlignment = System.Windows.HorizontalAlignment;
using VerticalAlignment = System.Windows.VerticalAlignment;

public class Nicety : DependencyObject {

    public static readonly DependencyProperty LineBrushProperty =
        RegisterBrushProperty(nameof(LineBrush));
    public Brush LineBrush {
        get => (Brush)GetValue(LineBrushProperty);
        set => SetValue(LineBrushProperty, value);
    } //LineBrush

    public static readonly DependencyProperty BorderThicknessProperty =
        RegisterThicknessProperty(nameof(BorderThickness));
    public Thickness BorderThickness {
        get => (Thickness)GetValue(BorderThicknessProperty);
        set => SetValue(BorderThicknessProperty, value);
    } //BorderThickness

    public static readonly DependencyProperty CornerRadiusProperty =
        RegisterSizeProperty(nameof(CornerRadius));
    public double CornerRadius {
        get => (double)GetValue(CornerRadiusProperty);
        set => SetValue(CornerRadiusProperty, value);
    } //CornerRadius

    public static readonly DependencyProperty SeparatorThicknessProperty =
        RegisterSizeProperty(nameof(SeparatorThickness));
    public double SeparatorThickness {
        get => (double)GetValue(SeparatorThicknessProperty);
        set => SetValue(SeparatorThicknessProperty, value);
    } //SeparatorThickness

    public static readonly DependencyProperty SeparatorMarginProperty =
        RegisterThicknessProperty(nameof(SeparatorMargin));
    public Thickness SeparatorMargin {
        get => (Thickness)GetValue(SeparatorMarginProperty);
        set => SetValue(SeparatorMarginProperty, value);
    } //SeparatorMarginProperty

    public static readonly DependencyProperty IconAlignmentHorizontalProperty =
        RegisterProperty(nameof(IconAlignmentHorizontal), typeof(HorizontalAlignment));
    public HorizontalAlignment IconAlignmentHorizontal {
        get => (HorizontalAlignment)GetValue(IconAlignmentHorizontalProperty);
        set => SetValue(IconAlignmentHorizontalProperty, value);
    } //IconAlignmentHorizontal

    public static readonly DependencyProperty IconAlignmentVerticalProperty =
        RegisterProperty(nameof(IconAlignmentVertical), typeof(VerticalAlignment));
    public VerticalAlignment IconAlignmentVertical {
        get => (VerticalAlignment)GetValue(IconAlignmentVerticalProperty);
        set => SetValue(IconAlignmentVerticalProperty, value);
    } //IconAlignmentVertical

    public static readonly DependencyProperty BackgroundNormalProperty =
        RegisterBrushProperty(nameof(BackgroundNormal));
    public Brush BackgroundNormal {
        get => (Brush)GetValue(BackgroundNormalProperty);
        set => SetValue(BackgroundNormalProperty, value);
    } //BackgroundNormal

    public static readonly DependencyProperty BackgroundHighlightProperty =
        RegisterBrushProperty(nameof(BackgroundHighlight));
    public Brush BackgroundHighlight {
        get => (Brush)GetValue(BackgroundHighlightProperty);
        set => SetValue(BackgroundHighlightProperty, value);
    } //BackgroundHighlight

    public static readonly DependencyProperty ForegroundIconNormalProperty =
        RegisterBrushProperty(nameof(ForegroundIconNormal));
    public Brush ForegroundIconNormal {
        get => (Brush)GetValue(ForegroundIconNormalProperty);
        set => SetValue(ForegroundIconNormalProperty, value);
    } //ForegroundIconNormal

    public static readonly DependencyProperty ForegroundIconHighlightProperty =
        RegisterBrushProperty(nameof(ForegroundIconHighlight));
    public Brush ForegroundIconHighlight {
        get => (Brush)GetValue(ForegroundIconHighlightProperty);
        set => SetValue(ForegroundIconHighlightProperty, value);
    } //ForegroundIconHighlight

    public static readonly DependencyProperty ForegroundIconDisabledProperty =
        RegisterBrushProperty(nameof(ForegroundIconDisabled));
    public Brush ForegroundIconDisabled {
        get => (Brush)GetValue(ForegroundIconDisabledProperty);
        set => SetValue(ForegroundIconDisabledProperty, value);
    } //ForegroundIconDisabled

    public static readonly DependencyProperty ForegroundHeaderNormalProperty =
        RegisterBrushProperty(nameof(ForegroundHeaderNormal));
    public Brush ForegroundHeaderNormal {
        get => (Brush)GetValue(ForegroundHeaderNormalProperty);
        set => SetValue(ForegroundHeaderNormalProperty, value);
    } //ForegroundHeaderNormal

    public static readonly DependencyProperty ForegroundHeaderHighlightProperty =
        RegisterBrushProperty(nameof(ForegroundHeaderHighlight));
    public Brush ForegroundHeaderHighlight {
        get => (Brush)GetValue(ForegroundHeaderHighlightProperty);
        set => SetValue(ForegroundHeaderHighlightProperty, value);
    } //ForegroundHeaderHighlight

    public static readonly DependencyProperty ForegroundHeaderDisabledProperty =
        RegisterBrushProperty(nameof(ForegroundHeaderDisabled));
    public Brush ForegroundHeaderDisabled {
        get => (Brush)GetValue(ForegroundHeaderDisabledProperty);
        set => SetValue(ForegroundHeaderDisabledProperty, value);
    } //ForegroundHeaderDisabled

    public static readonly DependencyProperty ForegroundGestureNormalProperty =
        RegisterBrushProperty(nameof(ForegroundGestureNormal));
    public Brush ForegroundGestureNormal {
        get => (Brush)GetValue(ForegroundGestureNormalProperty);
        set => SetValue(ForegroundGestureNormalProperty, value);
    } //ForegroundGestureNormal

    public static readonly DependencyProperty ForegroundGestureHighlightProperty =
        RegisterBrushProperty(nameof(ForegroundGestureHighlight));
    public Brush ForegroundGestureHighlight {
        get => (Brush)GetValue(ForegroundGestureHighlightProperty);
        set => SetValue(ForegroundGestureHighlightProperty, value);
    } //ForegroundGestureHighlight

    public static readonly DependencyProperty ForegroundGestureDisabledProperty =
        RegisterBrushProperty(nameof(ForegroundGestureDisabled));
    public Brush ForegroundGestureDisabled {
        get => (Brush)GetValue(ForegroundGestureDisabledProperty);
        set => SetValue(ForegroundGestureDisabledProperty, value);
    } //ForegroundGestureDisabled

    public static readonly DependencyProperty MarginIconProperty =
        RegisterThicknessProperty(nameof(MarginIcon));
    public Thickness MarginIcon {
        get => (Thickness)GetValue(MarginIconProperty);
        set => SetValue(MarginIconProperty, value);
    } //MarginIcon

    public static readonly DependencyProperty MarginHeaderProperty =
        RegisterThicknessProperty(nameof(MarginHeader));
    public Thickness MarginHeader {
        get => (Thickness)GetValue(MarginHeaderProperty);
        set => SetValue(MarginHeaderProperty, value);
    } //MarginHeader

    public static readonly DependencyProperty MarginGestureProperty =
        RegisterThicknessProperty(nameof(MarginGesture));
    public Thickness MarginGesture {
        get => (Thickness)GetValue(MarginGestureProperty);
        set => SetValue(MarginGestureProperty, value);
    } //MarginGesture

    static DependencyProperty RegisterProperty(string name, System.Type propertyType) =>
        DependencyProperty.Register(name, propertyType, typeof(Nicety));      
    static DependencyProperty RegisterBrushProperty(string name) =>
        RegisterProperty(name, typeof(Brush));
    static DependencyProperty RegisterThicknessProperty(string name) =>
        RegisterProperty(name, typeof(Thickness));
    static DependencyProperty RegisterSizeProperty(string name) =>
        RegisterProperty(name, typeof(double));
    static void OverrideProperty(DependencyProperty property, object value) {
        property.OverrideMetadata(typeof(Nicety), new PropertyMetadata(defaultValue: value));
    } //OverrideProperty

    internal static DependencyProperty RegisterDependencyProperty<TARGET>() =>
        DependencyProperty.Register(nameof(Nicety), typeof(Nicety), typeof(TARGET));

    internal static Nicety Initialize() {
        if (isDefault) return new Nicety();
        DefaultSet defaultSet = MenuResourceHost.Instance.GetObject<DefaultSet>();
        OverrideProperty(LineBrushProperty, defaultSet.LineBrush);
        OverrideProperty(BorderThicknessProperty, defaultSet.BorderThickness);
        OverrideProperty(CornerRadiusProperty, defaultSet.CornerRadius);
        OverrideProperty(SeparatorThicknessProperty, defaultSet.SeparatorThickness);
        OverrideProperty(SeparatorMarginProperty, defaultSet.SeparatorMargin);
        // icon alignment:
        OverrideProperty(IconAlignmentHorizontalProperty, defaultSet.IconAlignment.Horizontal);
        OverrideProperty(IconAlignmentVerticalProperty, defaultSet.IconAlignment.Vertical);
        // background:
        OverrideProperty(BackgroundNormalProperty, defaultSet.Background.Normal);
        OverrideProperty(BackgroundHighlightProperty, defaultSet.Background.Highlight);
        // foreground icon:
        OverrideProperty(ForegroundIconNormalProperty, defaultSet.Foreground.Icon.Normal); 
        OverrideProperty(ForegroundIconHighlightProperty, defaultSet.Foreground.Icon.Highlight); 
        OverrideProperty(ForegroundIconDisabledProperty, defaultSet.Foreground.Icon.Disabled); 
        // foreground header:
        OverrideProperty(ForegroundHeaderNormalProperty, defaultSet.Foreground.Header.Normal); 
        OverrideProperty(ForegroundHeaderHighlightProperty, defaultSet.Foreground.Header.Highlight); 
        OverrideProperty(ForegroundHeaderDisabledProperty, defaultSet.Foreground.Header.Disabled); 
        // foreground gesture:
        OverrideProperty(ForegroundGestureNormalProperty, defaultSet.Foreground.Gesture.Normal); 
        OverrideProperty(ForegroundGestureHighlightProperty, defaultSet.Foreground.Gesture.Highlight); 
        OverrideProperty(ForegroundGestureDisabledProperty, defaultSet.Foreground.Gesture.Disabled); 
        // horizontal margins:
        OverrideProperty(MarginIconProperty, defaultSet.Margin.Icon); 
        OverrideProperty(MarginHeaderProperty, defaultSet.Margin.Header); 
        OverrideProperty(MarginGestureProperty, defaultSet.Margin.Gesture); 
        isDefault = true;
        return new Nicety();
    } //Initialize
    static bool isDefault = false;

} //class Nicety

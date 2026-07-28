namespace SA.Agnostic.UI.Controls;
using DependencyObject = System.Windows.DependencyObject;
using DependencyProperty = System.Windows.DependencyProperty;
using PropertyMetadata = System.Windows.PropertyMetadata;
using Brush = System.Windows.Media.Brush;
using Thickness = System.Windows.Thickness;
using HorizontalAlignment = System.Windows.HorizontalAlignment;
using VerticalAlignment = System.Windows.VerticalAlignment;
using MenuBase = System.Windows.Controls.Primitives.MenuBase;

public class Nicety : DependencyObject {

    public Nicety() : this (MenuResourceHost.Instance.GetObject<DefaultSet>()) { }
    Nicety(DefaultSet defaultSet) {
        SeparatorMargin = new Thickness(0, defaultSet.SeparatorVerticalGap, 0, defaultSet.SeparatorVerticalGap);        
    } //Nicety

    public static readonly DependencyProperty LineBrushProperty =
        RegisterBrushProperty(nameof(LineBrush));
    public Brush LineBrush {
        set => SetValue(LineBrushProperty, value);
    } //LineBrush

    public static readonly DependencyProperty BorderThicknessProperty =
        RegisterThicknessProperty(nameof(BorderThickness));
    public Thickness BorderThickness {
        set => SetValue(BorderThicknessProperty, value);
    } //BorderThickness

    public static readonly DependencyProperty CornerRadiusProperty =
        RegisterSizeProperty(nameof(CornerRadius));
    public double CornerRadius {
        set => SetValue(CornerRadiusProperty, value);
    } //CornerRadius

    public static readonly DependencyProperty SeparatorThicknessProperty =
        RegisterSizeProperty(nameof(SeparatorThickness));
    public double SeparatorThickness {
        set => SetValue(SeparatorThicknessProperty, value);
    } //SeparatorThickness

    public static readonly DependencyProperty SeparatorVerticalGapProperty =
        RegisterSizeProperty(nameof(SeparatorVerticalGap));
    public double SeparatorVerticalGap {
        set => SetValue(SeparatorVerticalGapProperty, value);
    } //SeparatorVerticalGap
    public Thickness SeparatorMargin { get; set; }

    public static readonly DependencyProperty IconAlignmentHorizontalProperty =
        RegisterProperty(nameof(IconAlignmentHorizontal), typeof(HorizontalAlignment));
    public HorizontalAlignment IconAlignmentHorizontal {
        set => SetValue(IconAlignmentHorizontalProperty, value);
    } //IconAlignmentHorizontal

    public static readonly DependencyProperty IconAlignmentVerticalProperty =
        RegisterProperty(nameof(IconAlignmentVertical), typeof(VerticalAlignment));
    public VerticalAlignment IconAlignmentVertical {
        set => SetValue(IconAlignmentVerticalProperty, value);
    } //IconAlignmentVertical

    public static readonly DependencyProperty BackgroundNormalProperty =
        RegisterBrushProperty(nameof(BackgroundNormal));
    public Brush BackgroundNormal {
        set => SetValue(BackgroundNormalProperty, value);
    } //BackgroundNormal

    public static readonly DependencyProperty BackgroundHighlightProperty =
        RegisterBrushProperty(nameof(BackgroundHighlight));
    public Brush BackgroundHighlight {
        set => SetValue(BackgroundHighlightProperty, value);
    } //BackgroundHighlight

    public static readonly DependencyProperty ForegroundIconNormalProperty =
        RegisterBrushProperty(nameof(ForegroundIconNormal));
    public Brush ForegroundIconNormal {
        set => SetValue(ForegroundIconNormalProperty, value);
    } //ForegroundIconNormal

    public static readonly DependencyProperty ForegroundIconHighlightProperty =
        RegisterBrushProperty(nameof(ForegroundIconHighlight));
    public Brush ForegroundIconHighlight {
        set => SetValue(ForegroundIconHighlightProperty, value);
    } //ForegroundIconHighlight

    public static readonly DependencyProperty ForegroundIconDisabledProperty =
        RegisterBrushProperty(nameof(ForegroundIconDisabled));
    public Brush ForegroundIconDisabled {
        set => SetValue(ForegroundIconDisabledProperty, value);
    } //ForegroundIconDisabled

    public static readonly DependencyProperty ForegroundHeaderNormalProperty =
        RegisterBrushProperty(nameof(ForegroundHeaderNormal));
    public Brush ForegroundHeaderNormal {
        set => SetValue(ForegroundHeaderNormalProperty, value);
    } //ForegroundHeaderNormal

    public static readonly DependencyProperty ForegroundHeaderHighlightProperty =
        RegisterBrushProperty(nameof(ForegroundHeaderHighlight));
    public Brush ForegroundHeaderHighlight {
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
        set => SetValue(ForegroundGestureNormalProperty, value);
    } //ForegroundGestureNormal

    public static readonly DependencyProperty ForegroundGestureHighlightProperty =
        RegisterBrushProperty(nameof(ForegroundGestureHighlight));
    public Brush ForegroundGestureHighlight {
        set => SetValue(ForegroundGestureHighlightProperty, value);
    } //ForegroundGestureHighlight

    public static readonly DependencyProperty ForegroundGestureDisabledProperty =
        RegisterBrushProperty(nameof(ForegroundGestureDisabled));
    public Brush ForegroundGestureDisabled {
        set => SetValue(ForegroundGestureDisabledProperty, value);
    } //ForegroundGestureDisabled

    public static readonly DependencyProperty MarginIconProperty =
        RegisterThicknessProperty(nameof(MarginIcon));
    public Thickness MarginIcon {
        set => SetValue(MarginIconProperty, value);
    } //MarginIcon

    public static readonly DependencyProperty MarginHeaderProperty =
        RegisterThicknessProperty(nameof(MarginHeader));
    public Thickness MarginHeader {
        set => SetValue(MarginHeaderProperty, value);
    } //MarginHeader

    public static readonly DependencyProperty MarginGestureProperty =
        RegisterThicknessProperty(nameof(MarginGesture));
    public Thickness MarginGesture {
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

    static DependencyProperty RegisterDependencyProperty<TARGET>() =>
        DependencyProperty.Register(nameof(Nicety), typeof(Nicety), typeof(TARGET));
    readonly static DependencyProperty menuNicetyProperty = RegisterDependencyProperty<Menu>();
    readonly static DependencyProperty contextMenuNicetyProperty = RegisterDependencyProperty<ContextMenu>();
    internal static DependencyProperty MenuNicetyProperty { get => menuNicetyProperty; }
    internal static DependencyProperty ContextMenuNicetyProperty { get => contextMenuNicetyProperty; }

    static Nicety Initialize() {
        DefaultSet defaultSet = MenuResourceHost.Instance.GetObject<DefaultSet>();
        if (isDefault) return new Nicety(defaultSet);
        OverrideProperty(LineBrushProperty, defaultSet.LineBrush);
        OverrideProperty(BorderThicknessProperty, defaultSet.BorderThickness);
        OverrideProperty(CornerRadiusProperty, defaultSet.CornerRadius);
        OverrideProperty(SeparatorThicknessProperty, defaultSet.SeparatorThickness);
        SeparatorVerticalGapProperty.OverrideMetadata(
            typeof(Nicety),
            new PropertyMetadata(
                defaultValue: defaultSet.SeparatorVerticalGap,
                propertyChangedCallback: (instance, eventArgs) => {
                    double newValue = (double)eventArgs.NewValue;
                    Nicety nicetyInstance = (Nicety)instance;
                    nicetyInstance.SeparatorMargin = new(0, newValue, 0, newValue);
                }));
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
        return new Nicety(defaultSet);
    } //Initialize
    static bool isDefault = false;

    internal static class ResouceInitializer<MENU> where MENU: MenuBase {
        internal static Nicety Setup(MENU menu) {
            Nicety nicety = Initialize();
            menu.Resources.MergedDictionaries.Add(MenuResourceHost.Instance.Resources);
            return nicety;
        } //Setup
    } //ResouceInitializer

} //class Nicety

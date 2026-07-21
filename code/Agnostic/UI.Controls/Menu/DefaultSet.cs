namespace SA.Agnostic.UI.Controls;
using Brush = System.Windows.Media.Brush;
using Thickness = System.Windows.Thickness;
using HorizontalAlignment = System.Windows.HorizontalAlignment;
using VerticalAlignment = System.Windows.VerticalAlignment;

public class DefaultSet {
    public Brush LineBrush { get; set; }
    public Thickness BorderThickness { get; set; }
    public double CornerRadius { get; set; }
    public double SeparatorThickness { get; set; }
    public Thickness SeparatorMargin { get; set; }
    public IconAlignment IconAlignment { get; set; }
    public Background Background { get; set; }
    public Foreground Foreground { get; set; }
    public Margin Margin { get; set; }
} //DefaultSet

public class IconAlignment {
    public HorizontalAlignment Horizontal { get; set; }
    public VerticalAlignment Vertical { get; set; }
} //IconAlignment

public class Background {
    public Brush Normal { get; set; }
    public Brush Highlight { get; set; }
} //Background

public class ElementForeground {
    public Brush Normal { get; set; }
    public Brush Highlight { get; set; }
    public Brush Disabled { get; set; }
} //class ElementForeground

public class Foreground {
    public ElementForeground Icon { get; set; }
    public ElementForeground Header { get; set; }
    public ElementForeground Gesture { get; set; }
} //class Foreground

public class Margin {
    public Thickness Icon { get; set; }
    public Thickness Header { get; set; }
    public Thickness Gesture { get; set; }   
} //class Margin

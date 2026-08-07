namespace SA.Agnostic.UI.Controls;
using ItemsControl = System.Windows.Controls.ItemsControl;
using RoutedEventArgs = System.Windows.RoutedEventArgs;
using DependencyProperty = System.Windows.DependencyProperty;

public class RadioMenuItem : System.Windows.Controls.MenuItem {
    
    public RadioMenuItem() {
        IsCheckable = true; 
    } //RadioMenuItem
    
    protected override void OnClick() {
        IsCheckable = true; // important: for the case the user makes it false
        base.OnClick();
    } //OnClick

    protected override void OnChecked(RoutedEventArgs e) {
        base.OnChecked(e);
        if (Parent is ItemsControl parent)
            foreach (var element in parent.Items) {
                if (element == this) continue;
                if (element is RadioMenuItem peer)
                    if (Equals(RadioMenuItemGroup, peer.RadioMenuItemGroup))
                        peer.IsChecked = false;
            } //loop
    } //OnChecked

    public static bool IsRadio { get => true; }
    public readonly static DependencyProperty RadioMenuItemGroupProperty =
        DependencyProperty.Register(nameof(RadioMenuItemGroup), typeof(object), typeof(RadioMenuItem));
    public object RadioMenuItemGroup {
        get { return GetValue(RadioMenuItemGroupProperty); }
        set { SetValue(RadioMenuItemGroupProperty, value); }
    } //RadioMenuItemGroup

} //RadioMenuItem

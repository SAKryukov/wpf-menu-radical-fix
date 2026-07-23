# WPF Menu Radical Fix

Replaces WPF `System.Windows.Controls.Menu` and `System.Windows.Controls.ContextMenu` and fixes long-standing issues:

* Icons are no longer clipped, no matter what their sizes are.
* Therefore, font glyphs can be used for icons.
* Icon area is no longer shown when there are no icons.
* No more ugly gutter in the icon area.
* Separators are controllable. Now they span the entire width of a vertical menu or a submenu by default.
* All essential stylistic properties on the menu inner content are exposed, so there is no need to write menu templates.

<!-- for a trivial commit, to wake up Actions -->

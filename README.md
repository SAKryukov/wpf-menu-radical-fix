# WPF Menu Radical Fix

![Menu](https://sakryukov.github.io/wpf-menu-radical-fix/result.webp)
[Help](https://sakryukov.github.io/wpf-menu-radical-fix/help.html)
[Pre-built demo](https://github.com/SAKryukov/wpf-menu-radical-fix/releases/download/latest-build/Sanitized-menu.full-build.zip)

Replaces WPF `System.Windows.Controls.Menu` and `System.Windows.Controls.ContextMenu` and fixes long-standing issues:

* Icons are no longer clipped, no matter what their sizes are.
* Therefore, font glyphs can be used for icons.
* Icon area is no longer shown when there are no icons.
* No more ugly gutter in the icon area.
* Separators are controllable. Now they span the entire width of a vertical menu or a submenu by default.
* All essential stylistic properties on the menu inner content are exposed, so there is no need to write menu templates.

Additionally implemented and seriously corrected:
* `CheckBox`
* `RadioButton`

***A new feature is the innovative*** `RadioMenuItem`. Radio items are grouped using `RadioMenuItemGroup` property of type `System.Object`. This way, the groups can be bound to the framework elements.

[Detailed help](https://sakryukov.github.io/wpf-menu-radical-fix/help.html)

Usage demo: [Pre-built code sample](https://github.com/SAKryukov/wpf-menu-radical-fix/releases/download/latest-build/Sanitized-menu.full-build.zip)
<br><small>(All prebuilt executables are built on the GitHub server and are safe.)</small>

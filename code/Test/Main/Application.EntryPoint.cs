namespace SA {
    using System;
    using System.Windows;

    static class TestStart {
        [STAThread]
        static void Main() {
            Application app = new Agnostic.UI.AdvancedApplication<WindowMain>() {};
            app.Run();
        } //MainClass
    } //class TestStart

}

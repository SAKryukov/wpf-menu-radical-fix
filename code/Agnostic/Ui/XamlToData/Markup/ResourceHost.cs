namespace SA.Agnostic.UI.Markup {
using System.Windows;

    public class ResourceHost : Freezable {

        public ResourceHost() => Resources = [];

        public static readonly DependencyProperty ResourcesProperty =
            DependencyProperty.Register(
                nameof(Resources), 
                typeof(ResourceDictionary), 
                typeof(ResourceHost));       
        public ResourceDictionary Resources {
            get => (ResourceDictionary)GetValue(ResourcesProperty);
            set => SetValue(ResourcesProperty, value);
        } //Resources

        protected override Freezable CreateInstanceCore() => new ResourceHost();

        public REQUIRED GetObject<REQUIRED>()
            where REQUIRED : new() =>
                (REQUIRED)Resources?[typeof(REQUIRED)];

    } //class ResourceHost

}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Tizen.NUI.Xaml.XamlResourceIdAttribute("SliderProgressTutorial.Scene1Page.xaml", "Scene1Page.xaml", typeof(global::SliderProgressTutorial.Scene1Page))]

namespace SliderProgressTutorial {
    
    
    [Tizen.NUI.Xaml.XamlFilePathAttribute("Scene1Page.xaml")]
    [Tizen.NUI.Xaml.XamlCompilationAttribute(global::Tizen.NUI.Xaml.XamlCompilationOptions.Compile)]
    public partial class Scene1Page : global::Tizen.NUI.BaseComponents.View {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.27.0")]
        public global::Tizen.NUI.BaseComponents.TextLabel SliderText;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.27.0")]
        public global::Tizen.NUI.Components.Slider Slider1;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.27.0")]
        public global::Tizen.NUI.BaseComponents.TextLabel ValueText;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.27.0")]
        public global::Tizen.NUI.BaseComponents.TextLabel ProgressText;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.27.0")]
        public global::Tizen.NUI.Components.Progress Progress1;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.27.0")]
        public global::Tizen.NUI.BaseComponents.TextLabel TimerText;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.27.0")]
        private void InitializeComponent() {
            global::Tizen.NUI.EXaml.EXamlExtensions.LoadFromEXamlByRelativePath(this, GetEXamlPath());
            SliderText = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.BaseComponents.TextLabel>(this, "SliderText");
            Slider1 = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.Components.Slider>(this, "Slider1");
            ValueText = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.BaseComponents.TextLabel>(this, "ValueText");
            ProgressText = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.BaseComponents.TextLabel>(this, "ProgressText");
            Progress1 = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.Components.Progress>(this, "Progress1");
            TimerText = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.BaseComponents.TextLabel>(this, "TimerText");
        }
        
        private string GetEXamlPath() {
            return default(string);
        }
    }
}

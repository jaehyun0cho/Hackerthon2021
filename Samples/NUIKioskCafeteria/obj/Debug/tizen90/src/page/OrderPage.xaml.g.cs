//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Tizen.NUI.Xaml.XamlResourceIdAttribute("NUIKioskCafeteria.src.page.OrderPage.xaml", "src/page/OrderPage.xaml", typeof(global::NUIKioskCafeteria.OrderPage))]

namespace NUIKioskCafeteria {
    
    
    [Tizen.NUI.Xaml.XamlFilePathAttribute("src\\page\\OrderPage.xaml")]
    [Tizen.NUI.Xaml.XamlCompilationAttribute(global::Tizen.NUI.Xaml.XamlCompilationOptions.Compile)]
    public partial class OrderPage : global::NUIKioskCafeteria.ContentControlPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.27.0")]
        public global::Tizen.NUI.BaseComponents.View CollectionLayoutView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.27.0")]
        public global::Tizen.NUI.BaseComponents.TextLabel totalPrice;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.27.0")]
        private void InitializeComponent() {
            global::Tizen.NUI.EXaml.EXamlExtensions.LoadFromEXamlByRelativePath(this, GetEXamlPath());
            CollectionLayoutView = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.BaseComponents.View>(this, "CollectionLayoutView");
            totalPrice = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.BaseComponents.TextLabel>(this, "totalPrice");
        }
        
        private string GetEXamlPath() {
            return default(string);
        }
    }
}

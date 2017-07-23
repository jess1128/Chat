using Chat.Mobile.Standard.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.Mobile.Standard.Services
{
    public sealed class ViewModelLocator
    {
        private static readonly Lazy<ViewModelLocator> _instance = new Lazy<ViewModelLocator>(() => new ViewModelLocator());

        private readonly Dictionary<Type, ViewModel> _Models = new Dictionary<Type, ViewModel>();

        public static void Add<TViewModel>(TViewModel viewModel) where TViewModel : ViewModel
            => _instance.Value._Models[typeof(TViewModel)] = viewModel;
        public static bool ModelExists<TViewModel>() where TViewModel : ViewModel
            => Resolve<TViewModel>() != null;
        public static TViewModel Resolve<TViewModel>() where TViewModel : ViewModel
            => (_instance.Value._Models.TryGetValue(typeof(TViewModel), out ViewModel viewModel)) ? (TViewModel)viewModel : null;
    }
}

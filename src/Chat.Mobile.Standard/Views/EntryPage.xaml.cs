using Chat.Mobile.Standard.Services;
using Chat.Mobile.Standard.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Chat.Mobile.Standard.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EntryPage : ContentPage
	{
		public EntryPage ()
		{
            if (!ViewModelLocator.ModelExists<EntryPageViewModel>())
                ViewModelLocator.Add(new EntryPageViewModel());
            
			InitializeComponent();

            BindingContext = ViewModelLocator.Resolve<EntryPageViewModel>();
        }
	}
}
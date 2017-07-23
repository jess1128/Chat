using Chat.Mobile.Standard.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat.Mobile.Standard.ViewModels
{
    public class ViewModel : ObservableObject
    {
        private bool _IsBusy;
        public bool IsBusy { get => _IsBusy; set { _IsBusy = value; PropertyChange(); } }
    }
}

using Prism.Events;
using Prism.Mvvm;
using PrismStudy.Core;
using System.Windows;

namespace PrismStudy.ViewModels
{
    public class MainViewModel : BindableBase
    {
        IEventAggregator _eventAggregator;

        // Field
        WindowState _windowState;
        // Properties
        public WindowState WindowState { get => _windowState; set => SetProperty(ref _windowState, value); }

        public MainViewModel(IEventAggregator eventAggregator)
        {
            WindowState = WindowState.Maximized;

            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<SentEvent>().Subscribe(OnWindowMinimum);
        }

        private void OnWindowMinimum(object obj)
        {
            WindowState = WindowState.Minimized;
        }
    }
}

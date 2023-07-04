using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using PrismStudy.Core;

namespace PrismStudy.Modlues.TitleBar.ViewModels
{
    class TitleBarViewModel : BindableBase
    {
        private IEventAggregator _eventAggregator;
        public DelegateCommand WindowMinimum { get; set; }
        public TitleBarViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            WindowMinimum = new DelegateCommand(OnWindowMinimum);
        }

        private void OnWindowMinimum()
        {
            _eventAggregator.GetEvent<SentEvent>().Publish(null);
        }
    }
}

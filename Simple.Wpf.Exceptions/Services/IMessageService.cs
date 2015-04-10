using System;
using Simple.Wpf.Exceptions.ViewModels;

namespace Simple.Wpf.Exceptions.Services
{
    public interface IMessageService
    {
        IObservable<MessageViewModel> Show { get; }

        void Post(string header, CloseableViewModel viewModel, IDisposable lifetime);
    }
}
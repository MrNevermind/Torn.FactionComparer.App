using System;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Torn.FactionComparer.App.Base
{
    public interface IAsyncCommand : ICommand
    {
        Task ExecuteAsync(object parameter);
    }
    public class AsyncCommand : AsyncCommandBase
    {
        private readonly Func<Task> _command;
        public AsyncCommand(Func<Task> command)
        {
            _command = command;
        }
        public override bool CanExecute(object parameter)
        {
            return true;
        }
        public override Task ExecuteAsync(object parameter)
        {
            return _command();
        }
    }
}

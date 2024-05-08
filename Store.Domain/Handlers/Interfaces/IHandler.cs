using Store.Domain.Commands.Interfaces;

namespace Store.Domain.Handlers.Interfaces
{
    // Responsável por gerenciar os fluxos da aplicação
    internal interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}

namespace API.Actions.v1.CommandHandlers
{
    //Command
    public class GetAllActionsCommand : IRequest<ICollection<Action>>
    {
        public ICollection<Action> Actions { get; set; }
    }

    //Command Handler
    public class GetAllActionsCommandHandler : IRequestHandler<GetAllActionsCommand, ICollection<Action>>
    {
        public Task<ICollection<Action>> Handle(GetAllActionsCommand request, CancellationToken cancellationToken)
        {
            return new List<Action>();
        }
    }
}

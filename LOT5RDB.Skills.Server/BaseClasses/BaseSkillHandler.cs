using LOT5RDB.Skills.Shared.Interfaces;
using MediatR;

namespace LOT5RDB.Skills.Server.BaseClasses;

public abstract class BaseSkillHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    internal readonly ISkillRepository SkillRepository;
    protected BaseSkillHandler(ISkillRepository skillRepository)
    {
        SkillRepository = skillRepository;
    }
    
    public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
}
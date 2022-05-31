using LOT5RDB.Skills.Shared.Interfaces;
using MediatR;

namespace LOT5RDB.Skills.Server.BaseClasses;

public abstract class BaseSkillGroupHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    internal readonly ISkillGroupRepository SkillGroupRepository;
    protected BaseSkillGroupHandler(ISkillGroupRepository skillGroupRepository)
    {
        SkillGroupRepository = skillGroupRepository;
    }

    public abstract Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken);
}

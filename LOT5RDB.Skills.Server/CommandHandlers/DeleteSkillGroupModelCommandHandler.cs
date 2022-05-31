using LOT5RDB.Skills.Server.BaseClasses;
using LOT5RDB.Skills.Shared.Commands;
using LOT5RDB.Skills.Shared.Interfaces;
using MediatR;

namespace LOT5RDB.Skills.Server.CommandHandlers;

public class DeleteSkillGroupModelCommandHandler : BaseSkillGroupHandler<DeleteSkillCommand, int>
{

    public DeleteSkillGroupModelCommandHandler(ISkillGroupRepository skillGroupRepository) : base(skillGroupRepository)
    {
    }

    public override async Task<int> Handle(DeleteSkillCommand request, CancellationToken cancellationToken) =>
        await SkillGroupRepository.Delete(request.Id);
}

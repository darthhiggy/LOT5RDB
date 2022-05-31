using LOT5RDB.Skills.Server.BaseClasses;
using LOT5RDB.Skills.Shared.Commands;
using LOT5RDB.Skills.Shared.Interfaces;

namespace LOT5RDB.Skills.Server.CommandHandlers;

public class DeleteSkillCommandHandler : BaseSkillHandler<DeleteSkillCommand, int>
{

    public DeleteSkillCommandHandler(ISkillRepository skillRepository) : base(skillRepository)
    {
    }

    public override async Task<int> Handle(DeleteSkillCommand request, CancellationToken cancellationToken) =>
        await SkillRepository.Delete(request.Id);
}

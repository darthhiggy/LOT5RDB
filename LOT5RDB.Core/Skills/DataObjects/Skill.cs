using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOT5RDB.Core.Skills.DataObjects
{
    public class Skill
    {
        public Skill()
        {
            Id = 0;
        }
        public Skill(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int SkillGroupId { get; set; } = 0;
        public SkillGroup SkillGroup { get; set; } = new SkillGroup();
    }
}

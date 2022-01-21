using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOT5RDB.Core.Skills.DataObjects
{
    public class SkillGroup
    {
        public SkillGroup()
        {
            Id = 0;
        }

        public SkillGroup(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public List<Skill> Skills { get; set; } = new List<Skill>();
    }
}

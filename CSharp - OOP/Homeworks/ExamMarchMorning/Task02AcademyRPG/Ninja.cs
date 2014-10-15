using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyRPG
{
    class Ninja : Character, IFighter, IGatherer
    {
        private int attackPoints;

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            private set
            {
                this.attackPoints = value;
            }
        }

        public int DefensePoints
        {
            get
            {
                return int.MaxValue;
            }
        }

        public Ninja(string name, Point position, int owner) : base(name,position,owner)
        {
            this.HitPoints = 1;
            this.AttackPoints = 0;
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            var highestPoints = availableTargets.Max(item => item.HitPoints);
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].HitPoints == highestPoints && availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints += resource.Quantity;
                return true;
            }
            if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints += resource.Quantity * 2;
                return true;
            }
            return false;
        }
    }
}
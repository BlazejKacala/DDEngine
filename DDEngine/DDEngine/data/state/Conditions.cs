using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDEngine.data.properties
{
    public enum Condition
    {
        Blinded, Charmed, Deafened, Frightened, Grappled, Incapacitated, Unconscious, Invisible, Paralyzed, Petrified, Poisoned, Prone, Restrained, Stunned
    }

    public class Conditions
    {
        private readonly List<Condition> conditions = new List<Condition>();

        public void AddCondition(Condition condition)
        {
            if(!conditions.Contains(condition))
            {
                conditions.Add(condition);
            }
        }

        public bool HasCondition(Condition condition)
        {
            return conditions.Contains(condition);
        }

        public void ClearConditions()
        {
            conditions.Clear();
        }

        public bool CanTakeAction()
        {
            return !(conditions.Contains(Condition.Incapacitated) ||
                conditions.Contains(Condition.Unconscious) ||
                conditions.Contains(Condition.Paralyzed) ||
                conditions.Contains(Condition.Petrified) ||
                conditions.Contains(Condition.Stunned));
        }

        public bool IsBlinded()
        {
            return conditions.Contains(Condition.Blinded);
        }

        public bool IsCharmed()
        {
            return conditions.Contains(Condition.Charmed);
        }

        public bool IsDeafened()
        {
            return conditions.Contains(Condition.Deafened);
        }

        public bool IsFrightened()
        {
            return conditions.Contains(Condition.Frightened);
        }

        public bool IsGrappled()
        {
            return conditions.Contains(Condition.Grappled);
        }

        public bool IsIncapacitated()
        {
            return conditions.Contains(Condition.Incapacitated);
        }

        public bool IsUnconscious()
        {
            return conditions.Contains(Condition.Unconscious);
        }

        public bool IsInvisible()
        {
            return conditions.Contains(Condition.Invisible);
        }

        public bool IsParalyzeded()
        {
            return conditions.Contains(Condition.Paralyzed);
        }

        public bool IsPetrified()
        {
            return conditions.Contains(Condition.Petrified);
        }

        public bool IsPoisoned()
        {
            return conditions.Contains(Condition.Poisoned);
        }

        public bool IsProne()
        {
            return conditions.Contains(Condition.Prone);
        }

        public bool IsRestrained()
        {
            return conditions.Contains(Condition.Restrained);
        }

        public bool IsStunned()
        {
            return conditions.Contains(Condition.Stunned);
        }
    }
}

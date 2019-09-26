using System;
namespace DDEngine.engine.action.spells
{
    public abstract class Spell : IAction
    {
        public abstract SpellLvl Lvl();

        public abstract SpellType SpellType();

        public abstract bool IsVerbal();

        public abstract bool IsSomatic();

        public abstract void Execute();
    }
}

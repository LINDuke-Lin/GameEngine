using GameEngine.Lib.Helpers;
using GameEngine.Lib.Models.Dtos;
using GameEngine.Lib.Occupations.Interfaces;

namespace GameEngine.Lib.Occupations
{
    internal class Tank : Occupation
    {
        /// <summary>
        /// 職業名稱
        /// </summary>
        public override string OccupationName => "坦克";
        /// <summary>
        /// 能力值
        /// </summary>
        /// <param name="abilityDto">輸入角色能力值</param>
        /// <returns>計算過後的角色能力值</returns>
        public override AbilityDto Ability(AbilityDto ability)
        {
            ability.Accuracy = ability.Accuracy.AbilityRatio(0.8);
            ability.Health = ability.Health.AbilityRatio(2);
            ability.Luck = ability.Luck.AbilityRatio(2);
            ability.Agility = ability.Agility.AbilityRatio(1.5);
            return ability;
        }

        /// <summary>
        /// 特殊技能
        /// </summary>
        public abstract AbilityDto Skills(Func<AbilityDto> Abilityfunc, AbilityDto ability)
        {
            throw new NotImplementedException();
        }
    }
}

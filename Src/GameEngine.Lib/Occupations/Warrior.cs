using GameEngine.Lib.Helpers;
using GameEngine.Lib.Models.Dtos;
using GameEngine.Lib.Occupations.Interfaces;

namespace GameEngine.Lib.Occupations
{
    internal class Warrior : Occupation
    {
        /// <summary>
        /// 職業名稱
        /// </summary>
        public override string OccupationName => "戰士";

        /// <summary>
        /// 能力值
        /// </summary>
        /// <param name="abilityDto">輸入角色能力值</param>
        /// <returns>計算過後的角色能力值</returns>
        public override AbilityDto Ability(AbilityDto ability)
        {
            ability.Attack = ability.Attack.AbilityRatio(1.5);
            ability.ActionPoint = ability.ActionPoint.AbilityRatio(1.5);
            ability.Health = ability.Health.AbilityRatio(1.5);
            return ability;
        }
        /// <summary>
        /// 特殊技能
        /// </summary>
        public override AbilityDto Skills(Func<AbilityDto> Abilityfunc, AbilityDto ability)
        {
            throw new NotImplementedException();
        }
    }
}

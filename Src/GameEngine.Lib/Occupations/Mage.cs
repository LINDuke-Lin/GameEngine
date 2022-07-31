using GameEngine.Lib.Helpers;
using GameEngine.Lib.Models.Dtos;
using GameEngine.Lib.Occupations.Interfaces;

namespace GameEngine.Lib.Occupations
{
    internal class Mage : Occupation
    {
        /// <summary>
        /// 職業名稱
        /// </summary>
        public override string OccupationName => "法師";

        /// <summary>
        /// 能力值
        /// </summary>
        /// <param name="abilityDto">輸入角色能力值</param>
        /// <returns>計算過後的角色能力值</returns>
        public override AbilityDto Ability(AbilityDto ability)
        {
            ability.Intelligence = ability.Intelligence.AbilityRatio(1.5);
            ability.Magic = ability.Magic.AbilityRatio(1.5);
            ability.Health = ability.Health.AbilityRatio(0.8);
            ability.Mattack = ability.Mattack.AbilityRatio(2);
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

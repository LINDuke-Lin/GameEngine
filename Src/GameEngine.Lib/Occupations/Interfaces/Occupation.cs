using GameEngine.Lib.Models.Dtos;

namespace GameEngine.Lib.Occupations.Interfaces
{
    public abstract class Occupation
    {
        /// <summary>
        /// 職業名稱
        /// </summary>
        public abstract string OccupationName { get; }

        /// <summary>
        /// 能力值
        /// </summary>
        /// <param name="abilityDto">輸入角色能力值</param>
        /// <returns>計算過後的角色能力值</returns>
        public abstract AbilityDto Ability(AbilityDto ability);

        /// <summary>
        /// 特殊技能
        /// </summary>
        //void Skills();
    }
}

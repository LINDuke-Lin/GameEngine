namespace GameEngine.Lib.Helpers
{
    public static class FormulaHelper
    {
        /// <summary>
        /// 能力值倍率計算
        /// </summary>
        /// <param name="input">基礎能力</param>
        /// <param name="ratio">倍率</param>
        /// <returns></returns>
        public static double AbilityRatio(this double input, double ratio)
        {
            return input * ratio;
        }
        /// <summary>
        /// 是否迴避
        /// </summary
        /// <param name="accuracy">我方命中率</param>
        /// <param name="agility">對方敏捷</param>
        /// <returns></returns>
        public static bool IsDodge(this int accuracy, int agility)
        {
            // 迴避隨機倍率參數
            Random random = new();
            int dodgeParam = random.Next(90, 100) / 100;
            int baseDodgeProb = 20; // percentage

            int dodge = agility * dodgeParam;

            // 閃避補正
            int dodComp = dodge - accuracy;
            if (dodComp < 0)
                dodComp = 0;

            if (dodComp > 100)
                dodComp = 100;

            if (random.Next(0, 100) <= (baseDodgeProb + dodComp))
                return true;

            return false;
        }
        /// <summary>
        /// 計算傷害
        /// 基本傷害 + (物傷or魔傷)
        /// </summary>
        /// <param name="Strength">基傷</param>
        /// <param name="Attack">物傷or魔傷</param>
        /// <returns></returns>
        public static int GetDamage(this double Strength, double Attack)
        {
            return Convert.ToInt32(Strength + Attack);
        }
    }
}

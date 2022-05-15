namespace WinuXGames.SplitFramework.Utility
{
    public class MathUtility
    {
        /// <summary>
        /// A modulo function that works with negative numbers
        /// Regular % mod is still faster so only use this for negative numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a mod b</returns>
        public static int Mod(int a, int b) => (a % b + b) % b;
    }
}
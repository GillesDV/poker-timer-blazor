namespace PokerTimer.Domain.Constants
{
    // Normally Domain would be a separate project, but since this is a very small project, it's included here.
    public static class BlindValues
    {
        // TODO can possibly make this mathematically generated instead of statically defined.
        // Input: how many levels, how many players (+ rebuys), how long should a level / blind last
        // ref: https://www.reddit.com/r/poker/comments/u4pxrx/is_there_a_good_formula_to_calculate_a_tournament
        public static readonly int[,] AllBlinds = {
                { 100, 200 },
                { 200, 400 },
                { 300, 400 },
                { 400, 800 },
                { 500, 1_000 },
                { 600, 1_200 },
                { 1_000, 1_500 },
                { 1_000, 2_000 },
            };
    }
}

namespace PokerTimer.Domain.Constants
{
    // Normally Domain would be a separate project, but since this is a very small project, it's included here.
    public static class BlindValues
    {
        // TODO can possibly make this mathematically generated instead of statically defined.
        // Input: how many levels, how many players (+ rebuys), how long should a level / blind last
        // ref: https://www.reddit.com/r/poker/comments/u4pxrx/is_there_a_good_formula_to_calculate_a_tournament
        public static readonly int[,] AllBlinds = {
                { 500, 1_000 },
                { 1_000, 2_000 },
                { 1_500, 3_000 },
                { 2_000, 4_000 },
                { 3_000, 6_000 },
                { 4_000, 8_000 },
                { 6_000, 12_000 },
                { 8_000, 16_000 },
                { 10_000, 20_000 },
                { 15_000, 30_000 },
                { 20_000, 40_000 },
                { 30_000, 60_000 },
                { 50_000, 100_000 }
            };
    }
}

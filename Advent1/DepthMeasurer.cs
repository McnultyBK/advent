using System.Text;

namespace Depth
{
    public class DepthMeasurer
    {
        public static int GetDepthIncreases(int[] depths)
        {
            return depths.Skip(1).Zip(depths, (current, previous) => current > previous).Count(x => x == true);
        }
    }
}
using System.Collections.Generic;

namespace IterateThroughCollections
{
    public class MusicTitles
    {
        string[] names = { "Tubular Bells", "Hergest Ridge", "Ommadawn",
                       "Platinum" };

        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < 4; i++)
            {
                yield return names[i];
            }
        }

        public IEnumerable<string> Reverse()
        {
            for (int i = 3 - 1; i >= 0; i--)
            {
                yield return names[i];
            }
        }

        public IEnumerable<string> Subset(int index, int length)
        {
            for (int i = index; i < index + length; i++)
            {
                yield return names[i];
            }
        }
    }
}
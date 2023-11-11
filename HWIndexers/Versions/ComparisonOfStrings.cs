namespace HWIndexers.Versions
{
    public sealed class ComparisonOfStrings
    {

        public int CompareVersions(string first, string second)
        {
            int[] firstString = ConvertVersionStringToInts(first);
            int[] secondString = ConvertVersionStringToInts(second);

            for (int i = 0; i < firstString.Length; i++)
            {
                if (firstString[i] > secondString[i])
                {
                    return 1;
                }
                else if (secondString[i] > firstString[i])
                {
                    return -1;
                }
            }
            return 0;
        }

        private int[] ConvertVersionStringToInts(string str)
        {
            string[] strings = str.Split(".");

            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i].TrimStart('0');
            }

            int[] ints = new int[strings.Length];

            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = int.Parse(strings[i]);
            }

            return ints;
        }
    }
}

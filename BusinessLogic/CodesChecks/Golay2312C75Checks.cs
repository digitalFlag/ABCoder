namespace ABCoder.BusinessLogic.CodesChecks
{
    public static class Golay2312C75Checks
    {
        public static bool InformationPartLength(ref string s)
        {
            return s.Length == 12;
        }

        public static bool CodeWordLength(ref string s)
        {
            return s.Length == 23;
        }

        public static bool BinaryFormat(ref string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '0' && s[i] != '1')
                {
                    return false;
                }
            }
            return true;
        }

    }
}

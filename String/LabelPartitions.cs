public class Solution {
    public IList<int> PartitionLabels(string S)
        {
            int[] last = new int[26];
            for (int i = 0; i < S.Length; ++i)
                last[S[i] - 'a'] = i;

            int j = 0, anchor = 0;
            IList<int> ans = new List<int>();
            for (int i = 0; i < S.Length; ++i)
            {
                j = Math.Max(j, last[S[i] - 'a']);
                if (i == j)
                {
                    ans.Add(i - anchor + 1);
                    anchor = i + 1;
                }
            }
            return ans;
    }
}

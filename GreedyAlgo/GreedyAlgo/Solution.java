import static java.lang.Math.*;

public class Solution {
	public int solution(String s, int[] c) {
		int result = 0, i = 0, mx = 0;
		char prev = '\0';
		for (char x : s.toCharArray()) {
			if (prev != x) {
				result -= mx;
				mx = 0;
			}
			mx = max(c[i], mx);
			prev = x;
			result += c[i++];
		}
		result -= mx;
		return result;
	}

	public static void main(String[] args) {
		System.out.println(new Solution().solution("abccbd", new int[] { 0, 1, 2, 3, 4, 5 }));
		System.out.println(new Solution().solution("aabbcc", new int[] { 1,2,1,2,1,2}));
		System.out.println(new Solution().solution("aaaa", new int[] { 3,4,5,6 }));
		System.out.println(new Solution().solution("ababa", new int[] { 10,5,10,6,10 }));
		
	}

}

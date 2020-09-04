public class Solution {
    public int NumJewelsInStones(string J, string S) {
        
        
        int result = 0;
            for (int i = 0; i < J.Length; i++){
                for (int ii = 0; ii<S.Length ;ii++ ) {
                    if (J[i]==S[ii]) {
                        result += 1;
                    }
                }       
            }
            return result;
        
        
    }
}
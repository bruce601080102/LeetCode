class Solution:
    def numJewelsInStones(self, J: str, S: str) -> int:
        result=0
        for i in J:
            for ii in S:
                if i==ii:
                    result+=1
        return result
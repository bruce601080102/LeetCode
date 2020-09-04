class Solution:
    def kidsWithCandies(self, candies: List[int], extraCandies: int) -> List[bool]:
        out_result=[]
        for i in range (len(candies)) :
            copy_list = candies.copy()
            copy_list[i]=candies[i]+extraCandies
            out_result.append(copy_list[i]>=max(copy_list))
        return out_result
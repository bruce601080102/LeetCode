class Solution:
    def numIdenticalPairs(self, nums: List[int]) -> int:
        sum_result=0
        dict1={}
        for i in nums:
            if i not in dict1:
                dict1[i]=1
            else:
                dict1[i]+=1
        
        for n in dict1.values():
            if n%2==0:
                sum_result+=n*(n//2-1) +(n//2) 
            else:
                sum_result+=n*(n//2)  
        return sum_result
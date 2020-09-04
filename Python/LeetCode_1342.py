'''
Runtime: 28 ms, faster than 83.58% of Python3 online submissions for Number of Steps to Reduce a Number to Zero.
Memory Usage: 13.8 MB, less than 59.91% of Python3 online submissions for Number of Steps to Reduce a Number to Zero.
'''
class Solution:
    def numberOfSteps (self, num: int) -> int:
        
        sum_reult=1

        
        while num//2 > 0:
            if num%2==1:
                num-=1
                sum_reult+=1
            else:
                num//=2
                sum_reult+=1
        if num==0:
            sum_reult=0
        return sum_reult
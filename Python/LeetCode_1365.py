class Solution:
    def smallerNumbersThanCurrent(self, nums: List[int]) -> List[int]:
        result_list=[]
        for i in (nums):
            sum_result=0
            for ii in range(len(nums)):
                if i>nums[ii]:
                    sum_result+=1
            result_list.append(sum_result)
        return result_list
                    
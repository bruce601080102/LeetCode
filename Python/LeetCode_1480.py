class Solution:
    def runningSum(self, nums: List[int]) -> List[int]:
        len_list = len(nums)
        i=0
        sum_list=[]
        add_list=[]
        while i <len_list:
            
            sum_list.append(nums[i])
            add_list.append(sum(sum_list))
            i+=1
        return add_list
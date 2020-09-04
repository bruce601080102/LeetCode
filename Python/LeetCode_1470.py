class Solution:
    def shuffle(self, nums: List[int], n: int) -> List[int]:
        x_list=[]
        y_list=[]
        add_list=[]
        for i in range(n):
            x_list.append(nums[i])
        for ii in range(n,n*2):
            y_list.append(nums[ii])
            
        for add in range(n):
            add_list.append(x_list[add])
            add_list.append(y_list[add])
        return add_list
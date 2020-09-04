'''
Runtime: 52 ms, faster than 89.37% of Python3 online submissions for Shuffle String.
Memory Usage: 14 MB, less than 6.63% of Python3 online submissions for Shuffle String.
'''
class Solution:
    def restoreString(self, s: str, indices: List[int]) -> str:
        index_=0
        result=[]
        dirt_res={}
        for i in (s):
            dirt_res[indices[index_]]=i
            index_+=1
        for ii in (sorted(indices)):
            result.append(dirt_res[ii])
            

        return ''.join(result)
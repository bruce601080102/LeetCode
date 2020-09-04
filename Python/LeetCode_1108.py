'''
Runtime: 28 ms, faster than 83.58% of Python3 online submissions for Number of Steps to Reduce a Number to Zero.
Memory Usage: 13.8 MB, less than 59.91% of Python3 online submissions for Number of Steps to Reduce a Number to Zero.
'''
class Solution:
    def defangIPaddr(self, address: str) -> str:
        result_list=[]
        for i in (address):
            if i =='.':
                result_list.append('['+i+']')
            else:
                result_list.append(i)
                
        
        return ''.join(result_list)
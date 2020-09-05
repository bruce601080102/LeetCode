/*
Runtime: 92 ms, faster than 80.47% of JavaScript online submissions for How Many Numbers Are Smaller Than the Current Number.
Memory Usage: 38.9 MB, less than 33.85% of JavaScript online submissions for How Many Numbers Are Smaller Than the Current Number.
*/ 


let nums = [8,1,2,2,3];


var smallerNumbersThanCurrent = function(nums) {
    let result_list=[];
    for(const i of (nums)){
        sum_result=0;
        for (let ii=0;ii<nums.length;ii++){
            if(i>nums[ii]){
                sum_result+=1;
            }
        }
        result_list.push(sum_result);
    }
    return result_list
};

result = smallerNumbersThanCurrent(nums);
console.log(result);






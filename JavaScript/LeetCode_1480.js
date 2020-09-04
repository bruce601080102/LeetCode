var runningSum = function(nums) {
    var len_nums = nums.length;
    var i = 0;
    var sum_list =[];
    var add_list =[];
    while (i<len_nums){
        sum_list.push(nums[i]);
        var sum = 0
        for (var s=0;s<sum_list.length;s++){
            sum+=nums[s];
        }
        add_list.push(sum);
        i+=1;
    }

    return add_list ;    
};
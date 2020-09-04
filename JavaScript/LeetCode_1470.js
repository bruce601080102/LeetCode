/**
 * @param {number[]} nums
 * @param {number} n
 * @return {number[]}
 */
var shuffle = function(nums, n) {
       var x_list=[];
   var y_list=[];
   var add_list=[];
   for (var i=0;i<n;i++){
    x_list.push(nums[i]);
   } 
   for (var ii=n;ii<n*2;ii++){
    y_list.push(nums[ii]);
   } 
   for (var add=0;add<n;add++){
    add_list.push(x_list[add]);
    add_list.push(y_list[add]);
   }
   return add_list
};
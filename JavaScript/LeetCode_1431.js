var kidsWithCandies = function(candies, extraCandies) {
    var Copy = function(candies){
        var copy_list=[];
        for (var c=0;c<candies.length;c++){
            copy_list.push(candies[c]);
        }
        return copy_list
    }
    
    var out_result=[];
    for (var i=0;i<candies.length;i++){
            var copy_list = Copy(candies)
            copy_list[i] = candies[i]+extraCandies;
            out_result.push(copy_list[i]>= Math.max(...candies))
        }
    return out_result
};
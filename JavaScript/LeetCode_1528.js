/*
Runtime: 84 ms, faster than 81.40% of JavaScript online submissions for Shuffle String.
Memory Usage: 39.5 MB, less than 6.64% of JavaScript online submissions for Shuffle String.
*/

let s = "vttqexwqgdc";

let indices = [9,5,8,0,4,3,6,10,1,2,7];

var restoreString = function(s, indices) {
    let index=0;
    let result=[];
    let dict_res={};
    for (let i of s){
        dict_res[parseInt(indices[index])] = i;
        index+=1;
    }

    //數字大小順序 背起來
    for (let ii of indices.sort(function (a, b) {return a - b})){
        result.push(dict_res[ii]);
    }
    return result.join('');
    
};

result = restoreString(s,indices);
console.log(result);












/*
Runtime: 72 ms, faster than 90.52% of JavaScript online submissions for Number of Steps to Reduce a Number to Zero.
Memory Usage: 37.2 MB, less than 5.20% of JavaScript online submissions for Number of Steps to Reduce a Number to Zero.
*/

let num = 14;

var numberOfSteps  = function(num) {
    
    let result=1;
    while((Math.floor(num/2))>0){

        if ((num%2)==1){
            num-=1;
            result+=1;
        }
        else{
            num = Math.floor(num/2);
            result+=1;
        }       
    }
    if (num==0){
        result=0
    }
    return result
};

result = numberOfSteps(num);
console.log(result);






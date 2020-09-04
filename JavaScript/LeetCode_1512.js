var numIdenticalPairs = function(nums) {
    let dict1={};
    let sum_result=0;
    for (const i of nums){
        if (!(i in dict1)){
            dict1[i]=1;
        }
        else{
            dict1[i]+=1;
        }
    }

    for (let ii in dict1){
        let n = Math.floor(dict1[String(ii)]);
        if (n%2 === 0){
            
            sum_result+=n*(parseInt(n/2)-1)+(parseInt(n/2));
        }
        else{
            sum_result+=n*(parseInt(n/2));
        }
     
    }

    return sum_result    
};
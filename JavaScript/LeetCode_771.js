

var numJewelsInStones = function(J, S) {
    let result=0;
    for (const i of J){
        for(const ii of S){
            if (i==ii){
                result+=1;
            }
        }
    }
    return result;
};






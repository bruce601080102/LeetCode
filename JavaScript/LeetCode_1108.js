var defangIPaddr = function(address) {
    let result_block=[];
    for (const i of address){
        if (i == '.'){
            result_block.push('['+i+']');
        }
        else{
            result_block.push(i);
        }

    }
    return result_block.join('')
    
};
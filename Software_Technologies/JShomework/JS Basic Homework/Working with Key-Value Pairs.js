function KeyValuePairs(arr) {
    let obj = {};
    for (var i = 0; i < arr.length; i++) {
        let tokens = arr[i].split(" ");
        if(tokens.length>1){

            let key = tokens[0];
            let value = tokens[1];

            obj[key]=value;

        }
        else{
            let keyToPrint = tokens[0];
            if(obj.hasOwnProperty(keyToPrint)){
                console.log(obj[keyToPrint])
            }
            else{
                console.log("None")
            }

            break;
        }
    }
}
KeyValuePairs(["key value","key eulav","test tset","key"])
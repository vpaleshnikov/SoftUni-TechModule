function AddRemoveElements(arr) {
    let array = new Array().fill(0);
    for (var i = 0; i < arr.length; i++) {
        let tokens = arr[i].split(" ");
        let command = tokens[0];
        let number = tokens[1];
        if(command=== "add"){
            array.push(number)
        }
        else {
            array.splice(number,1);
        }

    }
    for (let num of array) {
        console.log(num)
    }
}
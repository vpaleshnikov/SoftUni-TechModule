function SetValueToIndexes(arr) {
    let lenght = Number(arr[0])
    let array = new Array(lenght).fill(0);
    for (var i = 1; i < arr.length; i++) {
        let tokens = arr[i].split(" - ")
        let index = tokens[0];
        let value =tokens[1];
        array[index]=value;
    }
    for (let num of array) {
        console.log(num)
    }
}
SetValueToIndexes(["3","0 - 5","1 - 6","2 - 7"])
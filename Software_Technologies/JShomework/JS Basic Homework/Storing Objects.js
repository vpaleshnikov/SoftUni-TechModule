function StoringObjects(arr) {

    let array = [];
    for (let i = 0; i < arr.length; i++) {
        let tokens = arr[i].split(" -> ")
        let name = tokens[0];
        let age = tokens[1];
        let grade = tokens[2];
        let obj = {};
        obj = {Name: name, Age: age, Grade: grade}
        array.push(obj);

    }
    for (let item of array) {
        console.log("Name:"+" " +item.Name)
        console.log("Age:"+" "+item.Age)
        console.log("Grade:"+" "+item.Grade)
    }

}
StoringObjects(["Pesho -> 13 -> 6.00"])
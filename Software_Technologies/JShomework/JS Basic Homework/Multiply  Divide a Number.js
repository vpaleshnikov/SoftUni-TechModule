function MultiplyOrDivide(arr) {
    let firstNumber = Number(arr[0])
    let secondNumber = Number(arr[1])

    if(firstNumber>secondNumber){
        console.log(firstNumber/secondNumber)
    }else{
        console.log(firstNumber*secondNumber)
    }
}
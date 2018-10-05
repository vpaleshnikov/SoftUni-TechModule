function ProductOfThreeNumbers(arr) {
    let firstNumber = Number(arr[0])
    let secondNumber = Number(arr[1])
     let thirdNumber = Number(arr[2])

    let counter = 0

    if(firstNumber<0){
        counter++;
    }
    if(secondNumber<0){
        counter++;
    }
    if(thirdNumber<0) {
        counter++;
    }
    if(counter%2==0 || firstNumber===0 || secondNumber===0 || thirdNumber===0){
        console.log("Positive")
    }
    else{
        console.log("Negative")
    }

}

ProductOfThreeNumbers(["3", "5", "7"]);
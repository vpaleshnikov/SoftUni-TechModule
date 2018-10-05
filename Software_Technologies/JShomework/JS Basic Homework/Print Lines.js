function PrintLines(inputs) {
    for(let input of inputs){
        if(input=="Stop"){
            return;
        }
        console.log(input)
    }
}
console.log(PrintLines(["line1"]));
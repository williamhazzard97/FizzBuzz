//Use a for loop to iterate through a set of values from 1-100 and print each one
for (var i = 1; i < 101; i++) {
    //Using IF statements, divide the current value and determine if it is divisible by 3, 5 or both 3 & 5("Fizz", "Buzz", "FizzBuzz") and print the appropriate result
    if (i % 15 == 0) {
        console.log("FizzBuzz");
    }
    else if (i % 3 == 0) {
        console.log("Fizz");
    }
    else if (i % 5 == 0) {
        console.log("Buzz");
    }
    //Print every other value (each number that is not divisble by 3 or 5)
    else console.log(i);
}
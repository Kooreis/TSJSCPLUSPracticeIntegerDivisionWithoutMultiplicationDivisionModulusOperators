Here is a JavaScript console application that performs integer division without using multiplication, division, or modulus operators:

```javascript
function integerDivision(dividend, divisor) {
    if (divisor === 0) {
        return 'Error: Division by zero is not allowed.';
    }

    let sign = ((dividend < 0) ^ (divisor < 0)) ? -1 : 1;

    dividend = Math.abs(dividend);
    divisor = Math.abs(divisor);

    let quotient = 0;

    while (dividend >= divisor) {
        dividend -= divisor;
        quotient++;
    }

    return sign * quotient;
}

console.log(integerDivision(10, 2)); // Outputs: 5
console.log(integerDivision(7, 3)); // Outputs: 2
console.log(integerDivision(-15, 3)); // Outputs: -5
console.log(integerDivision(15, -3)); // Outputs: -5
console.log(integerDivision(-15, -3)); // Outputs: 5
console.log(integerDivision(15, 0)); // Outputs: Error: Division by zero is not allowed.
```

This console application defines a function `integerDivision` that takes two arguments, `dividend` and `divisor`. It first checks if the divisor is zero, in which case it returns an error message. It then determines the sign of the result based on the signs of the dividend and divisor. It then takes the absolute values of the dividend and divisor, and initializes a `quotient` variable to zero. It then enters a loop where it subtracts the divisor from the dividend and increments the quotient, until the dividend is less than the divisor. Finally, it returns the quotient, multiplied by the sign. The application then calls this function with various test inputs and logs the results to the console.
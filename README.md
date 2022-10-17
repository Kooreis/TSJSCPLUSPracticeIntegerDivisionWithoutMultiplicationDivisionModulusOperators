# Question: How do you perform integer division without using multiplication, division, or modulus operators? JavaScript Summary

The JavaScript console application performs integer division without using multiplication, division, or modulus operators by implementing a subtractive process that mimics division. The function `integerDivision` accepts two arguments, the `dividend` and the `divisor`. It first checks if the divisor is zero, as division by zero is undefined, and returns an error message if so. The function then determines the sign of the result by checking if the dividend and divisor have different signs, storing this as `sign`. The absolute values of the dividend and divisor are then taken to ensure the subtraction process works correctly. A `quotient` variable is initialized at zero to keep track of how many times the divisor can be subtracted from the dividend. A loop is then initiated where the divisor is subtracted from the dividend and the quotient is incremented each time, continuing until the dividend is less than the divisor. The function then returns the quotient, adjusted for the correct sign. The application demonstrates this function by calling it with various test inputs and logging the results.

---

# TypeScript Differences

The TypeScript version of the solution is similar to the JavaScript version in terms of logic, but there are some differences in the way they are structured and how they handle certain situations.

1. Structure: The TypeScript version is written in a class-based format, with a static method `divide` inside the `Division` class. This is a more object-oriented approach compared to the JavaScript version, which uses a standalone function.

2. Type Annotations: TypeScript version uses type annotations (`dividend: number, divisor: number`) to ensure that the parameters passed to the `divide` method are numbers. This provides a level of type safety that is not present in the JavaScript version.

3. Error Handling: In the JavaScript version, if the divisor is zero, it returns a string error message. In the TypeScript version, it throws an Error, which is a more standard way of handling errors in many programming languages.

4. Sign Handling: The JavaScript version handles both positive and negative numbers, and it calculates the sign of the result based on the signs of the dividend and divisor. The TypeScript version does not handle negative numbers. If the dividend is less than the divisor, it returns 0, which is not the case in the JavaScript version.

5. Test Cases: The JavaScript version includes more diverse test cases, including cases with negative numbers and zero divisor. The TypeScript version only includes positive numbers and does not test the case of zero divisor.

---

# C++ Differences

The C++ version of the solution uses a similar approach to the JavaScript version, but with a few key differences due to the language features and methods available in C++.

1. Error Handling: In the JavaScript version, if the divisor is zero, it returns an error message. In the C++ version, it checks if the dividend is the minimum integer value and the divisor is -1, which would result in an overflow error. In this case, it returns the maximum integer value.

2. Type Conversion: The JavaScript version uses the `Math.abs` function to convert the dividend and divisor to their absolute values. The C++ version uses the `labs` function to do the same thing, but it also converts the dividend and divisor to `long` type to prevent overflow.

3. Bitwise Operations: The C++ version uses bitwise shift operators (`<<=` and `<<`) to double the divisor and a multiplier `m` until the divisor is greater than the dividend. This is a more efficient way to subtract the divisor from the dividend multiple times. The JavaScript version simply subtracts the divisor from the dividend once per loop iteration.

4. Input/Output: The C++ version uses `std::cin` and `std::cout` for input and output, while the JavaScript version uses `console.log` for output.

5. Main Function: The C++ version includes a `main` function that prompts the user for input and calls the `divide` function, while the JavaScript version calls the `integerDivision` function with hard-coded test inputs.

---

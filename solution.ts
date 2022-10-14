Here is a TypeScript console application that performs integer division without using multiplication, division, or modulus operators:

```typescript
class Division {
    static divide(dividend: number, divisor: number): number {
        if (divisor === 0) {
            throw new Error("Divisor cannot be zero");
        }

        if (dividend < divisor) {
            return 0;
        }

        let count = 0;
        while (dividend >= divisor) {
            dividend -= divisor;
            count++;
        }

        return count;
    }
}

console.log(Division.divide(10, 2));
console.log(Division.divide(7, 3));
console.log(Division.divide(20, 5));
console.log(Division.divide(100, 10));
```

This program defines a class `Division` with a static method `divide` that performs integer division. The `divide` method subtracts the divisor from the dividend in a loop until the dividend is less than the divisor, and counts the number of subtractions, which is the quotient of the division. The program then tests the `divide` method with some example inputs.
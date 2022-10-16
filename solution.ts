class Division {
    static divide(dividend: number, divisor: number): number {
        if (divisor === 0) {
            throw new Error("Divisor cannot be zero");
        }

        if (dividend < divisor) {
            return 0;
        }
    }
}
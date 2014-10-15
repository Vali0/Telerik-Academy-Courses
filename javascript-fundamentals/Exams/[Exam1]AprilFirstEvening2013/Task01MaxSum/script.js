function maxConsecutiveSum(params) {
    var i,
        arraySize,
        max_so_far = 0,
        max_ended_here = 0,
        hasPositive = false;

    for (i = 0, len = params.length; i < len; i++) {
        params[i] = +params[i];
        if (i !==0 && params[i] > 0) {
            hasPositive = true;
        }
    }

    var numbers = params.slice(1, params.length);
    if (!hasPositive) {
        return Math.max.apply(null, numbers);
    }
    arraySize = params[0];
    for (i = 0; i < numbers.length ; i++) {
        max_ended_here += numbers[i];

        if (max_ended_here < 0) {
            max_ended_here = 0;
        }
        if (max_so_far < max_ended_here) {
            max_so_far = max_ended_here
        }
    }

    return max_so_far;
}
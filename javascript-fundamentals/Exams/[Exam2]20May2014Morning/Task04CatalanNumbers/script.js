function a(n) {
    n = n | 0;
    if (n == 1)
        return 1 / 2
    else
        return 2 * (2 * n - 1) * a(n - 1) / (n + 1)
}
using System;

int n = 5;

int[] fibonacci = CreateFibonacciSeries(n);

for (int i = 0; i < fibonacci.Length; i++) {
  Console.WriteLine($"f_{i} = {fibonacci[i]}");
}



static int[] CreateFibonacciSeries(int count) {
  int[] series = new int[count];
  for (int i = 0; i < count; i++)
    series[i] = CreateFibonacciNumber(i);
  return series;
}

static int CreateFibonacciNumber(int index) {
  return index switch {
    0 => 0,
    1 => 1,
    _ => CreateFibonacciNumber(index - 1) + CreateFibonacciNumber(index - 2)
  };
}

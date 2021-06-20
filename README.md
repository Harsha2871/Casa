A simple solution to check a prime number is prime is to iterate from 2 till the given number-1 and check
if anything divides the given number, if if does, then we return False so that given is not a prime. If the control
exits out of the loop, we return False. The time complexity will be O(n).

A better approach is instead of iterating from 2 till the give number n, we itearate from 2 to only n/2, because 
we can see that the largest factor that divide n can be found before n/2, in this case the time complexity will be
O(n/2).

A much better approach:

We iterate from 2 to sqrt(n) because... 

Let's say m = sqrt(n) then m × m = n. Now if n is not a prime then n can be written as n = a*b, so m × m = a*b. Notice that m is a real number whereas n, a and b are natural numbers.
Now there can be 3 cases:
a > m => b < m
a = m => b = m
a < m => b > m
In all 3 cases, min(a, b) ≤ m. Hence if we search till m, we are bound to find at least one factor of n, which is enough to show that n is not prime.

#Corner Case
Note that in all the cases if n<=1, we return False.

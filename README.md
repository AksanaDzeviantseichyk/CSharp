## TechTask
- write a console application;
### Input of application (via keyboard):
- coordinates of 3 points in 2-dimensional coordinate system;
 
### Output of application (to console):
- the length of triangle sides;
- is it equilateral triangle?
- is it isosceles triangle?
- is it right triangle?
- the perimeter of the triangle;
- even numbers from 0 to value of triangle perimeter.

### Note:
- input values can be with fractional part;
- output values can be rounded;
- you can choose you own precision during calculations:
For example, for a triangle À(0,0), Â(0,4), Ñ(0,4) sides length will be 4, 5,656854249492381, 4. It is the right triangle, because ÀÂ^2 + ÀÑ^2 = ÂÑ^2. But 42 + 42 != 5,6568542494923812 (due to a precision of double variable type). To solve this problem, you can say that the triangle is right if ÂÑ^2 – (ÀÂ^2 + ÀÑ^2) <= delta, where delta – you own precision.

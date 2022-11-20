---

theme: jekyll-theme-hacker

title: Research

permalink: /Week8/research

---

# Research
> Consider X and Y uniform r.vs. and use them to determine points on a plane as image. Determine the empirical distribution of the Cartesian coordinates. Search for the methods to generate a NORMAL r.v. X

# Points distribution in a circle

The easiest way to get a random point in a circle is to use polar notation.
With polar notation, you can define any point in the circle with the polar angle ($\tetha$) and the length of the hypotenuse ($hyp$).

For both, we can apply a random number generator to give us a value in a usable range. The polar angle will be in the range $[0, 2 * pi]$ and 
the hypotenuse will be in the range $[0, radius]$.

Things can get tricky when we're finding a random value for the hypotenuse, however, because if we evenly favor the entire allowable range, 
the points will tend to be more densely packed towards the center of the circle.

Take, for example, a circle with a radius of 1. If we divide the radius in half, the area in which the points with a hypotenuse
in the smaller half ($[0, 0.5]$) will be scattered is a circle of radius 0.5 whose area is defined as $\pi * (0.5)^2$, or $0.25 * \pi$. 
The area in which the points with a hypotenuse in the larger half ($[0.5, 1]$) will be scattered is the remaining difference of the larger circle, 
defined as $\pi * 1^2 - 0.25 * pi$, or $0.75 * \pi$.



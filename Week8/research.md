---

theme: jekyll-theme-hacker

title: Research

permalink: /Week8/research

---

# Research
> Consider X and Y uniform r.vs. and use them to determine points on a plane as image. Determine the empirical distribution of the Cartesian coordinates. Search for the methods to generate a NORMAL r.v. X

# Points distribution in a circle

The easiest way to get a random point in a circle is to use polar notation.
With polar notation, you can define any point in the circle with the polar angle ($\theta$) and the length of the hypotenuse ($hyp$).

For both, we can apply a random number generator to give us a value in a usable range. The polar angle will be in the range $[0, 2 * pi]$ and 
the hypotenuse will be in the range $[0, radius]$.

Things can get tricky when we're finding a random value for the hypotenuse, however, because if we evenly favor the entire allowable range, 
the points will tend to be more densely packed towards the center of the circle.

Take, for example, a circle with a radius of 1. If we divide the radius in half, the area in which the points with a hypotenuse
in the smaller half ($[0, 0.5]$) will be scattered is a circle of radius 0.5 whose area is defined as $\pi(\frac{1}{2})^2$, or $0.25 * \pi$. 
The area in which the points with a hypotenuse in the larger half ($[0.5, 1]$) will be scattered is the remaining difference of the larger circle, 
defined as $\pi - \frac{\pi}{4}$, or $0.75 * \pi$.

<img width="500" alt="area" src="https://user-images.githubusercontent.com/105921751/202916828-bb0abcec-d00b-4a3c-9c0b-f76d7a0bccbb.jpeg">

So even though the two halves are even, the area described by rotating the two halves around the center are drastically different. In order to allow for an even distribution, then, we need to take the square root of the random number before multiplying it by the radius to get our hypotenuse, so that we can exponentially favor values farther from the center.

Once we have our values for $\theta$ and $hyp$, we can simply use sine and cosine to obtain values for the opposite ($opp$) and adjacent ($adj$) legs of our right triangle, which will equal the amount we need to add to/subtract from the x and y coordinates of our center point $(XC, YC)$.

<img width="500" alt="dLc2H2S" src="https://user-images.githubusercontent.com/105921751/202917376-7f5eff32-97b0-46c4-b48c-8c663a5592c3.png">

## Marsaglia polar method [^1]

The Marsaglia polar method is a pseudo-random number sampling method for generating a pair of independent standard normal random variables.
The polar method works by choosing random points $(x, y)$ in the square $−1 < x < 1$, $−1 < y < 1$ until

$$
0 < s = x^2 + y^2 <1
$$

and then returning the required pair of normal random variables as

$$
\frac{x}{\sqrt{s}}\sqrt{-2\ln(s)}\,\,\,\frac{y}{\sqrt{s}}\sqrt{-2\ln(s)}
$$

where $x/\sqrt{s}$ and $y/\sqrt{s}$ represent the cosine and sine of the angle that the vector $(x, y)$ makes with $x$ axis.


[^1]: https://en.wikipedia.org/wiki/Marsaglia_polar_method

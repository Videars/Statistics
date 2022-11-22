---

theme: jekyll-theme-hacker

title: Research

permalink: /Week8/research

---

# Research
> Derivations of the normal distribution. Consider X and Y uniform r.vs. and use them to determine points on a plane as image. Determine the empirical distribution of the Cartesian coordinates. Search for the methods to generate a NORMAL r.v. X

## Normal distribution derivations
### De Moivre

As $n$ grows large, for $k$ in the neighborhood of $np$ we can approximate

$$
{n\choose k}\,p^{k}q^{n-k}\simeq{\frac{1}{\sqrt{2\pi npq}}}\,e^{-{\frac{(k-np)^{2}}{2npq}}},\qquad p+q=1,\ p,q>0
$$

in the sense that the ratio of the left-hand side to the right-hand side converges to $1$ as $n\to\infty$.

### Gauss

A Gaussian function is a function of the base form

$$
f(x)=Ae^{-{\frac{(x-b)^{2}}{2c^{2}}}}
$$

for arbitrary real constants $A$, $b$ and non-zero $c$.

Gaussian functions are often used to represent the probability density function of a normally distributed random variable with expected value $\mu = b$ and variance $\sigma^2 = c^2$. In this case, the Gaussian is of the form

$$
g(x)={\frac {1}{\sigma {\sqrt {2\pi }}}}e^{-{\frac {1}{2}}{\frac {(x-\mu )^{2}}{\sigma ^{2}}}}
$$

### Central Limit theorem

Suppose $X_1,\ldots ,X_n,\ldots$ is a sequence of i.i.d. random variables with $\mathbb{E}[X_{i}]=\mu$ and $Var[X_{i}]=\sigma^{2}<\infty$. Then as $n$ approaches infinity, the random variables ${\sqrt{n}}({\bar{X}}_ {n}-\mu)$ converge in distribution to a normal $\mathcal{N}(0,\sigma^{2})$:

$$
\sqrt{n}\left({\bar{X}}_ {n}-\mu \right)\ \xrightarrow{d} \ {\mathcal {N}}\left(0,\sigma ^{2}\right)
$$

## Points distribution in a circle

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

# Important distributions

### Chi squared distribution [^2]

If $Z1, \ldots, Zk$ are independent, standard normal random variables, then the sum of their squares,

$$
Q =\sum_{i=1}^{k}Z_{i}^{2}
$$

is distributed according to the chi-squared distribution with $k$ degrees of freedom. This is usually denoted as

$$
Q\sim\chi^{2}(k)\ \ {\text{or}}\ \ Q\sim\chi_{k}^{2}
$$

The chi-squared distribution has one parameter: a positive integer $k$ that specifies the number of degrees of freedom (the number of random variables being summed).

### Cauchy distribution [^3]

The Cauchy distribution has the probability density function:

$$
f(x;x_{0},\gamma)=\frac{1}{\pi\gamma\left[1+\left(\frac{x-x_{0}}{\gamma}\right)^{2}\right]}={1\over\pi\gamma}\left[{\gamma^{2}\over(x-x_{0})^{2}+\gamma^{2}}\right]
$$

where $x_0$ is the location parameter, specifying the location of the peak of the distribution, and $\gamma$  is the scale parameter which specifies the half-width at half-maximum (HWHM), alternatively $2\gamma$  is full width at half maximum (FWHM). $\gamma$  is also equal to half the interquartile range and is sometimes called the probable error.

### Fisher-Snedocor distribution [^4]

The F-distribution with $d1$ and $d2$ degrees of freedom is the distribution of

$$
X=\frac{S_{1}/d_{1}}{S_{2}/d_{2}}
$$

where $S_{1}$ and $S_{2}$ are independent random variables with chi-square distributions with respective degrees of freedom $d_{1}$ and $d_{2}$.

### T-Student distribution [^5]

The distribution of a Student-T random variable, defined as:

$$
{T_{n}={\frac {Z}{\sqrt {K/n}}}}
$$
 
where $Z$ is a normal random variable and $K$ is a $\chi^2$ random variable with $n$ degrees of freedom.

# Application

### Random points generation
Here is a video of the first application made. We generate random points using polar coordinates sampling the radius and the angle as uniform distributions and then graph the distribution of the points obtained inside the circle of max radius.
<iframe width="800" height="400" src="https://user-images.githubusercontent.com/105921751/203304198-fe4e38c9-c745-4833-b58a-50675331ee48.mp4" frameborder="0" allowfullscreen></iframe>

### Distributions
In the second application we start from a sample of points taken from a Normal distribution (generated by the methods explained in the research above) and the we computed the distributions of the following random variables: $X$, $X^2$, $X/Y^2$, $X^2/Y^2$ , $X/Y$.
<iframe width="800" height="400" src="https://user-images.githubusercontent.com/105921751/203304225-b27b129e-6b28-4e6f-9263-bea0c8fa0de0.mp4" frameborder="0" allowfullscreen></iframe>

[^1]: https://en.wikipedia.org/wiki/Marsaglia_polar_method
[^2]: https://en.wikipedia.org/wiki/Chi-squared_distribution
[^3]: https://en.wikipedia.org/wiki/Cauchy_distribution
[^4]: https://en.wikipedia.org/wiki/F-distribution
[^5]: https://en.wikipedia.org/wiki/Student%27s_t-distribution
